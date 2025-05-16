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
using MainForm.Models;
using MainForm.Data;

namespace MainForm
{
    public partial class AddTransactionForm : Form
    {
        private readonly BudgetService _budgetService;
        private readonly Transaction _editingTransaction;
        private readonly bool _isEditMode;
        public AddTransactionForm(BudgetService budgetService)
        {
            InitializeComponent();
            _budgetService = budgetService;
            comboBoxTransictionType.SelectedIndexChanged += comboBoxTransictionType_SelectedIndexChanged_1;
            comboBoxTransactionCategory.SelectedIndexChanged += comboBoxTransactionCategory_SelectedIndexChanged;
        }
        public AddTransactionForm(BudgetService budgetService, Transaction transactionToEdit)
    : this(budgetService)
        {
            _editingTransaction = transactionToEdit;
            _isEditMode = true;
            this.Text = "Редагувати транзакцію";

            comboBoxTransictionType.SelectedItem = transactionToEdit.Type;
            comboBoxTransictionType.Enabled = false;

            comboBoxTransictionType_SelectedIndexChanged_1(null, null);

            int catIndex = comboBoxTransactionCategory.Items.IndexOf(transactionToEdit.Category);
            if (catIndex >= 0)
                comboBoxTransactionCategory.SelectedIndex = catIndex;

            comboBoxTransactionCategory_SelectedIndexChanged(null, null);

            int subIndex = comboBoxSubCategory.Items.IndexOf(transactionToEdit.Subcategory);
            if (subIndex >= 0)
                comboBoxSubCategory.SelectedIndex = subIndex;

            textBoxSum.Text = transactionToEdit.Amount.ToString();
            textBoxTransactionDescription.Text = transactionToEdit.Description;
            dateTimePickerTransaction.Value = transactionToEdit.Date;
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
            var subcategory = comboBoxSubCategory.Visible ? comboBoxSubCategory.SelectedItem?.ToString() ?? "" : "";
            var description = textBoxTransactionDescription.Text;
            var date = dateTimePickerTransaction.Value;

            Transaction transaction;

            if (type == "Дохід")
            {
                transaction = new Income
                {
                    Amount = amount,
                    Category = category,
                    Subcategory = subcategory,
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
                    Subcategory = subcategory,
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

        private void comboBoxTransictionType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedType = comboBoxTransictionType.SelectedItem?.ToString();

            comboBoxTransactionCategory.Items.Clear();
            comboBoxSubCategory.Items.Clear();

            if (selectedType == "Витрата")
            {
                comboBoxTransactionCategory.Items.AddRange(CategoryData.ExpenseCategories.Keys.ToArray());
                comboBoxTransactionCategory.Enabled = true;
                comboBoxSubCategory.Visible = true;
                labelSubCategory.Visible = true;
            }
            else if (selectedType == "Дохід")
            {
                comboBoxTransactionCategory.Items.AddRange(CategoryData.IncomeCategories.ToArray());
                comboBoxTransactionCategory.Enabled = true;
                comboBoxSubCategory.Visible = false;
                labelSubCategory.Visible = false;
            }

            if (comboBoxTransactionCategory.Items.Count > 0)
                comboBoxTransactionCategory.SelectedIndex = 0;
        }

        private void comboBoxTransactionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTransictionType.SelectedItem?.ToString() == "Витрата")
            {
                var selectedCategory = comboBoxTransactionCategory.SelectedItem?.ToString();
                comboBoxSubCategory.Items.Clear();

                if (!string.IsNullOrEmpty(selectedCategory) && CategoryData.ExpenseCategories.ContainsKey(selectedCategory))
                {
                    var subcategories = CategoryData.ExpenseCategories[selectedCategory];

                    if (subcategories.Count > 0)
                    {
                        comboBoxSubCategory.Enabled = true;
                        comboBoxSubCategory.Visible = true;
                        labelSubCategory.Visible = true;

                        comboBoxSubCategory.Items.AddRange(subcategories.ToArray());
                        comboBoxSubCategory.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxSubCategory.Enabled = false;
                        comboBoxSubCategory.Visible = false;
                        labelSubCategory.Visible = false;
                        comboBoxSubCategory.Text = string.Empty;
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}