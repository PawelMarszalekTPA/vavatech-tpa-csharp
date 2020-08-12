namespace TPA.CSharp.TaxCalculatorWinForms
{
    partial class FrmTaxCalculator
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
            this.lAmountNetto = new System.Windows.Forms.Label();
            this.tNettoAmount = new System.Windows.Forms.TextBox();
            this.tVAT = new System.Windows.Forms.TextBox();
            this.lVAT = new System.Windows.Forms.Label();
            this.bCalculateBrutto = new System.Windows.Forms.Button();
            this.lAmountBrutto = new System.Windows.Forms.Label();
            this.tAmountBrutto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lAmountNetto
            // 
            this.lAmountNetto.AutoSize = true;
            this.lAmountNetto.Location = new System.Drawing.Point(134, 52);
            this.lAmountNetto.Name = "lAmountNetto";
            this.lAmountNetto.Size = new System.Drawing.Size(64, 13);
            this.lAmountNetto.TabIndex = 0;
            this.lAmountNetto.Text = "Kwota netto";
            // 
            // tNettoAmount
            // 
            this.tNettoAmount.Location = new System.Drawing.Point(137, 68);
            this.tNettoAmount.Name = "tNettoAmount";
            this.tNettoAmount.Size = new System.Drawing.Size(144, 20);
            this.tNettoAmount.TabIndex = 1;
            this.tNettoAmount.Text = "0";
            this.tNettoAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tVAT
            // 
            this.tVAT.Location = new System.Drawing.Point(137, 122);
            this.tVAT.Name = "tVAT";
            this.tVAT.Size = new System.Drawing.Size(144, 20);
            this.tVAT.TabIndex = 3;
            this.tVAT.Text = "23";
            this.tVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lVAT
            // 
            this.lVAT.AutoSize = true;
            this.lVAT.Location = new System.Drawing.Point(134, 106);
            this.lVAT.Name = "lVAT";
            this.lVAT.Size = new System.Drawing.Size(84, 13);
            this.lVAT.TabIndex = 2;
            this.lVAT.Text = "Stawka VAT [%]";
            // 
            // bCalculateBrutto
            // 
            this.bCalculateBrutto.Location = new System.Drawing.Point(137, 181);
            this.bCalculateBrutto.Name = "bCalculateBrutto";
            this.bCalculateBrutto.Size = new System.Drawing.Size(144, 50);
            this.bCalculateBrutto.TabIndex = 4;
            this.bCalculateBrutto.Text = "Oblicz brutto";
            this.bCalculateBrutto.UseVisualStyleBackColor = true;
            this.bCalculateBrutto.Click += new System.EventHandler(this.bCalculateBrutto_Click);
            // 
            // lAmountBrutto
            // 
            this.lAmountBrutto.AutoSize = true;
            this.lAmountBrutto.Location = new System.Drawing.Point(134, 269);
            this.lAmountBrutto.Name = "lAmountBrutto";
            this.lAmountBrutto.Size = new System.Drawing.Size(67, 13);
            this.lAmountBrutto.TabIndex = 5;
            this.lAmountBrutto.Text = "Kwota brutto";
            // 
            // tAmountBrutto
            // 
            this.tAmountBrutto.Location = new System.Drawing.Point(137, 286);
            this.tAmountBrutto.Name = "tAmountBrutto";
            this.tAmountBrutto.ReadOnly = true;
            this.tAmountBrutto.Size = new System.Drawing.Size(144, 20);
            this.tAmountBrutto.TabIndex = 6;
            this.tAmountBrutto.Text = "0";
            this.tAmountBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 386);
            this.Controls.Add(this.tAmountBrutto);
            this.Controls.Add(this.lAmountBrutto);
            this.Controls.Add(this.bCalculateBrutto);
            this.Controls.Add(this.tVAT);
            this.Controls.Add(this.lVAT);
            this.Controls.Add(this.tNettoAmount);
            this.Controls.Add(this.lAmountNetto);
            this.Name = "FrmTaxCalculator";
            this.Text = "Kalkulator podatkowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAmountNetto;
        private System.Windows.Forms.TextBox tNettoAmount;
        private System.Windows.Forms.TextBox tVAT;
        private System.Windows.Forms.Label lVAT;
        private System.Windows.Forms.Button bCalculateBrutto;
        private System.Windows.Forms.Label lAmountBrutto;
        private System.Windows.Forms.TextBox tAmountBrutto;
    }
}

