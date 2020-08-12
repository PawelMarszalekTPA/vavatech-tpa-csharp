namespace TPA.CSharp.TaxCalculatorWinForms
{
    partial class FrmExporter
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
            this.dDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lDateFrom = new System.Windows.Forms.Label();
            this.lDateTo = new System.Windows.Forms.Label();
            this.dDateTo = new System.Windows.Forms.DateTimePicker();
            this.bSaveToCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dDateFrom
            // 
            this.dDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDateFrom.Location = new System.Drawing.Point(45, 70);
            this.dDateFrom.Name = "dDateFrom";
            this.dDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dDateFrom.TabIndex = 0;
            // 
            // lDateFrom
            // 
            this.lDateFrom.AutoSize = true;
            this.lDateFrom.Location = new System.Drawing.Point(46, 51);
            this.lDateFrom.Name = "lDateFrom";
            this.lDateFrom.Size = new System.Drawing.Size(48, 13);
            this.lDateFrom.TabIndex = 1;
            this.lDateFrom.Text = "Data od ";
            // 
            // lDateTo
            // 
            this.lDateTo.AutoSize = true;
            this.lDateTo.Location = new System.Drawing.Point(46, 127);
            this.lDateTo.Name = "lDateTo";
            this.lDateTo.Size = new System.Drawing.Size(45, 13);
            this.lDateTo.TabIndex = 3;
            this.lDateTo.Text = "Data do";
            // 
            // dDateTo
            // 
            this.dDateTo.CustomFormat = "yyyy-MM-dd";
            this.dDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDateTo.Location = new System.Drawing.Point(45, 146);
            this.dDateTo.Name = "dDateTo";
            this.dDateTo.Size = new System.Drawing.Size(200, 20);
            this.dDateTo.TabIndex = 2;
            // 
            // bSaveToCSV
            // 
            this.bSaveToCSV.Location = new System.Drawing.Point(45, 220);
            this.bSaveToCSV.Name = "bSaveToCSV";
            this.bSaveToCSV.Size = new System.Drawing.Size(200, 39);
            this.bSaveToCSV.TabIndex = 4;
            this.bSaveToCSV.Text = "Zapisz do CSV";
            this.bSaveToCSV.UseVisualStyleBackColor = true;
            this.bSaveToCSV.Click += new System.EventHandler(this.bSaveToCSV_Click);
            // 
            // FrmExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 309);
            this.Controls.Add(this.bSaveToCSV);
            this.Controls.Add(this.lDateTo);
            this.Controls.Add(this.dDateTo);
            this.Controls.Add(this.lDateFrom);
            this.Controls.Add(this.dDateFrom);
            this.Name = "FrmExporter";
            this.Text = "FrmExporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dDateFrom;
        private System.Windows.Forms.Label lDateFrom;
        private System.Windows.Forms.Label lDateTo;
        private System.Windows.Forms.DateTimePicker dDateTo;
        private System.Windows.Forms.Button bSaveToCSV;
    }
}