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
            dataGridViewTransactions.Columns.Add("ColumnAmount", "Сума");
            dataGridViewTransactions.Columns.Add("ColumnDescription", "Опис");

            _budgetService = budgetService;
            comboBoxFilter.Items.AddRange(new[] { "Усі", "Дохід", "Витрата" });
            comboBoxTransactionCategory.Items.AddRange(new[] {
                "Усі",
                "Продукти та супермаркет",
                "Одяг та взуття",
                "Благодійність",
                "Подорожі",
                "Книги",
                "Краса та здоров'я",
                "Поповнення мобільного",
                "Розваги та спорт"
            });
            comboBoxFilter.SelectedIndex = 0;
            comboBoxTransactionCategory.SelectedIndex = 0;
            dateTimePickerFrom.Value = DateTime.Today.AddMonths(-1);
            dateTimePickerTo.Value = DateTime.Today;

            LoadTransactions();
        }
        private void LoadTransactions()
        {

            dataGridViewTransactions.Rows.Clear();

            var selectedType = comboBoxFilter.SelectedItem?.ToString();
            var selectedCategory = comboBoxTransactionCategory.SelectedItem?.ToString();
            var from = dateTimePickerFrom.Value.Date;
            var to = dateTimePickerTo.Value.Date.AddDays(1);

            string internalType = selectedType == "Усі" ? null : selectedType;

            var filtered = _budgetService.GetTransactions(
                from,
                to,
                selectedCategory == "Усі" ? null : selectedCategory,
                internalType
            );
            MessageBox.Show($"Усього транзакцій: {_budgetService.Transactions.Count}\nПісля фільтрації: {filtered.Count()}");
            foreach (var t in filtered)
            {
                dataGridViewTransactions.Rows.Add(
                    t.Date.ToShortDateString(),
                    t.Type,
                    t.Category,
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
            var amountStr = row.Cells[3].Value.ToString().Replace(" грн", "");
            var description = row.Cells[4].Value.ToString();

            if (!DateTime.TryParse(dateStr, out DateTime date) || !decimal.TryParse(amountStr, out decimal amount))
                return;

            var target = _budgetService.Transactions.FirstOrDefault(t =>
                t.Date.Date == date.Date &&
                t.Type == type &&
                t.Category == category &&
                t.Amount == amount &&
                t.Description == description);

            if (target != null)
            {
                _budgetService.DeleteTransaction(target);
                LoadTransactions();
                MessageBox.Show("Транзакцію видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
