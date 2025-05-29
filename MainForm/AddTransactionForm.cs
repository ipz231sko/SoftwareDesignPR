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
using System.CodeDom;

namespace MainForm
{
    public partial class AddTransactionForm : Form
    {
        private const string INCOME_TYPE = "Дохід";
        private const string EXPENSE_TYPE = "Витрата";

        private readonly BudgetService _budgetService;
        private readonly Transaction _editingTransaction;
        private readonly bool _isEditMode;

        public AddTransactionForm(BudgetService budgetService)
        {
            InitializeComponent();
            _budgetService = budgetService;
            comboBoxTransactionType.SelectedIndexChanged += comboBoxTransictionType_SelectedIndexChanged_1;
            comboBoxTransactionCategory.SelectedIndexChanged += comboBoxTransactionCategory_SelectedIndexChanged;
        }

        public AddTransactionForm(BudgetService budgetService, Transaction transactionToEdit)
            : this(budgetService)
        {
            _editingTransaction = transactionToEdit;
            _isEditMode = true;
            this.Text = "Редагувати транзакцію";

            comboBoxTransactionType.SelectedItem = transactionToEdit.Type;
            comboBoxTransactionType.Enabled = false;

            comboBoxTransictionType_SelectedIndexChanged_1(null, null);

            InitializeEditMode(transactionToEdit);
        }

        private void InitializeEditMode(Transaction transactionToEdit)
        {
            SelectComboBoxItemIfExists(comboBoxTransactionCategory, transactionToEdit.Category);
            comboBoxTransactionCategory_SelectedIndexChanged(null, null);

            SelectComboBoxItemIfExists(comboBoxSubCategory, transactionToEdit.Subcategory);

            textBoxSum.Text = transactionToEdit.Amount.ToString();
            textBoxTransactionDescription.Text = transactionToEdit.Description;
            dateTimePickerTransaction.Value = transactionToEdit.Date;
        }

        private void SelectComboBoxItemIfExists(ComboBox comboBox, string item)
        {
            int index = comboBox.Items.IndexOf(item);
            if (index >= 0)
                comboBox.SelectedIndex = index;
        }

        private void buttonTransactionSave_Click(object sender, EventArgs e)
        {
            if (!TryGetValidAmount(out decimal amount))
            {
                MessageBox.Show("Введіть дійсну суму. Сума не може бути меншою чи рівною нулю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var type = comboBoxTransactionType.SelectedItem?.ToString();
            var category = comboBoxTransactionCategory.SelectedItem?.ToString() ?? "";
            var subcategory = comboBoxSubCategory.Visible ? comboBoxSubCategory.SelectedItem?.ToString() ?? "" : "";
            var description = textBoxTransactionDescription.Text;
            var date = dateTimePickerTransaction.Value;

            Transaction transaction = CreateTransaction(type, amount, category, subcategory, description, date);
            if (transaction == null)
            {
                MessageBox.Show("Невірний тип транзакції.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _budgetService.AddTransaction(transaction);

            MessageBox.Show("Транзакцію успішно додано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            ResetFormFields();
        }

        private void comboBoxTransictionType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedType = comboBoxTransactionType.SelectedItem?.ToString();
            UpdateCategoryAndSubcategoryControls(selectedType);
        }

        private void comboBoxTransactionCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTransactionType.SelectedItem?.ToString() != EXPENSE_TYPE)
                return;

            var selectedCategory = comboBoxTransactionCategory.SelectedItem?.ToString();
            comboBoxSubCategory.Items.Clear();

            if (string.IsNullOrEmpty(selectedCategory) || !CategoryData.ExpenseCategories.ContainsKey(selectedCategory))
                return;

            var subcategories = CategoryData.ExpenseCategories[selectedCategory];
            bool hasSubcategories = subcategories.Count > 0;
            SetSubCategoryVisibilitty(hasSubcategories);

            if (hasSubcategories)
            {
                comboBoxSubCategory.Items.AddRange(subcategories.ToArray());
                comboBoxSubCategory.SelectedIndex = 0;
            }
        }

        private void SetSubCategoryVisibilitty(bool isVisible)
        {
            comboBoxSubCategory.Enabled = isVisible;
            comboBoxSubCategory.Visible = isVisible;
            labelSubCategory.Visible = isVisible;

            if (!isVisible)
                comboBoxSubCategory.Text = string.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool TryGetValidAmount(out decimal amount)
        {
            return decimal.TryParse(textBoxSum.Text, out amount) && amount > 0;
        }

        private Transaction CreateTransaction(string type, decimal amount, string category, string subcategory, string description, DateTime date)
        {
            return TransactionFactory.CreateTransaction(type, amount, category, subcategory, description, date);
        }

        private void ResetFormFields()
        {
            textBoxSum.Clear();
            textBoxTransactionDescription.Clear();
            comboBoxTransactionType.SelectedIndex = 0;
            comboBoxTransactionCategory.SelectedIndex = 0;
            dateTimePickerTransaction.Value = DateTime.Today;
        }

        private void UpdateCategoryAndSubcategoryControls(string selectedType)
        {
            comboBoxTransactionCategory.Items.Clear();
            comboBoxSubCategory.Items.Clear();

            if (selectedType == EXPENSE_TYPE)
            {
                comboBoxTransactionCategory.Items.AddRange(CategoryData.ExpenseCategories.Keys.ToArray());
                comboBoxTransactionCategory.Enabled = true;
                comboBoxSubCategory.Visible = true;
                labelSubCategory.Visible = true;
            }
            else if (selectedType == INCOME_TYPE)
            {
                comboBoxTransactionCategory.Items.AddRange(CategoryData.IncomeCategories.ToArray());
                comboBoxTransactionCategory.Enabled = true;
                comboBoxSubCategory.Visible = false;
                labelSubCategory.Visible = false;
            }

            if (comboBoxTransactionCategory.Items.Count > 0)
                comboBoxTransactionCategory.SelectedIndex = 0;
        }
    }
}
