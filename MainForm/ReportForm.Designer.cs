namespace MainForm
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveReportToFile = new System.Windows.Forms.Button();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labeltotalExpenses = new System.Windows.Forms.Label();
            this.labelNetBalance = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxAvg = new System.Windows.Forms.CheckBox();
            this.checkBoxLargest = new System.Windows.Forms.CheckBox();
            this.checkBoxByCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxByCategoryAndSub = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загальний дохід";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Загальні витрати";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Чистий залишок";
            // 
            // buttonSaveReportToFile
            // 
            this.buttonSaveReportToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveReportToFile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveReportToFile.Location = new System.Drawing.Point(620, 362);
            this.buttonSaveReportToFile.Name = "buttonSaveReportToFile";
            this.buttonSaveReportToFile.Size = new System.Drawing.Size(136, 47);
            this.buttonSaveReportToFile.TabIndex = 3;
            this.buttonSaveReportToFile.Text = "Зберегти звіт у файлі";
            this.buttonSaveReportToFile.UseVisualStyleBackColor = true;
            this.buttonSaveReportToFile.Click += new System.EventHandler(this.buttonSaveReportToFile_Click_1);
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalIncome.Location = new System.Drawing.Point(218, 332);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(51, 19);
            this.labelTotalIncome.TabIndex = 5;
            this.labelTotalIncome.Text = "label5";
            // 
            // labeltotalExpenses
            // 
            this.labeltotalExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltotalExpenses.AutoSize = true;
            this.labeltotalExpenses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalExpenses.Location = new System.Drawing.Point(218, 395);
            this.labeltotalExpenses.Name = "labeltotalExpenses";
            this.labeltotalExpenses.Size = new System.Drawing.Size(51, 19);
            this.labeltotalExpenses.TabIndex = 6;
            this.labeltotalExpenses.Text = "label6";
            // 
            // labelNetBalance
            // 
            this.labelNetBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNetBalance.AutoSize = true;
            this.labelNetBalance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetBalance.Location = new System.Drawing.Point(218, 456);
            this.labelNetBalance.Name = "labelNetBalance";
            this.labelNetBalance.Size = new System.Drawing.Size(51, 19);
            this.labelNetBalance.TabIndex = 7;
            this.labelNetBalance.Text = "label7";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.Location = new System.Drawing.Point(742, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxAvg
            // 
            this.checkBoxAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAvg.AutoSize = true;
            this.checkBoxAvg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAvg.Location = new System.Drawing.Point(330, 330);
            this.checkBoxAvg.Name = "checkBoxAvg";
            this.checkBoxAvg.Size = new System.Drawing.Size(191, 21);
            this.checkBoxAvg.TabIndex = 11;
            this.checkBoxAvg.Text = "Середній дохід/витрати";
            this.checkBoxAvg.UseVisualStyleBackColor = true;
            // 
            // checkBoxLargest
            // 
            this.checkBoxLargest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLargest.AutoSize = true;
            this.checkBoxLargest.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLargest.Location = new System.Drawing.Point(330, 376);
            this.checkBoxLargest.Name = "checkBoxLargest";
            this.checkBoxLargest.Size = new System.Drawing.Size(170, 21);
            this.checkBoxLargest.TabIndex = 12;
            this.checkBoxLargest.Text = "Найбільші транзакції";
            this.checkBoxLargest.UseVisualStyleBackColor = true;
            // 
            // checkBoxByCategory
            // 
            this.checkBoxByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxByCategory.AutoSize = true;
            this.checkBoxByCategory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxByCategory.Location = new System.Drawing.Point(330, 415);
            this.checkBoxByCategory.Name = "checkBoxByCategory";
            this.checkBoxByCategory.Size = new System.Drawing.Size(189, 21);
            this.checkBoxByCategory.TabIndex = 13;
            this.checkBoxByCategory.Text = "Витрати за категоріями";
            this.checkBoxByCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxByCategoryAndSub
            // 
            this.checkBoxByCategoryAndSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxByCategoryAndSub.AutoSize = true;
            this.checkBoxByCategoryAndSub.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxByCategoryAndSub.Location = new System.Drawing.Point(330, 453);
            this.checkBoxByCategoryAndSub.Name = "checkBoxByCategoryAndSub";
            this.checkBoxByCategoryAndSub.Size = new System.Drawing.Size(300, 21);
            this.checkBoxByCategoryAndSub.TabIndex = 14;
            this.checkBoxByCategoryAndSub.Text = "Витрати за категоріями і підкатегоріями";
            this.checkBoxByCategoryAndSub.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 48);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(269, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Звіт та статистика";
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(5, 62);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.RowHeadersWidth = 51;
            this.dataGridViewStatistics.RowTemplate.Height = 24;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(769, 250);
            this.dataGridViewStatistics.TabIndex = 16;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 486);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxByCategoryAndSub);
            this.Controls.Add(this.checkBoxByCategory);
            this.Controls.Add(this.checkBoxLargest);
            this.Controls.Add(this.checkBoxAvg);
            this.Controls.Add(this.labelNetBalance);
            this.Controls.Add(this.labeltotalExpenses);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.buttonSaveReportToFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveReportToFile;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labeltotalExpenses;
        private System.Windows.Forms.Label labelNetBalance;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.CheckBox checkBoxAvg;
        private System.Windows.Forms.CheckBox checkBoxLargest;
        private System.Windows.Forms.CheckBox checkBoxByCategory;
        private System.Windows.Forms.CheckBox checkBoxByCategoryAndSub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
    }
}