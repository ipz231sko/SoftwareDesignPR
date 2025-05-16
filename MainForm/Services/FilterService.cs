using MainForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Services
{
    public static class FilterService
    {
        public static List<Transaction> ApplyFilter(
            IEnumerable<Transaction> transactions,
            string selectedType,
            string selectedCategory,
            string selectedSubcategory,
            DateTime from,
            DateTime to)
        {
            return transactions.Where(t =>
                (selectedType == "Усі" || t.Type == selectedType) &&
                (selectedCategory == "Усі" || t.Category == selectedCategory) &&
                (selectedSubcategory == "Усі" || string.IsNullOrEmpty(selectedSubcategory) || t.Subcategory == selectedSubcategory) &&
                t.Date >= from && t.Date <= to
            ).ToList();
        }
    }
}
