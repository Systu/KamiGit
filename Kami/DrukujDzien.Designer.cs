namespace Kami
{
    partial class DrukujDzien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrukujDzien));
            this.BTDrukujDlaKamili = new System.Windows.Forms.Button();
            this.Kalendarz = new System.Windows.Forms.DateTimePicker();
            this.BTWczytajDane = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // BTDrukujDlaKamili
            // 
            this.BTDrukujDlaKamili.Location = new System.Drawing.Point(12, 88);
            this.BTDrukujDlaKamili.Name = "BTDrukujDlaKamili";
            this.BTDrukujDlaKamili.Size = new System.Drawing.Size(200, 23);
            this.BTDrukujDlaKamili.TabIndex = 0;
            this.BTDrukujDlaKamili.Text = "Drukuj";
            this.BTDrukujDlaKamili.UseVisualStyleBackColor = true;
            this.BTDrukujDlaKamili.Click += new System.EventHandler(this.BTDrukujDlaKamili_Click);
            // 
            // Kalendarz
            // 
            this.Kalendarz.Location = new System.Drawing.Point(12, 12);
            this.Kalendarz.Name = "Kalendarz";
            this.Kalendarz.Size = new System.Drawing.Size(200, 20);
            this.Kalendarz.TabIndex = 2;
            // 
            // BTWczytajDane
            // 
            this.BTWczytajDane.Location = new System.Drawing.Point(12, 41);
            this.BTWczytajDane.Name = "BTWczytajDane";
            this.BTWczytajDane.Size = new System.Drawing.Size(200, 23);
            this.BTWczytajDane.TabIndex = 3;
            this.BTWczytajDane.Text = "Wczytaj dane dnia";
            this.BTWczytajDane.UseVisualStyleBackColor = true;
            this.BTWczytajDane.Click += new System.EventHandler(this.BTWczytajDane_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DrukujDzien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 134);
            this.Controls.Add(this.BTWczytajDane);
            this.Controls.Add(this.Kalendarz);
            this.Controls.Add(this.BTDrukujDlaKamili);
            this.MaximizeBox = false;
            this.Name = "DrukujDzien";
            this.Text = "DrukujDzien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTDrukujDlaKamili;
        private System.Windows.Forms.DateTimePicker Kalendarz;
        private System.Windows.Forms.Button BTWczytajDane;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}