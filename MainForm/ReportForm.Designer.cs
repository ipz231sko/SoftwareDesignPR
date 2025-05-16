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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveReportToFile = new System.Windows.Forms.Button();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labeltotalExpenses = new System.Windows.Forms.Label();
            this.labelNetBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загальний дохід";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(35, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Загальні витрати";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(35, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Чистий залишок";
            // 
            // buttonSaveReportToFile
            // 
            this.buttonSaveReportToFile.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveReportToFile.Location = new System.Drawing.Point(183, 307);
            this.buttonSaveReportToFile.Name = "buttonSaveReportToFile";
            this.buttonSaveReportToFile.Size = new System.Drawing.Size(136, 47);
            this.buttonSaveReportToFile.TabIndex = 3;
            this.buttonSaveReportToFile.Text = "Зберегти звіт у файлі";
            this.buttonSaveReportToFile.UseVisualStyleBackColor = true;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Location = new System.Drawing.Point(223, 76);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(44, 16);
            this.labelTotalIncome.TabIndex = 5;
            this.labelTotalIncome.Text = "label5";
            // 
            // labeltotalExpenses
            // 
            this.labeltotalExpenses.AutoSize = true;
            this.labeltotalExpenses.Location = new System.Drawing.Point(223, 139);
            this.labeltotalExpenses.Name = "labeltotalExpenses";
            this.labeltotalExpenses.Size = new System.Drawing.Size(44, 16);
            this.labeltotalExpenses.TabIndex = 6;
            this.labeltotalExpenses.Text = "label6";
            // 
            // labelNetBalance
            // 
            this.labelNetBalance.AutoSize = true;
            this.labelNetBalance.Location = new System.Drawing.Point(223, 213);
            this.labelNetBalance.Name = "labelNetBalance";
            this.labelNetBalance.Size = new System.Drawing.Size(44, 16);
            this.labelNetBalance.TabIndex = 7;
            this.labelNetBalance.Text = "label7";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 450);
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
    }
}