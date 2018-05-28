using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlImport
{
    public class XmlTmobile
    {
        public String typ;
        public String nazwa;
        public String ulica;
        public String lokal;
        public String kod_pocztowy;
        public String miasto;
        //public String kraj = "Poland";
        public String emial;
        public String telefon;
        //public int koropracja = 1555;
        public String zgloszenie_id;
        public String data_rejestracji;
        public String data_sprzedazy;
        public String model;
        public String nr_seryjny;
        public String gwarancja;
        public String opis_usterki;
        public String rodzaj_uszkodzenia;
        public String symptom_uszkodzenia;

        public XmlTmobile()
        {
        }

        public XmlTmobile(String typ, String nazwa, String ulica, String lokal, String kod_pocztowy, String miasto, String emial, String telefon, String zgloszenie_id, String data_rejestracji, String data_sprzedazy, String model, String nr_seryjny, String gwarancja, String opis_usterki, String rodzaj_uszkodzenia, String symptom_uszkodzenia)
        {
            this.typ = typ;
            this.nazwa = nazwa;
            this.ulica = ulica;
            this.lokal = lokal;
            this.kod_pocztowy = kod_pocztowy;
            this.miasto = miasto;
            this.emial = emial;
            this.telefon = telefon;
            this.zgloszenie_id = zgloszenie_id;
            this.data_rejestracji = data_rejestracji;
            this.data_sprzedazy = data_sprzedazy;
            this.model = model;
            this.nr_seryjny = nr_seryjny;
            this.gwarancja = gwarancja;
            this.opis_usterki = opis_usterki;
            this.rodzaj_uszkodzenia = rodzaj_uszkodzenia;
            this.symptom_uszkodzenia = symptom_uszkodzenia;
        }

    }
}
