namespace MainForm
{
    partial class TransactionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionListForm));
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTransactionCategory = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonApplyFilter = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubcategoryFilter = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(9, 58);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.RowTemplate.Height = 24;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(775, 342);
            this.dataGridViewTransactions.TabIndex = 0;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Усі",
            "Дохід",
            "Витрата"});
            this.comboBoxFilter.Location = new System.Drawing.Point(957, 71);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(177, 24);
            this.comboBoxFilter.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(934, 245);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // comboBoxTransactionCategory
            // 
            this.comboBoxTransactionCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransactionCategory.FormattingEnabled = true;
            this.comboBoxTransactionCategory.Location = new System.Drawing.Point(965, 141);
            this.comboBoxTransactionCategory.Name = "comboBoxTransactionCategory";
            this.comboBoxTransactionCategory.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTransactionCategory.TabIndex = 4;
            this.comboBoxTransactionCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransactionCategory_SelectedIndexChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(934, 307);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // buttonApplyFilter
            // 
            this.buttonApplyFilter.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApplyFilter.Location = new System.Drawing.Point(790, 366);
            this.buttonApplyFilter.Name = "buttonApplyFilter";
            this.buttonApplyFilter.Size = new System.Drawing.Size(158, 44);
            this.buttonApplyFilter.TabIndex = 6;
            this.buttonApplyFilter.Text = "Застосувати фільтр";
            this.buttonApplyFilter.UseVisualStyleBackColor = true;
            this.buttonApplyFilter.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // buttonDeleteSelectedTransaction
            // 
            this.buttonDeleteSelectedTransaction.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteSelectedTransaction.Location = new System.Drawing.Point(957, 366);
            this.buttonDeleteSelectedTransaction.Name = "buttonDeleteSelectedTransaction";
            this.buttonDeleteSelectedTransaction.Size = new System.Drawing.Size(158, 44);
            this.buttonDeleteSelectedTransaction.TabIndex = 7;
            this.buttonDeleteSelectedTransaction.Text = "Видалити вибрану транзакцію";
            this.buttonDeleteSelectedTransaction.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedTransaction.Click += new System.EventHandler(this.buttonDeleteSelectedTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(818, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фільтр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(818, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Категорія";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(818, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Від:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(818, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "До:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(818, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Підкатегорія";
            // 
            // comboBoxSubcategoryFilter
            // 
            this.comboBoxSubcategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubcategoryFilter.FormattingEnabled = true;
            this.comboBoxSubcategoryFilter.Items.AddRange(new object[] {
            "Продукти та супермаркет",
            "Одяг та взуття",
            "Благодійність",
            "Подорожі",
            "Книги",
            "Краса та здоров\'я",
            "Поповнення мобільного",
            "Розваги та спорт"});
            this.comboBoxSubcategoryFilter.Location = new System.Drawing.Point(965, 196);
            this.comboBoxSubcategoryFilter.Name = "comboBoxSubcategoryFilter";
            this.comboBoxSubcategoryFilter.Size = new System.Drawing.Size(169, 24);
            this.comboBoxSubcategoryFilter.TabIndex = 12;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Location = new System.Drawing.Point(1124, -1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 435);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSubcategoryFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteSelectedTransaction);
            this.Controls.Add(this.buttonApplyFilter);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.comboBoxTransactionCategory);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.dataGridViewTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionListForm";
            this.Text = "TransactionListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.ComboBox comboBoxTransactionCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonApplyFilter;
        private System.Windows.Forms.Button buttonDeleteSelectedTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubcategoryFilter;
        private System.Windows.Forms.Button buttonClose;
    }
}