namespace Kami
{
    partial class Usun_Osobe
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBDane = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDieta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Usuń Osobę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtUsunOsobe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dane Osoby \r\n  do Zmiany";
            // 
            // CBDane
            // 
            this.CBDane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDane.FormattingEnabled = true;
            this.CBDane.Location = new System.Drawing.Point(108, 20);
            this.CBDane.Name = "CBDane";
            this.CBDane.Size = new System.Drawing.Size(145, 21);
            this.CBDane.TabIndex = 2;
            this.CBDane.SelectedIndexChanged += new System.EventHandler(this.CBDane_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dieta Wybranej \r\n        Osoby";
            // 
            // TBDieta
            // 
            this.TBDieta.BackColor = System.Drawing.SystemColors.Window;
            this.TBDieta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TBDieta.Location = new System.Drawing.Point(108, 69);
            this.TBDieta.Name = "TBDieta";
            this.TBDieta.ReadOnly = true;
            this.TBDieta.Size = new System.Drawing.Size(145, 20);
            this.TBDieta.TabIndex = 4;
            // 
            // Usun_Osobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 140);
            this.Controls.Add(this.TBDieta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBDane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Usun_Osobe";
            this.Text = "UsunOsobe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBDane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDieta;
    }
}