namespace Kami
{
    partial class BazaDanych
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWyklucz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKoniecAbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPietro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKodDomofonu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CWtorek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSroda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCzwartek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpiatek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSobota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNiedziela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKomentarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.CImie,
            this.CDieta,
            this.CKalorie,
            this.CWyklucz,
            this.CKoniecAbo,
            this.CAdres,
            this.CPietro,
            this.CKodDomofonu,
            this.Cpon,
            this.CWtorek,
            this.CSroda,
            this.CCzwartek,
            this.Cpiatek,
            this.CSobota,
            this.CNiedziela,
            this.CKomentarz});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // CId
            // 
            this.CId.HeaderText = "Id";
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            // 
            // CImie
            // 
            this.CImie.HeaderText = "Imie Nazwisko";
            this.CImie.Name = "CImie";
            this.CImie.ReadOnly = true;
            // 
            // CDieta
            // 
            this.CDieta.HeaderText = "Dieta";
            this.CDieta.Name = "CDieta";
            this.CDieta.ReadOnly = true;
            // 
            // CKalorie
            // 
            this.CKalorie.HeaderText = "Kalorie";
            this.CKalorie.Name = "CKalorie";
            this.CKalorie.ReadOnly = true;
            // 
            // CWyklucz
            // 
            this.CWyklucz.HeaderText = "Wykluczenia";
            this.CWyklucz.Name = "CWyklucz";
            this.CWyklucz.ReadOnly = true;
            // 
            // CKoniecAbo
            // 
            this.CKoniecAbo.HeaderText = "Koniec Abonamentu";
            this.CKoniecAbo.Name = "CKoniecAbo";
            this.CKoniecAbo.ReadOnly = true;
            // 
            // CAdres
            // 
            this.CAdres.HeaderText = "Adres";
            this.CAdres.Name = "CAdres";
            this.CAdres.ReadOnly = true;
            // 
            // CPietro
            // 
            this.CPietro.HeaderText = "Piętro";
            this.CPietro.Name = "CPietro";
            this.CPietro.ReadOnly = true;
            // 
            // CKodDomofonu
            // 
            this.CKodDomofonu.HeaderText = "Kod Domofonu";
            this.CKodDomofonu.Name = "CKodDomofonu";
            this.CKodDomofonu.ReadOnly = true;
            // 
            // Cpon
            // 
            this.Cpon.HeaderText = "Poniedziałek";
            this.Cpon.Name = "Cpon";
            this.Cpon.ReadOnly = true;
            // 
            // CWtorek
            // 
            this.CWtorek.HeaderText = "Wtorek";
            this.CWtorek.Name = "CWtorek";
            this.CWtorek.ReadOnly = true;
            // 
            // CSroda
            // 
            this.CSroda.HeaderText = "Sroda";
            this.CSroda.Name = "CSroda";
            this.CSroda.ReadOnly = true;
            // 
            // CCzwartek
            // 
            this.CCzwartek.HeaderText = "Czwartek";
            this.CCzwartek.Name = "CCzwartek";
            this.CCzwartek.ReadOnly = true;
            // 
            // Cpiatek
            // 
            this.Cpiatek.HeaderText = "Piątek";
            this.Cpiatek.Name = "Cpiatek";
            this.Cpiatek.ReadOnly = true;
            // 
            // CSobota
            // 
            this.CSobota.HeaderText = "Sobota";
            this.CSobota.Name = "CSobota";
            this.CSobota.ReadOnly = true;
            // 
            // CNiedziela
            // 
            this.CNiedziela.HeaderText = "Niedziela";
            this.CNiedziela.Name = "CNiedziela";
            this.CNiedziela.ReadOnly = true;
            // 
            // CKomentarz
            // 
            this.CKomentarz.HeaderText = "Komentarz";
            this.CKomentarz.Name = "CKomentarz";
            this.CKomentarz.ReadOnly = true;
            // 
            // BazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BazaDanych";
            this.Text = "BazaDanych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKalorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWyklucz;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKoniecAbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPietro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKodDomofonu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CWtorek;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSroda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCzwartek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpiatek;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSobota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNiedziela;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKomentarz;
    }
}