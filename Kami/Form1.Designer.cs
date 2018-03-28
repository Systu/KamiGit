namespace Kami
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtDodaj_Osobe = new System.Windows.Forms.Button();
            this.BtDodaj_Abonament = new System.Windows.Forms.Button();
            this.BtZmien_Osobe = new System.Windows.Forms.Button();
            this.BtDrukuj_Dzien = new System.Windows.Forms.Button();
            this.DataMenuPicker = new System.Windows.Forms.DateTimePicker();
            this.BtUsunOsobe = new System.Windows.Forms.Button();
            this.BtZmien_dni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LLiczbaKeto = new System.Windows.Forms.Label();
            this.LLiczbaSportowa = new System.Windows.Forms.Label();
            this.LLiczbaSpersonalizowany = new System.Windows.Forms.Label();
            this.LLiczbaPremium = new System.Windows.Forms.Label();
            this.LLiczbaStandard = new System.Windows.Forms.Label();
            this.LIloscOsobNaDzien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LStandardGluten = new System.Windows.Forms.Label();
            this.LSportowaGluten = new System.Windows.Forms.Label();
            this.LKetoGluten = new System.Windows.Forms.Label();
            this.LSpersonalizowanyGluten = new System.Windows.Forms.Label();
            this.LPremiumGluten = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LStandardLaktoza = new System.Windows.Forms.Label();
            this.LSportowaLaktoza = new System.Windows.Forms.Label();
            this.LKetoLaktoza = new System.Windows.Forms.Label();
            this.LSperosonalizowanaLaktoza = new System.Windows.Forms.Label();
            this.LPremiumLaktoza = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LStandardGL = new System.Windows.Forms.Label();
            this.LSportowaGL = new System.Windows.Forms.Label();
            this.LKetoGL = new System.Windows.Forms.Label();
            this.LSperosonalizowanaGL = new System.Windows.Forms.Label();
            this.LPremiumGL = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LStandardWege = new System.Windows.Forms.Label();
            this.LSportowaWege = new System.Windows.Forms.Label();
            this.LKetoWege = new System.Windows.Forms.Label();
            this.LSpersonalizowanyWege = new System.Windows.Forms.Label();
            this.LPremiumWege = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LPremiumWGL = new System.Windows.Forms.Label();
            this.LSpersonalizowanaWGL = new System.Windows.Forms.Label();
            this.LKetoWGL = new System.Windows.Forms.Label();
            this.LSportowaWGL = new System.Windows.Forms.Label();
            this.LStandardWGL = new System.Windows.Forms.Label();
            this.BtBazaDanych = new System.Windows.Forms.Button();
            this.BtZawieszenieKateringu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtDodaj_Osobe
            // 
            this.BtDodaj_Osobe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtDodaj_Osobe.Location = new System.Drawing.Point(12, 12);
            this.BtDodaj_Osobe.Name = "BtDodaj_Osobe";
            this.BtDodaj_Osobe.Size = new System.Drawing.Size(99, 35);
            this.BtDodaj_Osobe.TabIndex = 0;
            this.BtDodaj_Osobe.Text = "Dodaj Osobe";
            this.BtDodaj_Osobe.UseVisualStyleBackColor = true;
            this.BtDodaj_Osobe.Click += new System.EventHandler(this.Dodaj_Osobe_Click);
            // 
            // BtDodaj_Abonament
            // 
            this.BtDodaj_Abonament.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtDodaj_Abonament.Location = new System.Drawing.Point(117, 12);
            this.BtDodaj_Abonament.Name = "BtDodaj_Abonament";
            this.BtDodaj_Abonament.Size = new System.Drawing.Size(99, 35);
            this.BtDodaj_Abonament.TabIndex = 1;
            this.BtDodaj_Abonament.Text = "Dodaj Abonament";
            this.BtDodaj_Abonament.UseVisualStyleBackColor = true;
            this.BtDodaj_Abonament.Click += new System.EventHandler(this.Dodaj_Abonament_Click);
            // 
            // BtZmien_Osobe
            // 
            this.BtZmien_Osobe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtZmien_Osobe.Location = new System.Drawing.Point(222, 12);
            this.BtZmien_Osobe.Name = "BtZmien_Osobe";
            this.BtZmien_Osobe.Size = new System.Drawing.Size(99, 35);
            this.BtZmien_Osobe.TabIndex = 2;
            this.BtZmien_Osobe.Text = "Zmien Osobe";
            this.BtZmien_Osobe.UseVisualStyleBackColor = true;
            this.BtZmien_Osobe.Click += new System.EventHandler(this.Zmien_Osobe_Click);
            // 
            // BtDrukuj_Dzien
            // 
            this.BtDrukuj_Dzien.BackColor = System.Drawing.SystemColors.Control;
            this.BtDrukuj_Dzien.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtDrukuj_Dzien.Location = new System.Drawing.Point(327, 12);
            this.BtDrukuj_Dzien.Name = "BtDrukuj_Dzien";
            this.BtDrukuj_Dzien.Size = new System.Drawing.Size(99, 35);
            this.BtDrukuj_Dzien.TabIndex = 3;
            this.BtDrukuj_Dzien.Text = "Drukuj Dzien";
            this.BtDrukuj_Dzien.UseVisualStyleBackColor = false;
            this.BtDrukuj_Dzien.Click += new System.EventHandler(this.BtDrukuj_Dzien_Click);
            // 
            // DataMenuPicker
            // 
            this.DataMenuPicker.CustomFormat = "YYYY-MM-DD";
            this.DataMenuPicker.Location = new System.Drawing.Point(12, 53);
            this.DataMenuPicker.Name = "DataMenuPicker";
            this.DataMenuPicker.Size = new System.Drawing.Size(200, 20);
            this.DataMenuPicker.TabIndex = 6;
            this.DataMenuPicker.Value = new System.DateTime(2017, 5, 11, 0, 0, 0, 0);
            this.DataMenuPicker.ValueChanged += new System.EventHandler(this.DataMenuPicker_ValueChanged);
            // 
            // BtUsunOsobe
            // 
            this.BtUsunOsobe.Location = new System.Drawing.Point(222, 53);
            this.BtUsunOsobe.Name = "BtUsunOsobe";
            this.BtUsunOsobe.Size = new System.Drawing.Size(99, 20);
            this.BtUsunOsobe.TabIndex = 7;
            this.BtUsunOsobe.Text = "UsunOsobe";
            this.BtUsunOsobe.UseVisualStyleBackColor = true;
            this.BtUsunOsobe.Click += new System.EventHandler(this.BtUsunOsobe_Click);
            // 
            // BtZmien_dni
            // 
            this.BtZmien_dni.Location = new System.Drawing.Point(327, 53);
            this.BtZmien_dni.Name = "BtZmien_dni";
            this.BtZmien_dni.Size = new System.Drawing.Size(99, 20);
            this.BtZmien_dni.TabIndex = 8;
            this.BtZmien_dni.Text = "Zmien Dni";
            this.BtZmien_dni.UseVisualStyleBackColor = true;
            this.BtZmien_dni.Click += new System.EventHandler(this.BtZmien_dni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dziś masz ugotować dla :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Standard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sportowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dieta Keto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Spersonalizowana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Premium";
            // 
            // LLiczbaKeto
            // 
            this.LLiczbaKeto.AutoSize = true;
            this.LLiczbaKeto.Location = new System.Drawing.Point(136, 157);
            this.LLiczbaKeto.Name = "LLiczbaKeto";
            this.LLiczbaKeto.Size = new System.Drawing.Size(35, 13);
            this.LLiczbaKeto.TabIndex = 15;
            this.LLiczbaKeto.Text = "label7";
            // 
            // LLiczbaSportowa
            // 
            this.LLiczbaSportowa.AutoSize = true;
            this.LLiczbaSportowa.Location = new System.Drawing.Point(136, 131);
            this.LLiczbaSportowa.Name = "LLiczbaSportowa";
            this.LLiczbaSportowa.Size = new System.Drawing.Size(35, 13);
            this.LLiczbaSportowa.TabIndex = 16;
            this.LLiczbaSportowa.Text = "label8";
            // 
            // LLiczbaSpersonalizowany
            // 
            this.LLiczbaSpersonalizowany.AutoSize = true;
            this.LLiczbaSpersonalizowany.Location = new System.Drawing.Point(136, 180);
            this.LLiczbaSpersonalizowany.Name = "LLiczbaSpersonalizowany";
            this.LLiczbaSpersonalizowany.Size = new System.Drawing.Size(35, 13);
            this.LLiczbaSpersonalizowany.TabIndex = 17;
            this.LLiczbaSpersonalizowany.Text = "label9";
            // 
            // LLiczbaPremium
            // 
            this.LLiczbaPremium.AutoSize = true;
            this.LLiczbaPremium.Location = new System.Drawing.Point(136, 200);
            this.LLiczbaPremium.Name = "LLiczbaPremium";
            this.LLiczbaPremium.Size = new System.Drawing.Size(41, 13);
            this.LLiczbaPremium.TabIndex = 18;
            this.LLiczbaPremium.Text = "label10";
            // 
            // LLiczbaStandard
            // 
            this.LLiczbaStandard.AutoSize = true;
            this.LLiczbaStandard.Location = new System.Drawing.Point(136, 107);
            this.LLiczbaStandard.Name = "LLiczbaStandard";
            this.LLiczbaStandard.Size = new System.Drawing.Size(41, 13);
            this.LLiczbaStandard.TabIndex = 19;
            this.LLiczbaStandard.Text = "label11";
            // 
            // LIloscOsobNaDzien
            // 
            this.LIloscOsobNaDzien.AutoSize = true;
            this.LIloscOsobNaDzien.Location = new System.Drawing.Point(136, 85);
            this.LIloscOsobNaDzien.Name = "LIloscOsobNaDzien";
            this.LIloscOsobNaDzien.Size = new System.Drawing.Size(41, 13);
            this.LIloscOsobNaDzien.TabIndex = 20;
            this.LIloscOsobNaDzien.Text = "label12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "G:";
            // 
            // LStandardGluten
            // 
            this.LStandardGluten.AutoSize = true;
            this.LStandardGluten.Location = new System.Drawing.Point(198, 106);
            this.LStandardGluten.Name = "LStandardGluten";
            this.LStandardGluten.Size = new System.Drawing.Size(21, 13);
            this.LStandardGluten.TabIndex = 26;
            this.LStandardGluten.Text = "lab";
            // 
            // LSportowaGluten
            // 
            this.LSportowaGluten.AutoSize = true;
            this.LSportowaGluten.Location = new System.Drawing.Point(198, 130);
            this.LSportowaGluten.Name = "LSportowaGluten";
            this.LSportowaGluten.Size = new System.Drawing.Size(21, 13);
            this.LSportowaGluten.TabIndex = 27;
            this.LSportowaGluten.Text = "lab";
            // 
            // LKetoGluten
            // 
            this.LKetoGluten.AutoSize = true;
            this.LKetoGluten.Location = new System.Drawing.Point(198, 156);
            this.LKetoGluten.Name = "LKetoGluten";
            this.LKetoGluten.Size = new System.Drawing.Size(21, 13);
            this.LKetoGluten.TabIndex = 28;
            this.LKetoGluten.Text = "lab";
            // 
            // LSpersonalizowanyGluten
            // 
            this.LSpersonalizowanyGluten.AutoSize = true;
            this.LSpersonalizowanyGluten.Location = new System.Drawing.Point(198, 179);
            this.LSpersonalizowanyGluten.Name = "LSpersonalizowanyGluten";
            this.LSpersonalizowanyGluten.Size = new System.Drawing.Size(21, 13);
            this.LSpersonalizowanyGluten.TabIndex = 29;
            this.LSpersonalizowanyGluten.Text = "lab";
            // 
            // LPremiumGluten
            // 
            this.LPremiumGluten.AutoSize = true;
            this.LPremiumGluten.Location = new System.Drawing.Point(198, 199);
            this.LPremiumGluten.Name = "LPremiumGluten";
            this.LPremiumGluten.Size = new System.Drawing.Size(21, 13);
            this.LPremiumGluten.TabIndex = 30;
            this.LPremiumGluten.Text = "lab";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "L:";
            // 
            // LStandardLaktoza
            // 
            this.LStandardLaktoza.AutoSize = true;
            this.LStandardLaktoza.Location = new System.Drawing.Point(244, 106);
            this.LStandardLaktoza.Name = "LStandardLaktoza";
            this.LStandardLaktoza.Size = new System.Drawing.Size(21, 13);
            this.LStandardLaktoza.TabIndex = 36;
            this.LStandardLaktoza.Text = "lab";
            // 
            // LSportowaLaktoza
            // 
            this.LSportowaLaktoza.AutoSize = true;
            this.LSportowaLaktoza.Location = new System.Drawing.Point(244, 130);
            this.LSportowaLaktoza.Name = "LSportowaLaktoza";
            this.LSportowaLaktoza.Size = new System.Drawing.Size(21, 13);
            this.LSportowaLaktoza.TabIndex = 37;
            this.LSportowaLaktoza.Text = "lab";
            // 
            // LKetoLaktoza
            // 
            this.LKetoLaktoza.AutoSize = true;
            this.LKetoLaktoza.Location = new System.Drawing.Point(244, 156);
            this.LKetoLaktoza.Name = "LKetoLaktoza";
            this.LKetoLaktoza.Size = new System.Drawing.Size(21, 13);
            this.LKetoLaktoza.TabIndex = 38;
            this.LKetoLaktoza.Text = "lab";
            // 
            // LSperosonalizowanaLaktoza
            // 
            this.LSperosonalizowanaLaktoza.AutoSize = true;
            this.LSperosonalizowanaLaktoza.Location = new System.Drawing.Point(244, 179);
            this.LSperosonalizowanaLaktoza.Name = "LSperosonalizowanaLaktoza";
            this.LSperosonalizowanaLaktoza.Size = new System.Drawing.Size(21, 13);
            this.LSperosonalizowanaLaktoza.TabIndex = 39;
            this.LSperosonalizowanaLaktoza.Text = "lab";
            // 
            // LPremiumLaktoza
            // 
            this.LPremiumLaktoza.AutoSize = true;
            this.LPremiumLaktoza.Location = new System.Drawing.Point(244, 199);
            this.LPremiumLaktoza.Name = "LPremiumLaktoza";
            this.LPremiumLaktoza.Size = new System.Drawing.Size(21, 13);
            this.LPremiumLaktoza.TabIndex = 40;
            this.LPremiumLaktoza.Text = "lab";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "G/L:";
            // 
            // LStandardGL
            // 
            this.LStandardGL.AutoSize = true;
            this.LStandardGL.Location = new System.Drawing.Point(292, 107);
            this.LStandardGL.Name = "LStandardGL";
            this.LStandardGL.Size = new System.Drawing.Size(21, 13);
            this.LStandardGL.TabIndex = 46;
            this.LStandardGL.Text = "lab";
            // 
            // LSportowaGL
            // 
            this.LSportowaGL.AutoSize = true;
            this.LSportowaGL.Location = new System.Drawing.Point(292, 132);
            this.LSportowaGL.Name = "LSportowaGL";
            this.LSportowaGL.Size = new System.Drawing.Size(21, 13);
            this.LSportowaGL.TabIndex = 47;
            this.LSportowaGL.Text = "lab";
            // 
            // LKetoGL
            // 
            this.LKetoGL.AutoSize = true;
            this.LKetoGL.Location = new System.Drawing.Point(292, 158);
            this.LKetoGL.Name = "LKetoGL";
            this.LKetoGL.Size = new System.Drawing.Size(21, 13);
            this.LKetoGL.TabIndex = 48;
            this.LKetoGL.Text = "lab";
            // 
            // LSperosonalizowanaGL
            // 
            this.LSperosonalizowanaGL.AutoSize = true;
            this.LSperosonalizowanaGL.Location = new System.Drawing.Point(292, 181);
            this.LSperosonalizowanaGL.Name = "LSperosonalizowanaGL";
            this.LSperosonalizowanaGL.Size = new System.Drawing.Size(21, 13);
            this.LSperosonalizowanaGL.TabIndex = 49;
            this.LSperosonalizowanaGL.Text = "lab";
            // 
            // LPremiumGL
            // 
            this.LPremiumGL.AutoSize = true;
            this.LPremiumGL.Location = new System.Drawing.Point(292, 200);
            this.LPremiumGL.Name = "LPremiumGL";
            this.LPremiumGL.Size = new System.Drawing.Size(21, 13);
            this.LPremiumGL.TabIndex = 50;
            this.LPremiumGL.Text = "lab";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(341, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Wege:";
            // 
            // LStandardWege
            // 
            this.LStandardWege.AutoSize = true;
            this.LStandardWege.Location = new System.Drawing.Point(341, 107);
            this.LStandardWege.Name = "LStandardWege";
            this.LStandardWege.Size = new System.Drawing.Size(21, 13);
            this.LStandardWege.TabIndex = 56;
            this.LStandardWege.Text = "lab";
            // 
            // LSportowaWege
            // 
            this.LSportowaWege.AutoSize = true;
            this.LSportowaWege.Location = new System.Drawing.Point(341, 131);
            this.LSportowaWege.Name = "LSportowaWege";
            this.LSportowaWege.Size = new System.Drawing.Size(21, 13);
            this.LSportowaWege.TabIndex = 57;
            this.LSportowaWege.Text = "lab";
            // 
            // LKetoWege
            // 
            this.LKetoWege.AutoSize = true;
            this.LKetoWege.Location = new System.Drawing.Point(341, 157);
            this.LKetoWege.Name = "LKetoWege";
            this.LKetoWege.Size = new System.Drawing.Size(21, 13);
            this.LKetoWege.TabIndex = 58;
            this.LKetoWege.Text = "lab";
            // 
            // LSpersonalizowanyWege
            // 
            this.LSpersonalizowanyWege.AutoSize = true;
            this.LSpersonalizowanyWege.Location = new System.Drawing.Point(341, 180);
            this.LSpersonalizowanyWege.Name = "LSpersonalizowanyWege";
            this.LSpersonalizowanyWege.Size = new System.Drawing.Size(21, 13);
            this.LSpersonalizowanyWege.TabIndex = 59;
            this.LSpersonalizowanyWege.Text = "lab";
            // 
            // LPremiumWege
            // 
            this.LPremiumWege.AutoSize = true;
            this.LPremiumWege.Location = new System.Drawing.Point(341, 200);
            this.LPremiumWege.Name = "LPremiumWege";
            this.LPremiumWege.Size = new System.Drawing.Size(21, 13);
            this.LPremiumWege.TabIndex = 60;
            this.LPremiumWege.Text = "lab";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "W/G/L:";
            // 
            // LPremiumWGL
            // 
            this.LPremiumWGL.AutoSize = true;
            this.LPremiumWGL.Location = new System.Drawing.Point(386, 201);
            this.LPremiumWGL.Name = "LPremiumWGL";
            this.LPremiumWGL.Size = new System.Drawing.Size(21, 13);
            this.LPremiumWGL.TabIndex = 66;
            this.LPremiumWGL.Text = "lab";
            // 
            // LSpersonalizowanaWGL
            // 
            this.LSpersonalizowanaWGL.AutoSize = true;
            this.LSpersonalizowanaWGL.Location = new System.Drawing.Point(386, 181);
            this.LSpersonalizowanaWGL.Name = "LSpersonalizowanaWGL";
            this.LSpersonalizowanaWGL.Size = new System.Drawing.Size(21, 13);
            this.LSpersonalizowanaWGL.TabIndex = 65;
            this.LSpersonalizowanaWGL.Text = "lab";
            // 
            // LKetoWGL
            // 
            this.LKetoWGL.AutoSize = true;
            this.LKetoWGL.Location = new System.Drawing.Point(386, 158);
            this.LKetoWGL.Name = "LKetoWGL";
            this.LKetoWGL.Size = new System.Drawing.Size(21, 13);
            this.LKetoWGL.TabIndex = 64;
            this.LKetoWGL.Text = "lab";
            // 
            // LSportowaWGL
            // 
            this.LSportowaWGL.AutoSize = true;
            this.LSportowaWGL.Location = new System.Drawing.Point(386, 132);
            this.LSportowaWGL.Name = "LSportowaWGL";
            this.LSportowaWGL.Size = new System.Drawing.Size(21, 13);
            this.LSportowaWGL.TabIndex = 63;
            this.LSportowaWGL.Text = "lab";
            // 
            // LStandardWGL
            // 
            this.LStandardWGL.AutoSize = true;
            this.LStandardWGL.Location = new System.Drawing.Point(386, 108);
            this.LStandardWGL.Name = "LStandardWGL";
            this.LStandardWGL.Size = new System.Drawing.Size(21, 13);
            this.LStandardWGL.TabIndex = 62;
            this.LStandardWGL.Text = "lab";
            // 
            // BtBazaDanych
            // 
            this.BtBazaDanych.Location = new System.Drawing.Point(12, 217);
            this.BtBazaDanych.Name = "BtBazaDanych";
            this.BtBazaDanych.Size = new System.Drawing.Size(414, 23);
            this.BtBazaDanych.TabIndex = 67;
            this.BtBazaDanych.Text = "Bazadanych";
            this.BtBazaDanych.UseVisualStyleBackColor = true;
            this.BtBazaDanych.Click += new System.EventHandler(this.BtBazaDanych_Click);
            // 
            // BtZawieszenieKateringu
            // 
            this.BtZawieszenieKateringu.Location = new System.Drawing.Point(12, 246);
            this.BtZawieszenieKateringu.Name = "BtZawieszenieKateringu";
            this.BtZawieszenieKateringu.Size = new System.Drawing.Size(414, 23);
            this.BtZawieszenieKateringu.TabIndex = 68;
            this.BtZawieszenieKateringu.Text = "ZawieszenieKateringu";
            this.BtZawieszenieKateringu.UseVisualStyleBackColor = true;
            this.BtZawieszenieKateringu.Click += new System.EventHandler(this.BtZawieszenieKateringu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.BtZawieszenieKateringu);
            this.Controls.Add(this.BtBazaDanych);
            this.Controls.Add(this.LPremiumWGL);
            this.Controls.Add(this.LSpersonalizowanaWGL);
            this.Controls.Add(this.LKetoWGL);
            this.Controls.Add(this.LSportowaWGL);
            this.Controls.Add(this.LStandardWGL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LPremiumWege);
            this.Controls.Add(this.LSpersonalizowanyWege);
            this.Controls.Add(this.LKetoWege);
            this.Controls.Add(this.LSportowaWege);
            this.Controls.Add(this.LStandardWege);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.LPremiumGL);
            this.Controls.Add(this.LSperosonalizowanaGL);
            this.Controls.Add(this.LKetoGL);
            this.Controls.Add(this.LSportowaGL);
            this.Controls.Add(this.LStandardGL);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LPremiumLaktoza);
            this.Controls.Add(this.LSperosonalizowanaLaktoza);
            this.Controls.Add(this.LKetoLaktoza);
            this.Controls.Add(this.LSportowaLaktoza);
            this.Controls.Add(this.LStandardLaktoza);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LPremiumGluten);
            this.Controls.Add(this.LSpersonalizowanyGluten);
            this.Controls.Add(this.LKetoGluten);
            this.Controls.Add(this.LSportowaGluten);
            this.Controls.Add(this.LStandardGluten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LIloscOsobNaDzien);
            this.Controls.Add(this.LLiczbaStandard);
            this.Controls.Add(this.LLiczbaPremium);
            this.Controls.Add(this.LLiczbaSpersonalizowany);
            this.Controls.Add(this.LLiczbaSportowa);
            this.Controls.Add(this.LLiczbaKeto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtZmien_dni);
            this.Controls.Add(this.BtUsunOsobe);
            this.Controls.Add(this.DataMenuPicker);
            this.Controls.Add(this.BtDrukuj_Dzien);
            this.Controls.Add(this.BtZmien_Osobe);
            this.Controls.Add(this.BtDodaj_Abonament);
            this.Controls.Add(this.BtDodaj_Osobe);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ile dziś Gotuje ? ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtDodaj_Osobe;
        private System.Windows.Forms.Button BtDodaj_Abonament;
        private System.Windows.Forms.Button BtZmien_Osobe;
        private System.Windows.Forms.Button BtDrukuj_Dzien;
        private System.Windows.Forms.DateTimePicker DataMenuPicker;
        private System.Windows.Forms.Button BtUsunOsobe;
        private System.Windows.Forms.Button BtZmien_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LLiczbaKeto;
        private System.Windows.Forms.Label LLiczbaSportowa;
        private System.Windows.Forms.Label LLiczbaSpersonalizowany;
        private System.Windows.Forms.Label LLiczbaPremium;
        private System.Windows.Forms.Label LLiczbaStandard;
        private System.Windows.Forms.Label LIloscOsobNaDzien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LStandardGluten;
        private System.Windows.Forms.Label LSportowaGluten;
        private System.Windows.Forms.Label LKetoGluten;
        private System.Windows.Forms.Label LSpersonalizowanyGluten;
        private System.Windows.Forms.Label LPremiumGluten;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LStandardLaktoza;
        private System.Windows.Forms.Label LSportowaLaktoza;
        private System.Windows.Forms.Label LKetoLaktoza;
        private System.Windows.Forms.Label LSperosonalizowanaLaktoza;
        private System.Windows.Forms.Label LPremiumLaktoza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LStandardGL;
        private System.Windows.Forms.Label LSportowaGL;
        private System.Windows.Forms.Label LKetoGL;
        private System.Windows.Forms.Label LSperosonalizowanaGL;
        private System.Windows.Forms.Label LPremiumGL;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LStandardWege;
        private System.Windows.Forms.Label LSportowaWege;
        private System.Windows.Forms.Label LKetoWege;
        private System.Windows.Forms.Label LSpersonalizowanyWege;
        private System.Windows.Forms.Label LPremiumWege;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LPremiumWGL;
        private System.Windows.Forms.Label LSpersonalizowanaWGL;
        private System.Windows.Forms.Label LKetoWGL;
        private System.Windows.Forms.Label LSportowaWGL;
        private System.Windows.Forms.Label LStandardWGL;
        private System.Windows.Forms.Button BtBazaDanych;
        private System.Windows.Forms.Button BtZawieszenieKateringu;
    }
}

