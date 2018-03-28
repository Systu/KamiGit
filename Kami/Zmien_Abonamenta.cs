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
    public partial class Zmien_Abonamenta : Form
    {
        string connectionString;

        public class CBItem
        {
            string m_ImieNazwisko;
            string m_value;
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
            public CBItem(string @in, string @val)
            {
                m_ImieNazwisko = @in;
                m_value = @val;
            }
        }// Klasa przechwujaca liste 

        
        public Zmien_Abonamenta()
        {
            InitializeComponent();
            this.Load += Dodaj_Abonamenta_Load;
            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);
        }// Inicjalizacja okna + connect string

        private void Dodaj_Abonamenta_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();// otworzenie połączenia
                SQLiteCommand Cmd = con.CreateCommand();
                Cmd.CommandText = "SELECT ImieNazwisko , ID FROM Diety";
                Cmd.CommandType = CommandType.Text; // Zapytanie sql 

                List<CBItem> resultItems = new List<CBItem>(); // utwprzenie listy przedmiotow
                using (var reader = Cmd.ExecuteReader())
                {
                    while (reader.Read()) // do póki są rekordy to zaczytuje 
                    {
                        string imieNazwisko = reader["ImieNazwisko"].ToString();
                        string temp1 = reader["ID"].ToString();
                        CBItem item = new CBItem(imieNazwisko,temp1);
                        resultItems.Add(item); // dodanie przedmiotow do DB 
                    }
                }
                try
                {
                    BindingSource meBinding = new BindingSource();
                    meBinding.DataSource = resultItems; // zczytanie DB 
                    
                    CbImiona.DisplayMember = "ImieNazwisko"; // przypisanie DM 
                    CbImiona.ValueMember = "ID"; // przypisanie VM 
                    CbImiona.DataSource = meBinding; // DataSource
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
                con.Close();// sprzątanie
            }

        }// przechwycenie przez CBImiona listy z Sqlite

        private void BtZmien_Click(object sender, EventArgs e)
        {
            CBItem Item = CbImiona.SelectedItem as CBItem;// wywolanie Selected Value 
            
            string TextImieNazwisko = TbNoweImieNazwisko.Text;
            if (string.IsNullOrEmpty(TextImieNazwisko))
            {
                TbNoweImieNazwisko.Text = CbImiona.Text;
            }
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = @"Update Diety set ImieNazwisko=@UserName, Dieta=@Dietaa, Kalorycznosc=@Kalorycznosc,
                        Wykluczenia=@Wykluczenia, Adres=@Adres, Piętro=@Pietro, KodDomofonu=@Kod,Komentarz=@kom where ID = @ID";
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@UserName", TbNoweImieNazwisko.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Dietaa", CBDieta.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Kalorycznosc", TextBKalorie.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Wykluczenia", CBWykluczenia.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@ID", Item.Value));
                    cmd.Parameters.Add(new SQLiteParameter("@Adres", textBAdress.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Pietro", textBPietro.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Kod", textBDomofon.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@kom", TBKomentarz.Text));
                    con.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i == 1)
                    {
                        MessageBox.Show("Zmieniono Uzytkownika");
                    }
                    con.Close();
                }
            }
            
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
            }
        }
    }
}
