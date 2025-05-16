namespace MainForm
{
    partial class AddTransactionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTransictionType = new System.Windows.Forms.ComboBox();
            this.comboBoxTransactionCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTransactionSave = new System.Windows.Forms.Button();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxTransactionDescription = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(151, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати транзакцію";
            // 
            // comboBoxTransictionType
            // 
            this.comboBoxTransictionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransictionType.FormattingEnabled = true;
            this.comboBoxTransictionType.Items.AddRange(new object[] {
            "Дохід",
            "Витрата"});
            this.comboBoxTransictionType.Location = new System.Drawing.Point(203, 92);
            this.comboBoxTransictionType.Name = "comboBoxTransictionType";
            this.comboBoxTransictionType.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTransictionType.TabIndex = 2;
            // 
            // comboBoxTransactionCategory
            // 
            this.comboBoxTransactionCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransactionCategory.FormattingEnabled = true;
            this.comboBoxTransactionCategory.Items.AddRange(new object[] {
            "Продукти та супермаркет",
            "Одяг та взуття",
            "Благодійність",
            "Подорожі",
            "Книги",
            "Краса та здоров\'я",
            "Поповнення мобільного",
            "Розваги та спорт"});
            this.comboBoxTransactionCategory.Location = new System.Drawing.Point(203, 273);
            this.comboBoxTransactionCategory.Name = "comboBoxTransactionCategory";
            this.comboBoxTransactionCategory.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTransactionCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип траназакції:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(25, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(25, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сума:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(25, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Категорія:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(25, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Опис:";
            // 
            // buttonTransactionSave
            // 
            this.buttonTransactionSave.BackColor = System.Drawing.Color.Snow;
            this.buttonTransactionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTransactionSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonTransactionSave.Location = new System.Drawing.Point(203, 391);
            this.buttonTransactionSave.Name = "buttonTransactionSave";
            this.buttonTransactionSave.Size = new System.Drawing.Size(183, 47);
            this.buttonTransactionSave.TabIndex = 9;
            this.buttonTransactionSave.Text = "Зберегти";
            this.buttonTransactionSave.UseVisualStyleBackColor = false;
            this.buttonTransactionSave.Click += new System.EventHandler(this.buttonTransactionSave_Click);
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(204, 153);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerTransaction.TabIndex = 10;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(204, 216);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(166, 22);
            this.textBoxSum.TabIndex = 11;
            // 
            // textBoxTransactionDescription
            // 
            this.textBoxTransactionDescription.Location = new System.Drawing.Point(204, 328);
            this.textBoxTransactionDescription.Name = "textBoxTransactionDescription";
            this.textBoxTransactionDescription.Size = new System.Drawing.Size(166, 22);
            this.textBoxTransactionDescription.TabIndex = 12;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.textBoxTransactionDescription);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.dateTimePickerTransaction);
            this.Controls.Add(this.buttonTransactionSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTransactionCategory);
            this.Controls.Add(this.comboBoxTransictionType);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTransictionType;
        private System.Windows.Forms.ComboBox comboBoxTransactionCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTransactionSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxTransactionDescription;
    }
}