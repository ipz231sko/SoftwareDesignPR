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
            _reportService = new ReportService(_budgetService.GetTransactions().ToList());
            DisplayReport();
        }
        private void DisplayReport()
        {
            decimal income = _reportService.GetTotalIncome();
            decimal expenses = _reportService.GetTotalExpense();
            decimal balance = income - expenses;

            labelTotalIncome.Text = $"{income} грн";
            labeltotalExpenses.Text = $"{expenses} грн";
            labelNetBalance.Text = $"{balance} грн";
            DisplayStatisticsTable();
        }
        private void DisplayStatisticsTable()
        {
            dataGridViewStatistics.Rows.Clear();
            dataGridViewStatistics.Columns.Clear();

            dataGridViewStatistics.Columns.Add("Metric", "Показник");
            dataGridViewStatistics.Columns.Add("Value", "Значення");

            dataGridViewStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatistics.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewStatistics.Rows.Add("Кількість транзакцій", _reportService.GetTransactionCount());
            dataGridViewStatistics.Rows.Add("Кількість доходів", _reportService.GetIncomeTransactionCount());
            dataGridViewStatistics.Rows.Add("Кількість витрат", _reportService.GetExpenseTransactionCount());
            dataGridViewStatistics.Rows.Add("Середній дохід", $"{_reportService.GetAverageIncome():F2} грн");
            dataGridViewStatistics.Rows.Add("Середні витрати", $"{_reportService.GetAverageExpense():F2} грн");

            var largestIncome = _reportService.GetLargestIncome();
            if (largestIncome != null)
            {
                dataGridViewStatistics.Rows.Add("Найбільший дохід", $"{largestIncome.Amount} грн ({largestIncome.Category})");
            }

            var largestExpense = _reportService.GetLargestExpense();
            if (largestExpense != null)
            {
                dataGridViewStatistics.Rows.Add("Найбільша витрата", $"{largestExpense.Amount} грн ({largestExpense.Category})");
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

                if (checkBoxAvg.Checked)
                {
                    lines.Add($"Середній дохід: {_reportService.GetAverageIncome():F2} грн");
                    lines.Add($"Середні витрати: {_reportService.GetAverageExpense():F2} грн");
                }

                if (checkBoxLargest.Checked)
                {
                    var largestIncome = _reportService.GetLargestIncome();
                    var largestExpense = _reportService.GetLargestExpense();
                    if (largestIncome != null)
                        lines.Add($"Найбільший дохід: {largestIncome.Amount} грн ({largestIncome.Category})");
                    if (largestExpense != null)
                        lines.Add($"Найбільша витрата: {largestExpense.Amount} грн ({largestExpense.Category})");
                }

                if (checkBoxByCategory.Checked)
                {
                    lines.Add("Витрати за категоріями:");
                    foreach (var pair in _reportService.GetExpenseByCategory())
                    {
                        lines.Add($"{pair.Key}: {pair.Value} грн");
                    }
                }

                if (checkBoxByCategoryAndSub.Checked)
                {
                    lines.Add("Витрати за категоріями та підкатегоріями:");
                    foreach (var pair in _reportService.GetExpenseByCategoryAndSubcategory())
                    {
                        lines.Add($"{pair.Key.Category} - {pair.Key.Subcategory}: {pair.Value} грн");
                    }
                }

                File.WriteAllLines(saveDialog.FileName, lines);

                MessageBox.Show("Звіт успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
