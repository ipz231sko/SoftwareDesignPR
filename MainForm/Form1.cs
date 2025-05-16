using MainForm.Data;
using MainForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private BudgetService _budgetService;
        public Form1()
        {
            InitializeComponent();
            listViewLastTransaction.View = View.Details;
            listViewLastTransaction.Columns.Add("Дата", 100);
            listViewLastTransaction.Columns.Add("Тип", 80);
            listViewLastTransaction.Columns.Add("Категорія", 150);
            listViewLastTransaction.Columns.Add("Сума", 80);
            listViewLastTransaction.Columns.Add("Опис", 200);
            _budgetService = new BudgetService(new FileTransactionRepository());
            UpdateBalance();
            LoadLastTransactions();
        }
        private void UpdateBalance()
        {
            labelCurrentBalance.Text = $"{_budgetService.GetBalance()} грн";
        }
        private void LoadLastTransactions()
        {
            listViewLastTransaction.Items.Clear();

            var last = _budgetService.Transactions
                .OrderByDescending(t => t.Date)
                .Take(5);

            foreach (var transaction in last)
            {
                var item = new ListViewItem(transaction.Date.ToShortDateString());
                item.SubItems.Add(transaction.Type);
                item.SubItems.Add(transaction.Category);
                item.SubItems.Add($"{transaction.Amount} грн");
                item.SubItems.Add(transaction.Description);
                listViewLastTransaction.Items.Add(item);
            }
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            var addForm = new AddTransactionForm(_budgetService);
            addForm.FormClosed += (s, args) =>
            {
                UpdateBalance();
                LoadLastTransactions();
            };
            addForm.Show();
        }

        private void buttonViewAllTransaction_Click(object sender, EventArgs e)
        {
            var listForm = new TransactionListForm(_budgetService);
            listForm.Show();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm(_budgetService);
            reportForm.Show();
        }
    }
}
