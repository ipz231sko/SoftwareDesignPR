using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public static class TransactionFactory
    {
        private const string INCOME_TYPE = "Дохід";
        private const string EXPENSE_TYPE = "Витрата";

        public static Transaction CreateTransaction(string type, decimal amount, string category, string subcategory, string description, DateTime date)
        {
            if (type == INCOME_TYPE)
            {
                return new Income
                {
                    Amount = amount,
                    Category = category,
                    Subcategory = subcategory,
                    Description = description,
                    Date = date
                };
            }
            else if (type == EXPENSE_TYPE)
            {
                return new Expense
                {
                    Amount = amount,
                    Category = category,
                    Subcategory = subcategory,
                    Description = description,
                    Date = date
                };
            }
            return null;
        }
    }
}
