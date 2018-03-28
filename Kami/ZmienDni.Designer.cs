namespace Kami
{
    partial class ZmienDni
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
            this.ChBPoniedzialek = new System.Windows.Forms.CheckBox();
            this.ChBWtorek = new System.Windows.Forms.CheckBox();
            this.ChBSroda = new System.Windows.Forms.CheckBox();
            this.ChBPiatek = new System.Windows.Forms.CheckBox();
            this.ChBSobota = new System.Windows.Forms.CheckBox();
            this.ChBNiedziela = new System.Windows.Forms.CheckBox();
            this.ChBCzwartek = new System.Windows.Forms.CheckBox();
            this.BTZaktualizuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbDane
            // 
            this.CbDane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDane.FormattingEnabled = true;
            this.CbDane.Location = new System.Drawing.Point(108, 16);
            this.CbDane.Name = "CbDane";
            this.CbDane.Size = new System.Drawing.Size(153, 21);
            this.CbDane.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Osoba do Zmiany";
            // 
            // ChBPoniedzialek
            // 
            this.ChBPoniedzialek.AutoSize = true;
            this.ChBPoniedzialek.Location = new System.Drawing.Point(15, 72);
            this.ChBPoniedzialek.Name = "ChBPoniedzialek";
            this.ChBPoniedzialek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChBPoniedzialek.Size = new System.Drawing.Size(88, 17);
            this.ChBPoniedzialek.TabIndex = 2;
            this.ChBPoniedzialek.Text = "Poniedziałek";
            this.ChBPoniedzialek.UseVisualStyleBackColor = true;
            // 
            // ChBWtorek
            // 
            this.ChBWtorek.AutoSize = true;
            this.ChBWtorek.Location = new System.Drawing.Point(15, 95);
            this.ChBWtorek.Name = "ChBWtorek";
            this.ChBWtorek.Size = new System.Drawing.Size(61, 17);
            this.ChBWtorek.TabIndex = 3;
            this.ChBWtorek.Text = "Wtorek";
            this.ChBWtorek.UseVisualStyleBackColor = true;
            // 
            // ChBSroda
            // 
            this.ChBSroda.AutoSize = true;
            this.ChBSroda.Location = new System.Drawing.Point(15, 118);
            this.ChBSroda.Name = "ChBSroda";
            this.ChBSroda.Size = new System.Drawing.Size(54, 17);
            this.ChBSroda.TabIndex = 4;
            this.ChBSroda.Text = "Środa";
            this.ChBSroda.UseVisualStyleBackColor = true;
            // 
            // ChBPiatek
            // 
            this.ChBPiatek.AutoSize = true;
            this.ChBPiatek.Location = new System.Drawing.Point(101, 95);
            this.ChBPiatek.Name = "ChBPiatek";
            this.ChBPiatek.Size = new System.Drawing.Size(56, 17);
            this.ChBPiatek.TabIndex = 5;
            this.ChBPiatek.Text = "Piątek";
            this.ChBPiatek.UseVisualStyleBackColor = true;
            // 
            // ChBSobota
            // 
            this.ChBSobota.AutoSize = true;
            this.ChBSobota.Location = new System.Drawing.Point(192, 72);
            this.ChBSobota.Name = "ChBSobota";
            this.ChBSobota.Size = new System.Drawing.Size(60, 17);
            this.ChBSobota.TabIndex = 6;
            this.ChBSobota.Text = "Sobota";
            this.ChBSobota.UseVisualStyleBackColor = true;
            // 
            // ChBNiedziela
            // 
            this.ChBNiedziela.AutoSize = true;
            this.ChBNiedziela.Location = new System.Drawing.Point(191, 95);
            this.ChBNiedziela.Name = "ChBNiedziela";
            this.ChBNiedziela.Size = new System.Drawing.Size(69, 17);
            this.ChBNiedziela.TabIndex = 7;
            this.ChBNiedziela.Text = "Niedziela";
            this.ChBNiedziela.UseVisualStyleBackColor = true;
            // 
            // ChBCzwartek
            // 
            this.ChBCzwartek.AutoSize = true;
            this.ChBCzwartek.Location = new System.Drawing.Point(101, 72);
            this.ChBCzwartek.Name = "ChBCzwartek";
            this.ChBCzwartek.Size = new System.Drawing.Size(70, 17);
            this.ChBCzwartek.TabIndex = 8;
            this.ChBCzwartek.Text = "Czwartek";
            this.ChBCzwartek.UseVisualStyleBackColor = true;
            // 
            // BTZaktualizuj
            // 
            this.BTZaktualizuj.Location = new System.Drawing.Point(12, 141);
            this.BTZaktualizuj.Name = "BTZaktualizuj";
            this.BTZaktualizuj.Size = new System.Drawing.Size(249, 23);
            this.BTZaktualizuj.TabIndex = 9;
            this.BTZaktualizuj.Text = "Aktualizuj";
            this.BTZaktualizuj.UseVisualStyleBackColor = true;
            this.BTZaktualizuj.Click += new System.EventHandler(this.BTZaktualizuj_Click);
            // 
            // ZmienDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 176);
            this.Controls.Add(this.BTZaktualizuj);
            this.Controls.Add(this.ChBCzwartek);
            this.Controls.Add(this.ChBNiedziela);
            this.Controls.Add(this.ChBSobota);
            this.Controls.Add(this.ChBPiatek);
            this.Controls.Add(this.ChBSroda);
            this.Controls.Add(this.ChBWtorek);
            this.Controls.Add(this.ChBPoniedzialek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDane);
            this.Name = "ZmienDni";
            this.Text = "Zmień Dni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbDane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChBPoniedzialek;
        private System.Windows.Forms.CheckBox ChBWtorek;
        private System.Windows.Forms.CheckBox ChBSroda;
        private System.Windows.Forms.CheckBox ChBPiatek;
        private System.Windows.Forms.CheckBox ChBSobota;
        private System.Windows.Forms.CheckBox ChBNiedziela;
        private System.Windows.Forms.CheckBox ChBCzwartek;
        private System.Windows.Forms.Button BTZaktualizuj;
    }
}