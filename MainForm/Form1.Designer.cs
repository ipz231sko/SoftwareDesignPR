namespace MainForm
{
    partial class Form1
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
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonViewAllTransaction = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLastTransaction = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.buttonCreateReport);
            this.panel1.Controls.Add(this.buttonViewAllTransaction);
            this.panel1.Controls.Add(this.buttonAddTransaction);
            this.panel1.Controls.Add(this.labelCurrentBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 433);
            this.panel1.TabIndex = 0;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.Color.LightPink;
            this.buttonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateReport.Location = new System.Drawing.Point(63, 263);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(146, 50);
            this.buttonCreateReport.TabIndex = 4;
            this.buttonCreateReport.Text = "Створити звіт";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonViewAllTransaction
            // 
            this.buttonViewAllTransaction.BackColor = System.Drawing.Color.LightPink;
            this.buttonViewAllTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewAllTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewAllTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonViewAllTransaction.Location = new System.Drawing.Point(63, 165);
            this.buttonViewAllTransaction.Name = "buttonViewAllTransaction";
            this.buttonViewAllTransaction.Size = new System.Drawing.Size(146, 50);
            this.buttonViewAllTransaction.TabIndex = 3;
            this.buttonViewAllTransaction.Text = "Переглянути всі транзакції";
            this.buttonViewAllTransaction.UseVisualStyleBackColor = false;
            this.buttonViewAllTransaction.Click += new System.EventHandler(this.buttonViewAllTransaction_Click);
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.Color.LightPink;
            this.buttonAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTransaction.Location = new System.Drawing.Point(63, 69);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(146, 50);
            this.buttonAddTransaction.TabIndex = 2;
            this.buttonAddTransaction.Text = "Додати транзакцію";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCurrentBalance.Location = new System.Drawing.Point(158, 12);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(44, 16);
            this.labelCurrentBalance.TabIndex = 1;
            this.labelCurrentBalance.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Початковий баланс:";
            // 
            // listViewLastTransaction
            // 
            this.listViewLastTransaction.HideSelection = false;
            this.listViewLastTransaction.Location = new System.Drawing.Point(324, 4);
            this.listViewLastTransaction.Name = "listViewLastTransaction";
            this.listViewLastTransaction.Size = new System.Drawing.Size(450, 432);
            this.listViewLastTransaction.TabIndex = 1;
            this.listViewLastTransaction.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewLastTransaction);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonViewAllTransaction;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLastTransaction;
    }
}

