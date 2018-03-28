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
    public partial class Dodaj_Osobe : Form
    {
        string connectionString; // zmienna globalna do połączenia z baza danych
        List<CBItem> resultItems = new List<CBItem>(); // zmiena globalna listy nie mam innego pomysłu na przetworzenie
        
        public bool Sprawdz()// sprawdzenie zawartosci komórek do zapisu 
        {
            string ImieNaz, Dieta, Wykluczenia, Kalorie;
            ImieNaz = TextBImie_Nazwisko.Text;
            Dieta = CBDieta.Text;
            Wykluczenia = CBWykluczenia.Text;
            Kalorie = TextBKalorie.Text;

            if (string.IsNullOrEmpty(ImieNaz) || string.IsNullOrEmpty(Dieta)
                || string.IsNullOrEmpty(Wykluczenia) || string.IsNullOrEmpty(Kalorie))
            {
                return false;
            }
            else return true;
        }
         
        public Dodaj_Osobe()
        {
            InitializeComponent();

            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);
        }
        public class CBItem
        {
            string m_ImieNazwisko;
            string m_value;
            string m_dieta;
            public string ImieNazwisko
            {
                get { return m_ImieNazwisko; }
                set { m_ImieNazwisko = value; }
            }
            public string Value
            {
                get { return m_value; }
                set { m_value = value; }
            }
            public string Dieta
            {
                get { return m_dieta; }
                set { m_dieta = value; }
            }
            public CBItem(string @in, string @val, string @dieta)
            {
                m_ImieNazwisko = @in;
                m_value = @val;
                m_dieta = @dieta;
            }
        }// Klasa przechwujaca liste zczytaną z bazy danych.
        private void Dodaj_Osobe_Load(object sender, EventArgs e)// nie uzywana metoda ?? skad ona sie bierze ?
        {
             // utworzenie listy przedmiotow
             DataPicker.Text= DateTime.Now.ToString("yyyy.MM.dd");

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();// otworzenie połączenia
                SQLiteCommand Cmd = con.CreateCommand();
                Cmd.CommandText = "SELECT ImieNazwisko , ID, Dieta FROM Diety";
                Cmd.CommandType = CommandType.Text; // Zapytanie sql 

                using (var reader = Cmd.ExecuteReader())
                {
                    while (reader.Read()) // do póki są rekordy to zaczytuje 
                    {
                        string imieNazwisko = reader["ImieNazwisko"].ToString();
                        string id = reader["ID"].ToString();
                        string dieta = reader["Dieta"].ToString();
                        CBItem item = new CBItem(imieNazwisko, id, dieta);
                        resultItems.Add(item); // dodanie przedmiotow do DB
                    }
                }
                con.Close();// sprzątanie
            }
        }//wczytywanie z bazy danych
        private void BtDodajUzy_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();// otworzenie połączenia
                SQLiteCommand Cmd = con.CreateCommand();
                Cmd.CommandText = "SELECT ImieNazwisko , ID, Dieta FROM Diety";
                Cmd.CommandType = CommandType.Text; // Zapytanie sql 

                using (var reader = Cmd.ExecuteReader())
                {
                    while (reader.Read()) // do póki są rekordy to zaczytuje 
                    {
                        string imieNazwisko = reader["ImieNazwisko"].ToString();
                        string id = reader["ID"].ToString();
                        string dieta = reader["Dieta"].ToString();
                        CBItem item = new CBItem(imieNazwisko, id, dieta);
                        resultItems.Add(item); // dodanie przedmiotow do DB
                    }
                }
                con.Close();// sprzątanie
            }
            bool Powtorzenie = false;/* zmienna do sprawdzenia ponownego
            wystapienia uzytkownika o takich samych danych w bazie */

            foreach(CBItem DanezBazy in resultItems )
            {
                if(DanezBazy.ImieNazwisko==TextBImie_Nazwisko.Text.Trim()
                    && DanezBazy.Dieta==CBDieta.Text)
                {
                    MessageBox.Show("Juz masz takiego klienta Kamilka :) ");
                    Powtorzenie = true;

                }
            }
            if (Powtorzenie == false)
            {
                if (Sprawdz())
                {
                    try
                    {
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            string pon, wt, srd, czw, pt, sob, nd;
                            if (ChBPoniedzialek.Checked)
                            {
                                pon = "tak";
                            }
                            else pon = "nie";
                            if (ChBWtorek.Checked)
                            {
                                wt = "tak";
                            }
                            else wt = "nie";
                            if (ChBSroda.Checked)
                            {
                                srd = "tak";
                            }
                            else srd = "nie";
                            if (ChBCzwartek.Checked)
                            {
                                czw = "tak";
                            }
                            else czw = "nie";
                            if (ChBPiatek.Checked)
                            {
                                pt = "tak";
                            }
                            else pt = "nie";
                            if (ChBSobota.Checked)
                            {
                                sob = "tak";
                            }
                            else sob = "nie";
                            if (ChBNiedziela.Checked)
                            {
                                nd = "tak";
                            }   else nd = "nie";
                            SQLiteCommand cmd = new SQLiteCommand();
                            cmd.CommandText = @"INSERT INTO Diety (ImieNazwisko,Dieta,Kalorycznosc,Wykluczenia,KoniecAbonamentu, Adres, Piętro,
                                KodDomofonu,poniedziałek,wtorek,środa,czwartek,piątek,sobota,niedziela,Komentarz ) 
                                VALUES (@UserName,@Dietaa,@Kalorycznosc,@Wykluczenia,@Data,@Adres,@Pietro,@Kod,
                                @pon,@wt,@srd,@czw,@pt,@sob,@nd,@kom)";
                            cmd.Connection = con;
                            cmd.Parameters.Add(new SQLiteParameter("@UserName", TextBImie_Nazwisko.Text.Trim()));
                            cmd.Parameters.Add(new SQLiteParameter("@Dietaa", CBDieta.Text));
                            cmd.Parameters.Add(new SQLiteParameter("@Kalorycznosc", TextBKalorie.Text.Trim()));
                            cmd.Parameters.Add(new SQLiteParameter("@Wykluczenia", CBWykluczenia.Text));
                            cmd.Parameters.Add(new SQLiteParameter("@Data", DataPicker.Value.ToShortDateString()));
                            cmd.Parameters.Add(new SQLiteParameter("@Adres", textBAdress.Text));
                            cmd.Parameters.Add(new SQLiteParameter("@Pietro", textBPietro.Text));
                            cmd.Parameters.Add(new SQLiteParameter("@Kod", textBDomofon.Text));
                            cmd.Parameters.Add(new SQLiteParameter("@pon", pon));
                            cmd.Parameters.Add(new SQLiteParameter("@wt", wt));
                            cmd.Parameters.Add(new SQLiteParameter("@srd", srd));
                            cmd.Parameters.Add(new SQLiteParameter("@czw", czw));
                            cmd.Parameters.Add(new SQLiteParameter("@pt", pt));
                            cmd.Parameters.Add(new SQLiteParameter("@sob", sob));
                            cmd.Parameters.Add(new SQLiteParameter("@nd", nd));
                            cmd.Parameters.Add(new SQLiteParameter("@kom", TBKomentarz.Text));
                            con.Open();

                            int i = cmd.ExecuteNonQuery();

                            if (i == 1)
                            {
                                MessageBox.Show("Dodano Uzytkownika");
                            }
                            else MessageBox.Show("Coś poszło nie tak ");
                            con.Close();
                            TextBImie_Nazwisko.Text=TextBKalorie.Text =TBKomentarz.Text=textBAdress.Text=
                                textBPietro.Text=textBDomofon.Text= " ";
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Specialnie trenowane małpy już nad tym pracuja " +
                            "Kod błędu to:  "+ex.Message);
                    }
                }
                else MessageBox.Show("Siostra zapomniałaś o jakiś danych :)");//dodanie uzytkownika
            }

        }
    }
}
