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
    public partial class ZmienDni : Form
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
        public ZmienDni()
        {
            InitializeComponent();
            this.Load += ZmienDni_Load;
            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);
        }
        private void ZmienDni_Load(object sender, EventArgs e)
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
                        CBItem item = new CBItem(imieNazwisko, temp1);
                        resultItems.Add(item); // dodanie przedmiotow do DB 
                    }
                }
                try
                {
                    BindingSource meBinding = new BindingSource();
                    meBinding.DataSource = resultItems; // zczytanie DB 

                    CbDane.DisplayMember = "ImieNazwisko"; // przypisanie DM 
                    CbDane.ValueMember = "ID"; // przypisanie VM 
                    CbDane.DataSource = meBinding; // DataSource
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
            string pon, wt, srd, czw, pt, sob, nd;
            if (ChBPoniedzialek.Checked)
            {
                pon = "tak";
            } else pon = "nie";
            if (ChBWtorek.Checked)
            {
                wt = "tak";
            } else wt = "nie";
            if (ChBSroda.Checked)
            {
                srd = "tak";
            } else srd = "nie";
            if (ChBCzwartek.Checked)
            {
                czw = "tak";
            } else czw = "nie";
            if (ChBPiatek.Checked)
            {
                pt = "tak";
            } else pt = "nie";
            if (ChBSobota.Checked)
            {
                sob = "tak";
            } else sob = "nie";
            if (ChBNiedziela.Checked)
            {
                nd = "tak";
            } else nd = "nie";

            CBItem Item = CbDane.SelectedItem as CBItem;// wywolanie Selected Value 

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                try
                {
                    con.Open();// otworzenie połączenia
                    SQLiteCommand Cmd = con.CreateCommand();
                    Cmd.CommandText = @"Update Diety set poniedziałek=@pon, wtorek=@wt, środa=@srd, czwartek=@czw, piątek=@pt,
                        sobota=@sob, niedziela=@nd where ID=@id";
                    Cmd.Parameters.Add(new SQLiteParameter("@pon", pon));
                    Cmd.Parameters.Add(new SQLiteParameter("@wt", wt));
                    Cmd.Parameters.Add(new SQLiteParameter("@srd", srd));
                    Cmd.Parameters.Add(new SQLiteParameter("@czw", czw));
                    Cmd.Parameters.Add(new SQLiteParameter("@pt", pt));
                    Cmd.Parameters.Add(new SQLiteParameter("@sob", sob));
                    Cmd.Parameters.Add(new SQLiteParameter("@nd", nd));
                    Cmd.Parameters.Add(new SQLiteParameter("@id", Item.Value));
                    Cmd.CommandType = CommandType.Text; // Zapytanie sql

                    int i = Cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Zmieniono dni u  " + Item.ImieNazwisko);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Specialnie szkolone małpy zostały poinformowane by rozwiązać ten błąd" + ex.Message);
                }
                
            }
        }
    }
    
}
