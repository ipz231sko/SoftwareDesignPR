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
    }
}
