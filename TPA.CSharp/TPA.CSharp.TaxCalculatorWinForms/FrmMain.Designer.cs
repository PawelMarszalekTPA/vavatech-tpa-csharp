namespace TPA.CSharp.TaxCalculatorWinForms
{
    partial class FrmMain
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
            this.bShowCalculator = new System.Windows.Forms.Button();
            this.bShowExporter = new System.Windows.Forms.Button();
            this.bShowDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShowCalculator
            // 
            this.bShowCalculator.Location = new System.Drawing.Point(90, 53);
            this.bShowCalculator.Name = "bShowCalculator";
            this.bShowCalculator.Size = new System.Drawing.Size(138, 61);
            this.bShowCalculator.TabIndex = 0;
            this.bShowCalculator.Text = "Kalkulator";
            this.bShowCalculator.UseVisualStyleBackColor = true;
            this.bShowCalculator.Click += new System.EventHandler(this.bShowCalculator_Click);
            // 
            // bShowExporter
            // 
            this.bShowExporter.Location = new System.Drawing.Point(90, 133);
            this.bShowExporter.Name = "bShowExporter";
            this.bShowExporter.Size = new System.Drawing.Size(138, 61);
            this.bShowExporter.TabIndex = 1;
            this.bShowExporter.Text = "Exporter";
            this.bShowExporter.UseVisualStyleBackColor = true;
            this.bShowExporter.Click += new System.EventHandler(this.bShowExporter_Click);
            // 
            // bShowDialog
            // 
            this.bShowDialog.Location = new System.Drawing.Point(90, 214);
            this.bShowDialog.Name = "bShowDialog";
            this.bShowDialog.Size = new System.Drawing.Size(138, 61);
            this.bShowDialog.TabIndex = 2;
            this.bShowDialog.Text = "Dialog";
            this.bShowDialog.UseVisualStyleBackColor = true;
            this.bShowDialog.Click += new System.EventHandler(this.bShowDialog_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bShowDialog);
            this.Controls.Add(this.bShowExporter);
            this.Controls.Add(this.bShowCalculator);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShowCalculator;
        private System.Windows.Forms.Button bShowExporter;
        private System.Windows.Forms.Button bShowDialog;
    }
}