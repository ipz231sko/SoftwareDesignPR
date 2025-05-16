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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransactionForm));
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
            this.labelSubCategory = new System.Windows.Forms.Label();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(202, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати транзакцію";
            // 
            // comboBoxTransictionType
            // 
            this.comboBoxTransictionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransictionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransictionType.FormattingEnabled = true;
            this.comboBoxTransictionType.Items.AddRange(new object[] {
            "Дохід",
            "Витрата"});
            this.comboBoxTransictionType.Location = new System.Drawing.Point(203, 66);
            this.comboBoxTransictionType.Name = "comboBoxTransictionType";
            this.comboBoxTransictionType.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTransictionType.TabIndex = 2;
            this.comboBoxTransictionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransictionType_SelectedIndexChanged_1);
            // 
            // comboBoxTransactionCategory
            // 
            this.comboBoxTransactionCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTransactionCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTransactionCategory.FormattingEnabled = true;
            this.comboBoxTransactionCategory.Items.AddRange(new object[] {
            "Комунальні та абонплата"});
            this.comboBoxTransactionCategory.Location = new System.Drawing.Point(203, 247);
            this.comboBoxTransactionCategory.Name = "comboBoxTransactionCategory";
            this.comboBoxTransactionCategory.Size = new System.Drawing.Size(169, 24);
            this.comboBoxTransactionCategory.TabIndex = 3;
            this.comboBoxTransactionCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransactionCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип траназакції:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(25, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сума:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(25, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Категорія:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(25, 307);
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
            this.buttonTransactionSave.Location = new System.Drawing.Point(287, 378);
            this.buttonTransactionSave.Name = "buttonTransactionSave";
            this.buttonTransactionSave.Size = new System.Drawing.Size(183, 47);
            this.buttonTransactionSave.TabIndex = 9;
            this.buttonTransactionSave.Text = "Зберегти";
            this.buttonTransactionSave.UseVisualStyleBackColor = false;
            this.buttonTransactionSave.Click += new System.EventHandler(this.buttonTransactionSave_Click);
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(204, 127);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(167, 22);
            this.dateTimePickerTransaction.TabIndex = 10;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSum.Location = new System.Drawing.Point(204, 190);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(166, 22);
            this.textBoxSum.TabIndex = 11;
            // 
            // textBoxTransactionDescription
            // 
            this.textBoxTransactionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransactionDescription.Location = new System.Drawing.Point(204, 307);
            this.textBoxTransactionDescription.Name = "textBoxTransactionDescription";
            this.textBoxTransactionDescription.Size = new System.Drawing.Size(166, 22);
            this.textBoxTransactionDescription.TabIndex = 12;
            // 
            // labelSubCategory
            // 
            this.labelSubCategory.AutoSize = true;
            this.labelSubCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubCategory.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelSubCategory.Location = new System.Drawing.Point(385, 247);
            this.labelSubCategory.Name = "labelSubCategory";
            this.labelSubCategory.Size = new System.Drawing.Size(129, 23);
            this.labelSubCategory.TabIndex = 13;
            this.labelSubCategory.Text = "Підкатегорія:";
            this.labelSubCategory.Visible = false;
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(521, 247);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(169, 24);
            this.comboBoxSubCategory.TabIndex = 14;
            this.comboBoxSubCategory.Visible = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Location = new System.Drawing.Point(657, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.labelSubCategory);
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
        private System.Windows.Forms.Label labelSubCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Button buttonClose;
    }
}