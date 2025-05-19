using MainForm.Interfaces;
using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public class BudgetService : BaseTransactionService
    {
        private readonly ITransactionRepository _repository;

        public BudgetService(ITransactionRepository repository)
            : base(repository != null ? repository.Load() : throw new ArgumentNullException(nameof(repository)))
        {
            _repository = repository;
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            _transactions.Add(transaction);
            InvalidateCache();
            _repository.Save(_transactions);
        }

        public void DeleteTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            if (_transactions.Remove(transaction))
            {
                InvalidateCache();
                _repository.Save(_transactions);
            }
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from = null, DateTime? to = null,
            string category = null, string type = null)
        {
            var query = _transactions.AsEnumerable();

            if (from.HasValue)
                query = query.Where(t => t.Date >= from.Value);

            if (to.HasValue)
                query = query.Where(t => t.Date <= to.Value);

            if (!string.IsNullOrEmpty(category))
                query = query.Where(t => t.Category == category);

            if (!string.IsNullOrEmpty(type))
                query = query.Where(t => t.Type.Equals(type, StringComparison.OrdinalIgnoreCase));

            return query.ToList();
        }

        private void InvalidateCache()
        {
            _cachedTotalIncome = null;
            _cachedTotalExpense = null;
        }
    }
}
