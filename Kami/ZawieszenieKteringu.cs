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
    public partial class ZawieszenieKteringu : Form
    {
        public List<Klient> listaKlientowZBazyDanych;
        string connectionString;

        public ZawieszenieKteringu()
        {
            InitializeComponent();
        }

        public ZawieszenieKteringu(List<Klient> listaKlientowZBazyDanych)
        {
            InitializeComponent();
            DPPoczatek.Value = DateTime.Now;
            DPKoniec.Value = DateTime.Now;
            this.listaKlientowZBazyDanych = listaKlientowZBazyDanych;
            string relativePath = @"Database\Kami.db";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            connectionString = string.Format("Data Source={0}", absolutePath);

            CbDane.DataSource = listaKlientowZBazyDanych;
            CbDane.DisplayMember = "ImieNazwisko";
            CbDane.ValueMember = "Id";
        }

        private void BtZawieszenie_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string DataPoczatku = DPPoczatek.Value.ToShortDateString();
                    string DataKonica = DPKoniec.Value.ToShortDateString();
                    SQLiteCommand Cmd = con.CreateCommand();
                    Cmd.CommandText = @"Update Diety set PoczatekZawieszenia=@PoczatekZaw, KoniecZawieszenia=@KoniecZaw where ID = @ID";
                    Cmd.Parameters.Add(new SQLiteParameter("@PoczatekZaw", DataPoczatku));
                    Cmd.Parameters.Add(new SQLiteParameter("@KoniecZaw", DataKonica));
                    Cmd.Parameters.Add(new SQLiteParameter("@ID", CbDane.SelectedValue));

                    int i = Cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Dodano zawieszenie uzytkownikowi ");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Specialnie szkolone małpy zostały poinformowane by rozwiązać ten błąd" + ex.Message);
            }
        }

        private void BTOdwies_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string DataPoczatku = "NULL";
                    string DataKonica = "NULL";
                    SQLiteCommand Cmd = con.CreateCommand();
                    Cmd.CommandText = @"Update Diety set PoczatekZawieszenia=@PoczatekZaw, KoniecZawieszenia=@KoniecZaw where ID = @ID";
                    Cmd.Parameters.Add(new SQLiteParameter("@PoczatekZaw", DataPoczatku));
                    Cmd.Parameters.Add(new SQLiteParameter("@KoniecZaw", DataKonica));
                    Cmd.Parameters.Add(new SQLiteParameter("@ID", CbDane.SelectedValue));

                    int i = Cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Ściągnięto zawieszenie użytkownikowi ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Specialnie szkolone małpy ruszyły do boju" + ex.Message);
            }
        }
    }
}
