using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public abstract class BaseTransactionService
    {
        protected readonly List<Transaction> _transactions;
        protected decimal? _cachedTotalIncome;
        protected decimal? _cachedTotalExpense;


        protected BaseTransactionService(List<Transaction> transactions)
        {
            _transactions = transactions ?? throw new ArgumentNullException(nameof(transactions));
        }

        public decimal GetTotalIncome()
        {
            if (_cachedTotalIncome == null)
                _cachedTotalIncome = _transactions
                    .OfType<Income>()
                    .Sum(t => t.Amount);

            return _cachedTotalIncome.Value;
        }

        public decimal GetTotalExpense()
        {
            if (_cachedTotalExpense == null)
                _cachedTotalExpense = _transactions
                    .OfType<Expense>()
                    .Sum(t => t.Amount);

            return _cachedTotalExpense.Value;
        }

        public decimal GetBalance() => GetTotalIncome() - GetTotalExpense();

        protected IEnumerable<T> GetTransactionsOfType<T>() where T : Transaction
        {
            return _transactions.OfType<T>();
        }
    }
}
