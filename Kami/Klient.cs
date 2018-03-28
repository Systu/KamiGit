using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kami
{
    public class Klient
    {
        public string Id { get; set; }
        public string ImieNazwisko { get; set; }
        public string Dieta { get; set; }
        public string Kalorycznosc { get; set; }
        public string Wykluczenia { get; set; }
        public string KoniecAbonamentu { get; set; }
        public string Adres { get; set; }
        public string Pietro { get; set; }
        public string KodDomofonu { get; set; }
        public string Poniedzialek { get; set; }
        public string Wtorek { get; set; }
        public string Sroda { get; set; }
        public string Czwartek { get; set; }
        public string Piatek { get; set; }
        public string Sobota { get; set; }
        public string Niedziela { get; set; }
        public string Komentarz { get; set; }
        
        public Klient()
        {
            Id = "";
            ImieNazwisko = "";
            Dieta = "";
            Kalorycznosc = "";
            Wykluczenia = "";
            KoniecAbonamentu = "";
            Adres = "";
            Pietro = "";
            KodDomofonu = "";
            Poniedzialek = "";
            Wtorek = "";
            Sroda = "";
            Czwartek = "";
            Piatek = "";
            Sobota = "";
            Niedziela = "";
            Komentarz = "";
        }
        public Klient(string Id,string ImieNazwisko, string Dieta, string Kalorycznosc, string Wykluczenia,
            string KoniecAbonamentu, string Adres, string Pietro, string KodDomofonu, string Poniedzialek,
            string Wtorek, string Sroda, string Czwartek, string Piatek, string Sobota, string Niedziela,
            string Komentarz)
        {
            this.Id = Id;
            this.ImieNazwisko = ImieNazwisko;
            this.Dieta = Dieta;
            this.Kalorycznosc = Kalorycznosc;
            this.Wykluczenia = Wykluczenia;
            this.KoniecAbonamentu = KoniecAbonamentu;
            this.Adres = Adres;
            this.Pietro = Pietro;
            this.KodDomofonu = KodDomofonu;
            this.Poniedzialek = Poniedzialek;
            this.Wtorek = Wtorek;
            this.Sroda = Sroda;
            this.Czwartek = Czwartek;
            this.Piatek = Piatek;
            this.Sobota = Sobota;
            this.Niedziela = Niedziela;
            this.Komentarz = Komentarz;
        }
    }
}
