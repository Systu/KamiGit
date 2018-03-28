namespace Kami
{
    partial class DodajAbonament
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
            this.CBdane = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTZaktualizuj = new System.Windows.Forms.Button();
            this.DPKalendarz = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CBdane
            // 
            this.CBdane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBdane.FormattingEnabled = true;
            this.CBdane.Location = new System.Drawing.Point(115, 19);
            this.CBdane.Name = "CBdane";
            this.CBdane.Size = new System.Drawing.Size(157, 21);
            this.CBdane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz Osobe \r\n   do dodania \r\n  abonamentu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wybierz do kiedy \r\nnowy abonament";
            // 
            // BTZaktualizuj
            // 
            this.BTZaktualizuj.Location = new System.Drawing.Point(92, 113);
            this.BTZaktualizuj.Name = "BTZaktualizuj";
            this.BTZaktualizuj.Size = new System.Drawing.Size(88, 23);
            this.BTZaktualizuj.TabIndex = 5;
            this.BTZaktualizuj.Text = "Zaktualizuj";
            this.BTZaktualizuj.UseVisualStyleBackColor = true;
            this.BTZaktualizuj.Click += new System.EventHandler(this.BTZaktualizuj_Click);
            // 
            // DPKalendarz
            // 
            this.DPKalendarz.CustomFormat = "YYYY-MM-DD";
            this.DPKalendarz.Location = new System.Drawing.Point(115, 87);
            this.DPKalendarz.Name = "DPKalendarz";
            this.DPKalendarz.Size = new System.Drawing.Size(157, 20);
            this.DPKalendarz.TabIndex = 6;
            // 
            // DodajAbonament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.DPKalendarz);
            this.Controls.Add(this.BTZaktualizuj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBdane);
            this.Name = "DodajAbonament";
            this.Text = "Dodaj Abonament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBdane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTZaktualizuj;
        private System.Windows.Forms.DateTimePicker DPKalendarz;
    }
}