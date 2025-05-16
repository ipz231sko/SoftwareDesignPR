using MainForm.Data;
using MainForm.Models;
using MainForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class TransactionListForm : Form
    {
        private readonly BudgetService _budgetService;
        public TransactionListForm(BudgetService budgetService)
        {
            InitializeComponent();
            dataGridViewTransactions.Columns.Add("ColumnDate", "Дата");
            dataGridViewTransactions.Columns.Add("ColumnType", "Тип");
            dataGridViewTransactions.Columns.Add("ColumnCategory", "Категорія");
            dataGridViewTransactions.Columns.Add("ColumnSubcategory", "Підкатегорія");
            dataGridViewTransactions.Columns.Add("ColumnAmount", "Сума");
            dataGridViewTransactions.Columns.Add("ColumnDescription", "Опис");

            _budgetService = budgetService;
            comboBoxFilter.Items.AddRange(new[] { "Усі", "Дохід", "Витрата" });
            comboBoxTransactionCategory.Items.Add("Усі");
            comboBoxTransactionCategory.Items.AddRange(CategoryData.IncomeCategories.ToArray());
            comboBoxTransactionCategory.Items.AddRange(CategoryData.ExpenseCategories.Keys.ToArray());

            ResetSubcategoryFilter();

            comboBoxSubcategoryFilter.SelectedIndex = 0;

            comboBoxFilter.SelectedIndex = 0;
            comboBoxTransactionCategory.SelectedIndex = 0;
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
            dateTimePickerTo.Value = DateTime.Today;
            comboBoxTransactionCategory.SelectedIndexChanged += comboBoxTransactionCategory_SelectedIndexChanged;
            LoadTransactions();
        }
        private void LoadTransactions()
        {

            dataGridViewTransactions.Rows.Clear();

            var selectedType = comboBoxFilter.SelectedItem?.ToString();
            var selectedCategory = comboBoxTransactionCategory.SelectedItem?.ToString();
            var selectedSubcategory = comboBoxSubcategoryFilter.SelectedItem?.ToString();
            var from = dateTimePickerFrom.Value.Date;
            var to = dateTimePickerTo.Value.Date.AddDays(1);

            string internalType = selectedType == "Усі" ? null : selectedType;

            var filtered = _budgetService.Transactions.Where(t =>
                (selectedType == "Усі" || t.Type == selectedType) &&
                (selectedCategory == "Усі" || t.Category == selectedCategory) &&
                (selectedSubcategory == "Усі" || string.IsNullOrEmpty(selectedSubcategory) || t.Subcategory == selectedSubcategory) &&
                t.Date >= from && t.Date <= to
            ).ToList();
            MessageBox.Show($"Усього транзакцій: {_budgetService.Transactions.Count}\nПісля фільтрації: {filtered.Count()}");
            foreach (var t in filtered)
            {
                dataGridViewTransactions.Rows.Add(
                    t.Date.ToShortDateString(),
                    t.Type,
                    t.Category,
                    t.Subcategory,
                    $"{t.Amount} грн",
                    t.Description
                );
            }
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void buttonDeleteSelectedTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть транзакцію для видалення", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dataGridViewTransactions.SelectedRows[0];
            var dateStr = row.Cells[0].Value.ToString();
            var type = row.Cells[1].Value.ToString();
            var category = row.Cells[2].Value.ToString();
            var subcategory = row.Cells[3].Value.ToString();
            var amountStr = row.Cells[4].Value.ToString().Replace(" грн", "");
            var description = row.Cells[5].Value.ToString();

            if (!DateTime.TryParse(dateStr, out DateTime date) || !decimal.TryParse(amountStr, out decimal amount))
                return;

            var target = _budgetService.Transactions.FirstOrDefault(t =>
                t.Date.Date == date.Date &&
                t.Type == type &&
                t.Category == category &&
                t.Subcategory == subcategory &&
                t.Amount == amount &&
                t.Description == description);

            if (target != null)
            {
                _budgetService.DeleteTransaction(target);
                LoadTransactions();
                MessageBox.Show("Транзакцію видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxTransactionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetSubcategoryFilter();

            var selectedCategory = comboBoxTransactionCategory.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory) &&
                selectedCategory != "Усі" &&
                CategoryData.ExpenseCategories.ContainsKey(selectedCategory))
            {
                var subcategories = CategoryData.ExpenseCategories[selectedCategory];
                comboBoxSubcategoryFilter.Items.AddRange(subcategories.ToArray());
            }

            comboBoxSubcategoryFilter.SelectedIndex = 0;
        }

        private void ResetSubcategoryFilter()
        {
            comboBoxSubcategoryFilter.Items.Clear();
            comboBoxSubcategoryFilter.Items.Add("Усі");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditeSelectedTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть транзакцію для редагування", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dataGridViewTransactions.SelectedRows[0];

            var date = DateTime.Parse(row.Cells[0].Value.ToString());
            var type = row.Cells[1].Value.ToString();
            var category = row.Cells[2].Value.ToString();
            var subcategory = row.Cells[3].Value.ToString();
            var amount = decimal.Parse(row.Cells[4].Value.ToString().Replace(" грн", ""));
            var description = row.Cells[5].Value.ToString();

            var original = _budgetService.Transactions.FirstOrDefault(t =>
                t.Date.Date == date.Date &&
                t.Type == type &&
                t.Category == category &&
                t.Subcategory == subcategory &&
                t.Amount == amount &&
                t.Description == description);

            if (original == null)
            {
                MessageBox.Show("Не вдалося знайти транзакцію", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editForm = new AddTransactionForm(_budgetService, original);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadTransactions();
            }
        }
    }
}