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
            this.cAccount = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.sfdCSV = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.bSaveToCSV.Location = new System.Drawing.Point(45, 256);
            this.bSaveToCSV.Name = "bSaveToCSV";
            this.bSaveToCSV.Size = new System.Drawing.Size(200, 39);
            this.bSaveToCSV.TabIndex = 4;
            this.bSaveToCSV.Text = "Zapisz do CSV";
            this.bSaveToCSV.UseVisualStyleBackColor = true;
            this.bSaveToCSV.Click += new System.EventHandler(this.bSaveToCSV_Click);
            // 
            // cAccount
            // 
            this.cAccount.FormattingEnabled = true;
            this.cAccount.Location = new System.Drawing.Point(45, 205);
            this.cAccount.Name = "cAccount";
            this.cAccount.Size = new System.Drawing.Size(196, 21);
            this.cAccount.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Target});
            this.dataGridView1.Location = new System.Drawing.Point(45, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(328, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(328, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(328, 168);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(328, 206);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // FrmExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(530, 637);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cAccount);
            this.Controls.Add(this.bSaveToCSV);
            this.Controls.Add(this.lDateTo);
            this.Controls.Add(this.dDateTo);
            this.Controls.Add(this.lDateFrom);
            this.Controls.Add(this.dDateFrom);
            this.Name = "FrmExporter";
            this.Text = "FrmExporter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dDateFrom;
        private System.Windows.Forms.Label lDateFrom;
        private System.Windows.Forms.Label lDateTo;
        private System.Windows.Forms.DateTimePicker dDateTo;
        private System.Windows.Forms.Button bSaveToCSV;
        private System.Windows.Forms.ComboBox cAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.SaveFileDialog sfdCSV;
    }
}