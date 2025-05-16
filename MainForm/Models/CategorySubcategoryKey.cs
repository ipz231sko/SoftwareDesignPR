using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class CategorySubcategoryKey
    {
        public string Category { get; }
        public string Subcategory { get; }

        public CategorySubcategoryKey(string category, string subcategory)
        {
            Category = category ?? string.Empty;
            Subcategory = subcategory ?? string.Empty;
        }

        public override bool Equals(object obj)
        {
            return obj is CategorySubcategoryKey other &&
                   Category == other.Category &&
                   Subcategory == other.Subcategory;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Category.GetHashCode();
                hash = hash * 23 + Subcategory.GetHashCode();
                return hash;
            }
        }
    }
}
