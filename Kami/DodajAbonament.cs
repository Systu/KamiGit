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
    public partial class DodajAbonament : Form
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

        public DodajAbonament()
        {
            InitializeComponent();
            this.Load += Dodaj_Abonament_Load;
            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);
        }
        private void Dodaj_Abonament_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();// otworzenie połączenia
                SQLiteCommand Cmd = con.CreateCommand();
                Cmd.CommandText = "SELECT ImieNazwisko , ID FROM Diety";
                Cmd.CommandType = CommandType.Text; // Zapytanie sql 

                List<CBItem> resultItems = new List<CBItem>(); // utworzenie listy przedmiotow
                using (var reader = Cmd.ExecuteReader())
                {
                    while (reader.Read()) // do póki są rekordy to zaczytuje 
                    {
                        string imieNazwisko = reader["ImieNazwisko"].ToString();
                        string temp1 = reader["ID"].ToString();
                        CBItem item = new CBItem(imieNazwisko, temp1);
                        resultItems.Add(item); // dodanie przedmiotow do DB 
                    }
                }
                try
                {
                    BindingSource meBinding = new BindingSource();
                    meBinding.DataSource = resultItems; // zczytanie DB 

                    CBdane.DisplayMember = "ImieNazwisko"; // przypisanie DM 
                    CBdane.ValueMember = "ID"; // przypisanie VM 
                    CBdane.DataSource = meBinding; // DataSource
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                con.Close();// sprzątanie
            }

        }// przechwycenie przez CBImiona listy z Sqlite

        private void BTZaktualizuj_Click(object sender, EventArgs e)
        {
            string theDate = DPKalendarz.Value.ToShortDateString();
            DPKalendarz.Text= DateTime.Now.ToString("yyyy.MM.dd");
            CBItem Item = CBdane.SelectedItem as CBItem;// wywolanie Selected Value 

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    
                    SQLiteCommand Cmd = con.CreateCommand();
                    Cmd.CommandText = @"Update Diety set KoniecAbonamentu=@KoniecAbo where ID = @ID";
                    Cmd.Parameters.Add(new SQLiteParameter("@KoniecAbo", theDate));
                    Cmd.Parameters.Add(new SQLiteParameter("@ID", Item.Value));

                    int i = Cmd.ExecuteNonQuery();
                    if (i == 1 )
                    {
                        MessageBox.Show("Dodano abonament uzytkownikowi " + Item.ImieNazwisko);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Specialnie szkolone małpy zostały poinformowane by rozwiązać ten błąd" + ex.Message);
            }
        }
    }
       
    
}
