namespace Kami
{
    partial class ZawieszenieKteringu
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
            this.CbDane = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DPPoczatek = new System.Windows.Forms.DateTimePicker();
            this.DPKoniec = new System.Windows.Forms.DateTimePicker();
            this.BtZawieszenie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTOdwies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbDane
            // 
            this.CbDane.FormattingEnabled = true;
            this.CbDane.Location = new System.Drawing.Point(101, 28);
            this.CbDane.Name = "CbDane";
            this.CbDane.Size = new System.Drawing.Size(171, 21);
            this.CbDane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię Nazwisko";
            // 
            // DPPoczatek
            // 
            this.DPPoczatek.Location = new System.Drawing.Point(101, 75);
            this.DPPoczatek.Name = "DPPoczatek";
            this.DPPoczatek.Size = new System.Drawing.Size(171, 20);
            this.DPPoczatek.TabIndex = 2;
            // 
            // DPKoniec
            // 
            this.DPKoniec.Location = new System.Drawing.Point(101, 118);
            this.DPKoniec.Name = "DPKoniec";
            this.DPKoniec.Size = new System.Drawing.Size(171, 20);
            this.DPKoniec.TabIndex = 3;
            // 
            // BtZawieszenie
            // 
            this.BtZawieszenie.Location = new System.Drawing.Point(13, 174);
            this.BtZawieszenie.Name = "BtZawieszenie";
            this.BtZawieszenie.Size = new System.Drawing.Size(259, 23);
            this.BtZawieszenie.TabIndex = 4;
            this.BtZawieszenie.Text = "Zawieś!";
            this.BtZawieszenie.UseVisualStyleBackColor = true;
            this.BtZawieszenie.Click += new System.EventHandler(this.BtZawieszenie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "   Od Kiedy \r\nZawieszenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "  Do Kiedy \r\nZawieszenie ";
            // 
            // BTOdwies
            // 
            this.BTOdwies.Location = new System.Drawing.Point(13, 203);
            this.BTOdwies.Name = "BTOdwies";
            this.BTOdwies.Size = new System.Drawing.Size(259, 23);
            this.BTOdwies.TabIndex = 7;
            this.BTOdwies.Text = "Odwieś";
            this.BTOdwies.UseVisualStyleBackColor = true;
            this.BTOdwies.Click += new System.EventHandler(this.BTOdwies_Click);
            // 
            // ZawieszenieKteringu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.BTOdwies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtZawieszenie);
            this.Controls.Add(this.DPKoniec);
            this.Controls.Add(this.DPPoczatek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDane);
            this.Name = "ZawieszenieKteringu";
            this.Text = "Zawieszenie Kteringu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DPPoczatek;
        private System.Windows.Forms.DateTimePicker DPKoniec;
        private System.Windows.Forms.Button BtZawieszenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTOdwies;
    }
}