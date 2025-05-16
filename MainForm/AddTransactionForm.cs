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
    public partial class AddTransactionForm : Form
    {
        private readonly BudgetService _budgetService;
        public AddTransactionForm(BudgetService budgetService)
        {
            InitializeComponent();
            _budgetService = budgetService;
            comboBoxTransictionType.SelectedIndex = 0;
            comboBoxTransactionCategory.SelectedIndex = 0;
        }

        private void buttonTransactionSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxSum.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Введіть дійсну суму. Сума не може бути меншою чи рівною нулю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var type = comboBoxTransictionType.SelectedItem.ToString();
            var category = comboBoxTransactionCategory.SelectedItem?.ToString() ?? "";
            var description = textBoxTransactionDescription.Text;
            var date = dateTimePickerTransaction.Value;

            Transaction transaction;

            if (type == "Дохід")
            {
                transaction = new Income
                {
                    Amount = amount,
                    Category = category,
                    Description = description,
                    Date = date
                };
            }
            else if (type == "Витрата")
            {
                transaction = new Expense
                {
                    Amount = amount,
                    Category = category,
                    Description = description,
                    Date = date
                };
            }
            else
            {
                MessageBox.Show("Невірний тип транзакції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _budgetService.AddTransaction(transaction);

            MessageBox.Show("Транзакцію успішно додано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            textBoxSum.Clear();
            textBoxTransactionDescription.Clear();
            comboBoxTransictionType.SelectedIndex = 0;
            comboBoxTransactionCategory.SelectedIndex = 0;
            dateTimePickerTransaction.Value = DateTime.Today;
        }
    }
}
