using MainForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MainForm
{
    public partial class ReportForm : Form
    {
        private readonly BudgetService _budgetService;
        private ReportService _reportService;
        public ReportForm(BudgetService budgetService)
        {
            InitializeComponent();
            _budgetService = budgetService;
            _reportService = new ReportService(_budgetService.Transactions);
            DisplayReport();
        }
        private void DisplayReport()
        {
            decimal income = _reportService.GetTotalIncome();
            decimal expenses = _reportService.GetTotalExpense();
            decimal balance = income - expenses;

            labelTotalIncome.Text = $"Загальний дохід: {income} грн";
            labeltotalExpenses.Text = $"Загальні витрати: {expenses} грн";
            labelNetBalance.Text = $"Чистий залишок: {balance} грн";

            listBoxExpensesByCategory.Items.Clear();
            listBoxExpensesByCategory.Items.Add("Витрати за категоріями:");
            foreach (var pair in _reportService.GetExpenseByCategory())
            {
                listBoxExpensesByCategory.Items.Add($"{pair.Key}: {pair.Value} грн");
            }
        }

        private void buttonSaveReportToFile_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Текстові файли (*.txt)|*.txt";
            saveDialog.Title = "Зберегти звіт";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                decimal income = _reportService.GetTotalIncome();
                decimal expenses = _reportService.GetTotalExpense();
                decimal balance = income - expenses;

                var lines = new List<string>
                {
                    "Звіт про фінанси",
                    $"Дата: {DateTime.Now}",
                    $"Загальний дохід: {income} грн",
                    $"Загальні витрати: {expenses} грн",
                    $"Чистий залишок: {balance} грн"
                };

                File.WriteAllLines(saveDialog.FileName, lines);

                MessageBox.Show("Звіт успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
