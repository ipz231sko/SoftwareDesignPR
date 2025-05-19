using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public class ReportService : BaseTransactionService
    {
        private Dictionary<string, decimal> _expenseByCategoryCache;
        private Dictionary<string, decimal> _incomeByCategoryCache;
        private Dictionary<CategorySubcategoryKey, decimal> _expenseBySubcategoryCache;

        public ReportService(List<Transaction> transactions) : base(transactions) { }

        public Dictionary<string, decimal> GetExpenseByCategory()
        {
            if (_expenseByCategoryCache == null)
            {
                _expenseByCategoryCache = GetTransactionsOfType<Expense>()
                    .GroupBy(t => t.Category)
                    .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
            }
            return _expenseByCategoryCache;
        }

        public Dictionary<string, decimal> GetIncomeByCategory()
        {
            if (_incomeByCategoryCache == null)
            {
                _incomeByCategoryCache = GetTransactionsOfType<Income>()
                    .GroupBy(t => t.Category)
                    .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
            }
            return _incomeByCategoryCache;
        }

        public Dictionary<CategorySubcategoryKey, decimal> GetExpenseByCategoryAndSubcategory()
        {
            if (_expenseBySubcategoryCache == null)
            {
                _expenseBySubcategoryCache = GetTransactionsOfType<Expense>()
                    .GroupBy(t => new CategorySubcategoryKey(t.Category, t.Subcategory))
                    .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
            }
            return _expenseBySubcategoryCache;
        }

        public int GetTransactionCount() => _transactions.Count;

        public int GetExpenseTransactionCount() => GetTransactionsOfType<Expense>().Count();

        public int GetIncomeTransactionCount() => GetTransactionsOfType<Income>().Count();

        public decimal GetAverageExpense()
        {
            var expenses = GetTransactionsOfType<Expense>().ToList();
            return expenses.Count > 0 ? expenses.Average(t => t.Amount) : 0;
        }

        public decimal GetAverageIncome()
        {
            var incomes = GetTransactionsOfType<Income>().ToList();
            return incomes.Count > 0 ? incomes.Average(t => t.Amount) : 0;
        }

        public Transaction GetLargestExpense() => GetTransactionsOfType<Expense>()
            .OrderByDescending(t => t.Amount)
            .FirstOrDefault();

        public Transaction GetLargestIncome() => GetTransactionsOfType<Income>()
            .OrderByDescending(t => t.Amount)
            .FirstOrDefault();
    }
}
