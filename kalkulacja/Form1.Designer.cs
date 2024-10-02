namespace Kalkulacja
{
    partial class Form1 : Form
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpFromCurrency = new System.Windows.Forms.GroupBox();
            this.rbtnFromTHB = new System.Windows.Forms.RadioButton();
            this.rbtnFromRUB = new System.Windows.Forms.RadioButton();
            this.rbtnFromEUR = new System.Windows.Forms.RadioButton();
            this.rbtnFromUSD = new System.Windows.Forms.RadioButton();
            this.rbtnFromPLN = new System.Windows.Forms.RadioButton();
            this.grpToCurrency = new System.Windows.Forms.GroupBox();
            this.rbtnToTHB = new System.Windows.Forms.RadioButton();
            this.rbtnToRUB = new System.Windows.Forms.RadioButton();
            this.rbtnToEUR = new System.Windows.Forms.RadioButton();
            this.rbtnToUSD = new System.Windows.Forms.RadioButton();
            this.rbtnToPLN = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpFromCurrency.SuspendLayout();
            this.grpToCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(12, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 20);
            this.txtAmount.TabIndex = 0;
            // 
            // grpFromCurrency
            // 
            this.grpFromCurrency.Controls.Add(this.rbtnFromTHB);
            this.grpFromCurrency.Controls.Add(this.rbtnFromRUB);
            this.grpFromCurrency.Controls.Add(this.rbtnFromEUR);
            this.grpFromCurrency.Controls.Add(this.rbtnFromUSD);
            this.grpFromCurrency.Controls.Add(this.rbtnFromPLN);
            this.grpFromCurrency.Location = new System.Drawing.Point(12, 50);
            this.grpFromCurrency.Name = "grpFromCurrency";
            this.grpFromCurrency.Size = new System.Drawing.Size(120, 140);
            this.grpFromCurrency.TabIndex = 1;
            this.grpFromCurrency.TabStop = false;
            this.grpFromCurrency.Text = "Waluta:";
            // 
            // rbtnFromTHB
            // 
            this.rbtnFromTHB.AutoSize = true;
            this.rbtnFromTHB.Location = new System.Drawing.Point(6, 111);
            this.rbtnFromTHB.Name = "rbtnFromTHB";
            this.rbtnFromTHB.Size = new System.Drawing.Size(89, 17);
            this.rbtnFromTHB.TabIndex = 4;
            this.rbtnFromTHB.TabStop = true;
            this.rbtnFromTHB.Text = "bat tajlandzki";
            this.rbtnFromTHB.UseVisualStyleBackColor = true;
            // 
            // rbtnFromRUB
            // 
            this.rbtnFromRUB.AutoSize = true;
            this.rbtnFromRUB.Location = new System.Drawing.Point(6, 88);
            this.rbtnFromRUB.Name = "rbtnFromRUB";
            this.rbtnFromRUB.Size = new System.Drawing.Size(47, 17);
            this.rbtnFromRUB.TabIndex = 3;
            this.rbtnFromRUB.TabStop = true;
            this.rbtnFromRUB.Text = "RUB";
            this.rbtnFromRUB.UseVisualStyleBackColor = true;
            // 
            // rbtnFromEUR
            // 
            this.rbtnFromEUR.AutoSize = true;
            this.rbtnFromEUR.Location = new System.Drawing.Point(6, 65);
            this.rbtnFromEUR.Name = "rbtnFromEUR";
            this.rbtnFromEUR.Size = new System.Drawing.Size(48, 17);
            this.rbtnFromEUR.TabIndex = 2;
            this.rbtnFromEUR.TabStop = true;
            this.rbtnFromEUR.Text = "EUR";
            this.rbtnFromEUR.UseVisualStyleBackColor = true;
            // 
            // rbtnFromUSD
            // 
            this.rbtnFromUSD.AutoSize = true;
            this.rbtnFromUSD.Location = new System.Drawing.Point(6, 42);
            this.rbtnFromUSD.Name = "rbtnFromUSD";
            this.rbtnFromUSD.Size = new System.Drawing.Size(48, 17);
            this.rbtnFromUSD.TabIndex = 1;
            this.rbtnFromUSD.TabStop = true;
            this.rbtnFromUSD.Text = "USD";
            this.rbtnFromUSD.UseVisualStyleBackColor = true;
            // 
            // rbtnFromPLN
            // 
            this.rbtnFromPLN.AutoSize = true;
            this.rbtnFromPLN.Location = new System.Drawing.Point(6, 19);
            this.rbtnFromPLN.Name = "rbtnFromPLN";
            this.rbtnFromPLN.Size = new System.Drawing.Size(45, 17);
            this.rbtnFromPLN.TabIndex = 0;
            this.rbtnFromPLN.TabStop = true;
            this.rbtnFromPLN.Text = "PLN";
            this.rbtnFromPLN.UseVisualStyleBackColor = true;
            // 
            // grpToCurrency
            // 
            this.grpToCurrency.Controls.Add(this.rbtnToTHB);
            this.grpToCurrency.Controls.Add(this.rbtnToRUB);
            this.grpToCurrency.Controls.Add(this.rbtnToEUR);
            this.grpToCurrency.Controls.Add(this.rbtnToUSD);
            this.grpToCurrency.Controls.Add(this.rbtnToPLN);
            this.grpToCurrency.Location = new System.Drawing.Point(152, 50);
            this.grpToCurrency.Name = "grpToCurrency";
            this.grpToCurrency.Size = new System.Drawing.Size(120, 140);
            this.grpToCurrency.TabIndex = 2;
            this.grpToCurrency.TabStop = false;
            this.grpToCurrency.Text = "Waluta docelowa:";
            // 
            // rbtnToTHB
            // 
            this.rbtnToTHB.AutoSize = true;
            this.rbtnToTHB.Location = new System.Drawing.Point(6, 111);
            this.rbtnToTHB.Name = "rbtnToTHB";
            this.rbtnToTHB.Size = new System.Drawing.Size(89, 17);
            this.rbtnToTHB.TabIndex = 4;
            this.rbtnToTHB.TabStop = true;
            this.rbtnToTHB.Text = "bat tajlandzki";
            this.rbtnToTHB.UseVisualStyleBackColor = true;
            // 
            // rbtnToRUB
            // 
            this.rbtnToRUB.AutoSize = true;
            this.rbtnToRUB.Location = new System.Drawing.Point(6, 88);
            this.rbtnToRUB.Name = "rbtnToRUB";
            this.rbtnToRUB.Size = new System.Drawing.Size(47, 17);
            this.rbtnToRUB.TabIndex = 3;
            this.rbtnToRUB.TabStop = true;
            this.rbtnToRUB.Text = "RUB";
            this.rbtnToRUB.UseVisualStyleBackColor = true;
            // 
            // rbtnToEUR
            // 
            this.rbtnToEUR.AutoSize = true;
            this.rbtnToEUR.Location = new System.Drawing.Point(6, 65);
            this.rbtnToEUR.Name = "rbtnToEUR";
            this.rbtnToEUR.Size = new System.Drawing.Size(48, 17);
            this.rbtnToEUR.TabIndex = 2;
            this.rbtnToEUR.TabStop = true;
            this.rbtnToEUR.Text = "EUR";
            this.rbtnToEUR.UseVisualStyleBackColor = true;
            // 
            // rbtnToUSD
            // 
            this.rbtnToUSD.AutoSize = true;
            this.rbtnToUSD.Location = new System.Drawing.Point(6, 42);
            this.rbtnToUSD.Name = "rbtnToUSD";
            this.rbtnToUSD.Size = new System.Drawing.Size(48, 17);
            this.rbtnToUSD.TabIndex = 1;
            this.rbtnToUSD.TabStop = true;
            this.rbtnToUSD.Text = "USD";
            this.rbtnToUSD.UseVisualStyleBackColor = true;
            // 
            // rbtnToPLN
            // 
            this.rbtnToPLN.AutoSize = true;
            this.rbtnToPLN.Location = new System.Drawing.Point(6, 19);
            this.rbtnToPLN.Name = "rbtnToPLN";
            this.rbtnToPLN.Size = new System.Drawing.Size(45, 17);
            this.rbtnToPLN.TabIndex = 0;
            this.rbtnToPLN.TabStop = true;
            this.rbtnToPLN.Text = "PLN";
            this.rbtnToPLN.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 210);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(260, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Przelicz";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 250);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Wynik";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpToCurrency);
            this.Controls.Add(this.grpFromCurrency);
            this.Controls.Add(this.txtAmount);
            this.Name = "Form1";
            this.Text = "Kalkulator Walutowy";
            this.grpFromCurrency.ResumeLayout(false);
            this.grpFromCurrency.PerformLayout();
            this.grpToCurrency.ResumeLayout(false);
            this.grpToCurrency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox grpFromCurrency;
        private System.Windows.Forms.RadioButton rbtnFromTHB;
        private System.Windows.Forms.RadioButton rbtnFromRUB;
        private System.Windows.Forms.RadioButton rbtnFromEUR;
        private System.Windows.Forms.RadioButton rbtnFromUSD;
        private System.Windows.Forms.RadioButton rbtnFromPLN;
        private System.Windows.Forms.GroupBox grpToCurrency;
        private System.Windows.Forms.RadioButton rbtnToTHB;
        private System.Windows.Forms.RadioButton rbtnToRUB;
        private System.Windows.Forms.RadioButton rbtnToEUR;
        private System.Windows.Forms.RadioButton rbtnToUSD;
        private System.Windows.Forms.RadioButton rbtnToPLN;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
    }
}
