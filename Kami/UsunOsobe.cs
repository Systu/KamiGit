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
    public partial class Usun_Osobe : Form
    {
        string connectionString;


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
            public CBItem(string @in, string @val, string @die)
            {
                m_ImieNazwisko = @in;
                m_value = @val;
                m_dieta = @die;
            }
        }// Klasa przechwujaca liste

        public Usun_Osobe()
        {
            InitializeComponent();
            this.Load += Usun_Osobe_Load;

            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);
        }
        private void Usun_Osobe_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();// otworzenie połączenia
                SQLiteCommand Cmd = con.CreateCommand();
                Cmd.CommandText = "SELECT ImieNazwisko , ID, Dieta FROM Diety";
                Cmd.CommandType = CommandType.Text; // Zapytanie sql 

                List<CBItem> resultItems = new List<CBItem>(); // utwprzenie listy przedmiotow
                using (var reader = Cmd.ExecuteReader())
                {
                    while (reader.Read()) // do póki są rekordy to zaczytuje 
                    {
                        string imieNazwisko = reader["ImieNazwisko"].ToString();
                        string temp1 = reader["ID"].ToString();
                        string temp2 = reader["Dieta"].ToString();
                        CBItem item = new CBItem(imieNazwisko, temp1, temp2);
                        resultItems.Add(item); // dodanie przedmiotow do DB 
                    }
                }
                try
                {
                    BindingSource meBinding = new BindingSource();
                    meBinding.DataSource = resultItems; // zczytanie DB 

                    CBDane.DisplayMember = "ImieNazwisko"; // przypisanie DM 
                    CBDane.ValueMember = "ID"; // przypisanie VM 
                    CBDane.DataSource = meBinding; // DataSource
                    CBItem Item = CBDane.SelectedItem as CBItem;
                    TBDieta.Text = Item.Dieta;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                con.Close();// sprzątanie
            }

        }// przechwycenie przez CBImiona listy z Sqlite

        private void BtUsunOsobe_Click(object sender, EventArgs e)
        {
            CBItem Item = CBDane.SelectedItem as CBItem;
            if (MessageBox.Show("Czy napewno chcesz usunąć te osobę?\n Tej operacji nie da się odwrócić. ", "UWAGA!!!!", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        con.Open();// otworzenie połączenia
                        SQLiteCommand Cmd = con.CreateCommand();
                        Cmd.CommandText = "Delete FROM Diety where ID=@id";
                        Cmd.Parameters.Add(new SQLiteParameter("@id", Item.Value));
                        Cmd.CommandType = CommandType.Text; // Zapytanie sql

                        int i = Cmd.ExecuteNonQuery();

                        if (i == 1)
                        {
                            MessageBox.Show("Usunieto Uzytkownika");
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }

        private void CBDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBItem Item = CBDane.SelectedItem as CBItem;
            TBDieta.Text = Item.Dieta;
        }
    }
}
