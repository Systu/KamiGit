using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace Kami
{
    public partial class DrukujDzien : Form
    {
        readonly string _connectionString; // zmienna globalna do połączenia z baza danych
        readonly List<DlaKamili> _kamila = new List<DlaKamili>();
        readonly List<DlaKierowcy> _kierowca = new List<DlaKierowcy>();


        public class DlaKamili
        {
            public string ImieNazwisko { get; set; }
            public string Kalorie { get; set; }
            public string Dieta { get; set; }
            public string Wykluczenia { get; set; }
            public string Komentarz { get; set; }

            public DlaKamili(string imieNazwisko, string kalorie, string dieta,
                string wykluczenia, string komentarz)
            {
                ImieNazwisko = imieNazwisko;
                Kalorie = kalorie;
                Dieta = dieta;
                Wykluczenia = wykluczenia;
                Komentarz = komentarz;
            }
        }// Klasa przechwujaca liste zczytaną z bazy danych dla Kamili

        public class DlaKierowcy
        {
            public string Id { get; set; }
            public string ImieNazwisko { get; set; }
            public string Adres { get; set; }
            public string Pietro { get; set; }
            public string Kod { get; set; }
            public string Komentarz { get; set; }

            public DlaKierowcy(string id, string imieNazwisko, string adres, string pietro,
                string kod, string komentarz)
            {
                Id = id;
                ImieNazwisko = imieNazwisko;
                Adres = adres;
                Pietro = pietro;
                Kod = kod;
                Komentarz = komentarz;
            }
        }// Klasa przechwujaca liste zczytaną z bazy danych dla Kamili

        void WypiszDaneKamili(string dietaDoWypisania, StreamWriter sw)
        {
            var licznikObsob= _kamila.Count(k => k.Dieta == dietaDoWypisania);
            
            sw.WriteLine(dietaDoWypisania+" "+licznikObsob);
            sw.WriteLine("<table>");
            sw.WriteLine("<tr>");
                sw.WriteLine("<td>Imie Nazwisko</td>");
                sw.WriteLine("<td>Kalorie</td>");
                sw.WriteLine("<td>Wykluczenia</td>");
                sw.WriteLine("<td>Komentarz</td>");
            sw.WriteLine("</tr>");
            foreach (var k in _kamila)
            {

                if (k.Dieta != dietaDoWypisania) continue;
                sw.WriteLine("<tr>");
                    sw.WriteLine("<td>"+k.ImieNazwisko+"</td>");
                    sw.WriteLine("<td>" + k.Kalorie + "</td>");
                    sw.WriteLine("<td>" + k.Wykluczenia + "</td>");
                    sw.WriteLine("<td>" + k.Komentarz + "</td>");
                sw.WriteLine("</tr>");
            }
            sw.WriteLine("</table>");

        }

        int SprawdzenieIlosciOsob(string dietaDoWypisania)
        {
            var licznikOsob = 0;
            foreach (var k in _kamila)
            {
                if (k.Dieta == dietaDoWypisania)
                    licznikOsob++;
            }
            return licznikOsob;
        }
        void WypiszDaneKierowcy(StreamWriter sw)
        {
            var dataDzisiejsza = Kalendarz.Value.ToShortDateString();
            sw.WriteLine(dataDzisiejsza);
            foreach (var k in _kierowca)
            {
                sw.WriteLine(k.Id +" Imie Nazwisko: "+ k.ImieNazwisko +" Adres: "+ k.Adres +" Piętro: "
                    + k.Pietro +" Kod Do Domofonu: "+ k.Kod);
                sw.WriteLine("Komentarz: "+k.Komentarz);
                sw.WriteLine(" ");
            }
        }

        public void PobieramyDanyDzien(string dzienTygodnia, string dataDzisiaj, SQLiteConnection con)
        {
            _kamila.Clear();
            _kierowca.Clear();
            con.Open();// otworzenie połączenia
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT ID, ImieNazwisko, Kalorycznosc, Dieta, Wykluczenia, Komentarz FROM Diety where "+dzienTygodnia+"='tak'" +
                " and (KoniecAbonamentu> date('"+dataDzisiaj+"') or KoniecAbonamentu =date('"+dataDzisiaj+ "')) and Date('" + dataDzisiaj + "') " +
                "NOT between PoczatekZawieszenia and KoniecZawieszenia";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read()) // do póki są rekordy to zaczytuje 
                {
                    
                    try
                    {
                        var imieNazwisko = reader["ImieNazwisko"].ToString();
                        var kalorie = reader["Kalorycznosc"].ToString();
                        var dieta = reader["Dieta"].ToString();
                        var wykluczenia = reader["Wykluczenia"].ToString();
                        var komentarz = reader["Komentarz"].ToString();
                        var klient = new DlaKamili(imieNazwisko, kalorie, dieta, wykluczenia, komentarz);
                        _kamila.Add(klient); // dodanie przedmiotow do DB 
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message+ex.StackTrace);
                    }
                    
                }
                reader.Close();
            }
            
            cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT ID, ImieNazwisko, Adres, Piętro, KodDomofonu, Komentarz FROM Diety where " + dzienTygodnia + "='tak'" +
                " and (KoniecAbonamentu> date('" + dataDzisiaj + "') or KoniecAbonamentu =date('" + dataDzisiaj + "'))";
            cmd.CommandType = CommandType.Text; // Zapytanie sql 

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read()) // do póki są rekordy to zaczytuje 
                {
                    var id = reader["ID"].ToString();
                    var imieNazwisko = reader["ImieNazwisko"].ToString();
                    var adres = reader["Adres"].ToString();
                    var pietro = reader["Piętro"].ToString();
                    var kod = reader["KodDomofonu"].ToString();
                    string komentarz = reader["Komentarz"].ToString();

                    var dojazd = new DlaKierowcy(id, imieNazwisko, adres, pietro, kod, komentarz);
                    _kierowca.Add(dojazd); // dodanie przedmiotow do DB 
                }
            }
            con.Close();// sprzątanie
        
        }

        public DrukujDzien()
        {
            InitializeComponent();

            var relativePath = @"Database\Kami.db";
            var currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var absolutePath = Path.Combine(currentPath ?? throw new InvalidOperationException(), relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path
            _connectionString = $"Data Source={absolutePath}";

        }

        private void BTWczytajDane_Click(object sender, EventArgs e)
        {

            using (var con = new SQLiteConnection(_connectionString)) // zczytywanie danych dla kamili 
            {
                var dataDzisiejsza = Kalendarz.Value.ToShortDateString();
                var dzienDzisiaj = Kalendarz.Value.ToString("dddd");
                PobieramyDanyDzien(dzienDzisiaj, dataDzisiejsza, con);
            }
        }

        private void WypisanieDietyNaDzien(string nazwaDiety, string dataDzisiejsza)
        {
            var nazwaPliku =  nazwaDiety + @".html";
            if(File.Exists(nazwaPliku))
            {
                File.Delete(nazwaPliku);
            }
            var fs = new FileStream(nazwaPliku, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.WriteLine(dataDzisiejsza);
            WypiszDaneKamili(nazwaDiety, sw);
            sw.Close();
            
        }

        private void BTDrukujDlaKamili_Click(object sender, EventArgs e)
        {
            var dataDzisiejsza = Kalendarz.Value.ToShortDateString();
            const string plik = @"./DlaKierowcy.txt";
            
            if (File.Exists(plik))
            {
                File.Delete(plik);
            }

            if (SprawdzenieIlosciOsob("Standard") != 0)
            {
                WypisanieDietyNaDzien("Standard", dataDzisiejsza);
            }

            if (SprawdzenieIlosciOsob("Sportowa") != 0)
            {
                WypisanieDietyNaDzien("Sportowa", dataDzisiejsza);
            }

            if (SprawdzenieIlosciOsob("Dieta Premium") != 0)
            {
                WypisanieDietyNaDzien("Dieta Premium", dataDzisiejsza);
            }

            if (SprawdzenieIlosciOsob("Spersonalizowana") != 0)
            {
                WypisanieDietyNaDzien("Spersonalizowana", dataDzisiejsza);
            }

            if (SprawdzenieIlosciOsob("Dieta Ketogeniczna") != 0)
            {
                WypisanieDietyNaDzien("Dieta Ketogeniczna", dataDzisiejsza);
            }

            if (SprawdzenieIlosciOsob("Standard") != 0)
            {
                WypisanieDietyNaDzien("Standard", dataDzisiejsza);
            }

            var fsKierowcy = new FileStream("./DlaKierowcy.txt", FileMode.Create);
            var sw = new StreamWriter(fsKierowcy);
            WypiszDaneKierowcy(sw);
            sw.Close();
        }
    }
}
