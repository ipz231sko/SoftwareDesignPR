using MainForm.Interfaces;
using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public class BudgetService
    {
        private readonly ITransactionRepository _repository;
        public List<Transaction> Transactions { get; private set; }

        public BudgetService(ITransactionRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            Transactions = _repository.Load();
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));
            Transactions.Add(transaction);
            _repository.Save(Transactions);
        }

        public void DeleteTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));
            Transactions.Remove(transaction);
            _repository.Save(Transactions);
        }

        public decimal GetBalance()
        {
            decimal income = Transactions.OfType<Income>().Sum(t => t.Amount);
            decimal exponse = Transactions.OfType<Expense>().Sum(t => t.Amount);
            return income - exponse;
        }

        public decimal GetTotalIncome()
        {
            return Transactions.OfType<Income>().Sum(t => t.Amount);
        }

        public decimal GetTotalExpense()
        {
            return Transactions.OfType<Expense>().Sum(t => t.Amount);
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from = null, DateTime? to = null, string category = null, string type = null)
        {
            return Transactions.Where(t =>
            (!from.HasValue || t.Date >= from.Value) &&
            (!to.HasValue || t.Date <= to.Value) &&
            (string.IsNullOrEmpty(category) || t.Category == category) &&
            (string.IsNullOrEmpty(type) || t.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
            );
        }
    }
}
