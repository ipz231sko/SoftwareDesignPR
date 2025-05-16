using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public class ReportService
    {
        private readonly List<Transaction> _transactions;

        public ReportService(List<Transaction> transactions)
        {
            _transactions = transactions ?? throw new ArgumentNullException(nameof(transactions));
        }

        public decimal GetTotalIncome()
        {
            return _transactions.OfType<Income>().Sum(t => t.Amount);
        }

        public decimal GetTotalExpense()
        {
            return _transactions.OfType<Expense>().Sum(t => t.Amount);
        }

        public Dictionary<string, decimal> GetExpenseByCategory()
        {
            return _transactions
                .OfType<Expense>()
                .GroupBy(t => t.Category)
                .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
        }
        public Dictionary<string, decimal> GetIncomeByCategory()
        {
            return _transactions
                .OfType<Income>()
                .GroupBy(t => t.Category)
                .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
        }

        public Dictionary<CategorySubcategoryKey, decimal> GetExpenseByCategoryAndSubcategory()
        {
            return _transactions
                .OfType<Expense>()
                .GroupBy(t => new CategorySubcategoryKey(t.Category, t.Subcategory))
                .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));
        }

        public int GetTransactionCount()
        {
            return _transactions.Count;
        }

        public int GetExpenseTransactionCount()
        {
            return _transactions.OfType<Expense>().Count();
        }

        public int GetIncomeTransactionCount()
        {
            return _transactions.OfType<Income>().Count();
        }

        public decimal GetAverageExpense()
        {
            var expenses = _transactions.OfType<Expense>().ToList();
            return expenses.Any() ? expenses.Average(t => t.Amount) : 0;
        }

        public decimal GetAverageIncome()
        {
            var incomes = _transactions.OfType<Income>().ToList();
            return incomes.Any() ? incomes.Average(t => t.Amount) : 0;
        }

        public Transaction GetLargestExpense()
        {
            return _transactions.OfType<Expense>().OrderByDescending(t => t.Amount).FirstOrDefault();
        }

        public Transaction GetLargestIncome()
        {
            return _transactions.OfType<Income>().OrderByDescending(t => t.Amount).FirstOrDefault();
        }
    }
}
