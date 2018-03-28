using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Kami
{
    public partial class Form1 : Form
    {
        readonly string _connectionString;
        private readonly List<Klient> _listaKlientowZBazyDanych = new List<Klient>();
        public Form1()
        {
            InitializeComponent();
            const string relativePath = @"Database\Kami.db";
            var currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var absolutePath = System.IO.Path.Combine(currentPath ?? throw new InvalidOperationException(), relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            _connectionString = $"Data Source={absolutePath}";
        }
        private void WypisanieDnia(string dzienTygodnia,string dataDzisiaj, SQLiteConnection con,string dieta)
        {
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > Date('" + dataDzisiaj + "') or " +
                "KoniecAbonamentu=Date('"+dataDzisiaj+"')) and "+dzienTygodnia+ "='tak' and Date('"+ dataDzisiaj+ "') " +
                "NOT between PoczatekZawieszenia and KoniecZawieszenia";
            cmd.Parameters.Add(new SQLiteParameter("@data", dataDzisiaj));
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LIloscOsobNaDzien.Text = reader["ilosc"].ToString();
            }//wszystko 
            reader.Close();

            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='"+dieta+"' and " + dzienTygodnia + "='tak' and Date('" + dataDzisiaj + "') " +
                "NOT between PoczatekZawieszenia and KoniecZawieszenia";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (dieta)
                {
                    case "Standard":
                        LLiczbaStandard.Text = reader["ilosc"].ToString();
                        break;
                    case "Sportowa":
                        LLiczbaSportowa.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Premium":
                        LLiczbaPremium.Text = reader["ilosc"].ToString();
                        break;
                    case "Spersonalizowana":
                        LLiczbaSpersonalizowany.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Ketogeniczna":
                        LLiczbaKeto.Text = reader["ilosc"].ToString();
                        break;
                }
            }//Bazowe
            reader.Close();

            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='" + dieta + "' and " + dzienTygodnia + "='tak'and Wykluczenia='Gluten'";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (dieta)
                {
                    case "Standard":
                        LStandardGluten.Text = reader["ilosc"].ToString();
                        break;
                    case "Sportowa":
                        LSportowaGluten.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Premium":
                        LPremiumGluten.Text = reader["ilosc"].ToString();
                        break;
                    case "Spersonalizowana":
                        LSpersonalizowanyGluten.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Ketogeniczna":
                        LKetoGluten.Text = reader["ilosc"].ToString();
                        break;
                }
            }// Gluten
            reader.Close();

            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where(KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='" + dieta + "' and " + dzienTygodnia + "='tak'and Wykluczenia='Laktoza'";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (dieta)
                {
                    case "Standard":
                        LStandardLaktoza.Text = reader["ilosc"].ToString();
                        break;
                    case "Sportowa":
                        LSportowaLaktoza.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Premium":
                        LPremiumLaktoza.Text = reader["ilosc"].ToString();
                        break;
                    case "Spersonalizowana":
                        LSperosonalizowanaLaktoza.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Ketogeniczna":
                        LKetoLaktoza.Text = reader["ilosc"].ToString();
                        break;
                }
            }// Laktoza
            reader.Close();


            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='"+dieta+"' and " + dzienTygodnia + "='tak'and Wykluczenia='Laktoza i Gluten'";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch(dieta)
                {
                    case "Standard":
                        LStandardGL.Text = reader["ilosc"].ToString();
                    break;
                    case "Sportowa":
                        LSportowaGL.Text = reader["ilosc"].ToString();
                    break;
                    case "Dieta Premium":
                        LPremiumGL.Text = reader["ilosc"].ToString();
                    break;
                    case "Spersonalizowana":
                        LSperosonalizowanaGL.Text = reader["ilosc"].ToString();
                    break;
                    case "Dieta Ketogeniczna":
                        LKetoGL.Text = reader["ilosc"].ToString();
                    break;
                }
            }// Laktoza i GLuten
            reader.Close();

            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='"+dieta+"' and " + dzienTygodnia + "='tak'and Wykluczenia='Wege'";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (dieta)
                {
                    case "Standard":
                        LStandardWege.Text = reader["ilosc"].ToString();
                        break;
                    case "Sportowa":
                        LSportowaWege.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Premium":
                        LPremiumWege.Text = reader["ilosc"].ToString();
                        break;
                    case "Spersonalizowana":
                        LSpersonalizowanyWege.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Ketogeniczna":
                        LKetoWege.Text = reader["ilosc"].ToString();
                        break;
                }
            }// Wege
            reader.Close();

            cmd.CommandText = "SELECT count(*) as ilosc FROM Diety where (KoniecAbonamentu > " +
                       "Date('" + dataDzisiaj + "') or KoniecAbonamentu = Date('" + dataDzisiaj + "')) and" +
                       " Dieta='" + dieta + "' and " + dzienTygodnia + "='tak'and Wykluczenia='Wege Gluten Laktoza'"; 
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (dieta)
                {
                    case "Standard":
                        LStandardWGL.Text = reader["ilosc"].ToString();
                        break;
                    case "Sportowa":
                        LSportowaWGL.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Premium":
                        LPremiumWGL.Text = reader["ilosc"].ToString();
                        break;
                    case "Spersonalizowana":
                        LSpersonalizowanaWGL.Text = reader["ilosc"].ToString();
                        break;
                    case "Dieta Ketogeniczna":
                        LKetoWGL.Text = reader["ilosc"].ToString();
                        break;
                }
            }// Wege Gluten Laktoza 
            reader.Close();
        }

        private void WczytanieBazyDanych(SQLiteConnection con)
        {
            SQLiteCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Diety";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string Id = reader["ID"].ToString();
                string ImieNazwisko = reader["ImieNazwisko"].ToString();
                string Dieta = reader["Dieta"].ToString();
                string Kalorycznosc = reader["Kalorycznosc"].ToString();
                string Wykluczenia = reader["Wykluczenia"].ToString();
                string KoniecAbonamentu = reader["KoniecAbonamentu"].ToString();
                string Adres = reader["Adres"].ToString();
                string Pietro = reader["Piętro"].ToString();
                string KodDomofonu = reader["KodDomofonu"].ToString();
                string Poniedzialek = reader["poniedziałek"].ToString();
                string Wtorek = reader["wtorek"].ToString();
                string Sroda = reader["środa"].ToString();
                string Czwartek = reader["czwartek"].ToString();
                string Piatek = reader["piątek"].ToString();
                string Sobota = reader["sobota"].ToString();
                string Niedziela = reader["niedziela"].ToString();
                string Komentarz = reader["Komentarz"].ToString();
                Klient NowyKlient = new Klient(Id, ImieNazwisko, Dieta, Kalorycznosc, Wykluczenia, KoniecAbonamentu, Adres,
                    Pietro, KodDomofonu, Poniedzialek, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela, Komentarz);
                _listaKlientowZBazyDanych.Add(NowyKlient);
            }//Wczytanie calej bazy danych 
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var con = new SQLiteConnection(_connectionString))
                {
                    con.Open();
                    DataMenuPicker.Value = DateTime.Now;
                    var dataDzisiaj = DateTime.Now.ToString("yyyy-MM-dd");
                    var jakiDzien = DateTime.Now.ToString("dddd");
                    WczytanieBazyDanych(con);
                    WypisanieDnia(jakiDzien, dataDzisiaj, con, "Standard");
                    WypisanieDnia(jakiDzien, dataDzisiaj, con, "Sportowa");
                    WypisanieDnia(jakiDzien, dataDzisiaj, con, "Dieta Premium");
                    WypisanieDnia(jakiDzien, dataDzisiaj, con, "Spersonalizowana");
                    WypisanieDnia(jakiDzien, dataDzisiaj, con, "Dieta Ketogeniczna");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Dodaj_Osobe_Click(object sender, EventArgs e)
        {
            try
            {
                
                var dodawanie = new Dodaj_Osobe();
                dodawanie.ShowDialog(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Zmien_Osobe_Click(object sender, EventArgs e)
        {
            try
            {
                Zmien_Abonamenta zmiana = new Zmien_Abonamenta();
                zmiana.ShowDialog(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Dodaj_Abonament_Click(object sender, EventArgs e)
        {
            try
            {
                DodajAbonament Dodaj = new DodajAbonament();
                Dodaj.ShowDialog(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtUsunOsobe_Click(object sender, EventArgs e)
        {
            try
            {
                Usun_Osobe Usun = new Usun_Osobe();
                Usun.ShowDialog(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtZmien_dni_Click(object sender, EventArgs e)
        {
            try
            {
                ZmienDni Zmiana = new ZmienDni();
                Zmiana.ShowDialog(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DataMenuPicker_ValueChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(_connectionString))
            {
                con.Open();
                var dataDzisiaj = DataMenuPicker.Value.ToShortDateString();
                var jakiDzien = DataMenuPicker.Value.ToString("dddd");

                WypisanieDnia(jakiDzien, dataDzisiaj, con, "Standard");
                WypisanieDnia(jakiDzien, dataDzisiaj, con, "Sportowa");
                WypisanieDnia(jakiDzien, dataDzisiaj, con, "Dieta Premium");
                WypisanieDnia(jakiDzien, dataDzisiaj, con, "Spersonalizowana");
                WypisanieDnia(jakiDzien, dataDzisiaj, con, "Dieta Ketogeniczna");
            }
        }

        private void BtDrukuj_Dzien_Click(object sender, EventArgs e)
        {
            try
            {
                DrukujDzien Drukuj = new DrukujDzien();
                Drukuj.ShowDialog(this);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtBazaDanych_Click(object sender, EventArgs e)
        {
            BazaDanych wyswietlenieBd = new BazaDanych(_listaKlientowZBazyDanych);
            wyswietlenieBd.Show(this);
        }

        private void BtZawieszenieKateringu_Click(object sender, EventArgs e)
        {
            ZawieszenieKteringu zawiesKatering = new ZawieszenieKteringu(_listaKlientowZBazyDanych);
            zawiesKatering.Show(this);
        }
    }
}
