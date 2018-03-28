using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kami
{
    
    public partial class BazaDanych : Form
    {
        public List<Klient> klienci = new List<Klient>();
        public BazaDanych()
        {
            InitializeComponent();
        }
        public BazaDanych(List<Klient> PoczatkowaListaKlientow)
        {
            InitializeComponent();
            klienci = PoczatkowaListaKlientow;
            DodajLudziDoListyBazyDanych();
        }
        public void DodajLudziDoListyBazyDanych()
        {
            foreach (Klient k in klienci)
            {
                dataGridView1.Rows.Add(k.Id, k.ImieNazwisko, k.Dieta, k.Kalorycznosc, k.Wykluczenia, k.KoniecAbonamentu,
                    k.Adres, k.Pietro, k.KodDomofonu, k.Poniedzialek, k.Wtorek, k.Sroda, k.Czwartek, k.Piatek, k.Sobota,
                    k.Niedziela, k.Komentarz);
            }
        
        }
    }
}
