using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XmlImport
{
    class Program
    {
        static void Main(string[] args)
        {


            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "xml files (*.xml)|*.xml";
            file.Multiselect = false;

      //      if (file.ShowDialog() == DialogResult.OK)
            {

                var xmlFile = XDocument.Load(@"Q:\Intense\!Import\T-Mobile import\dane.xml");
                //var xmlFile = XDocument.Load(file.FileName);
                /*var xmlPos = xmlFile.Element("przesylka").Element("pos");
                var xmlTyp = xmlPos.Element("typ");
                var xmlNazwa = xmlPos.Element("nazwa");
                var xmlUlica = xmlPos.Element("ulica");
                var xmlLokal = xmlPos.Element("lokal")

                //if (xmlTyp.Value != String.Empty)
                    Console.WriteLine(xmlTyp.Value);
                //else
                    Console.WriteLine("NULL");
                */


                var xmlPos = xmlFile.Element("przesylka").Element("pos");
                String typ = xmlPos.Element("typ").Value;
                String nazwa = xmlPos.Element("nazwa").Value;
                String ulica = xmlPos.Element("ulica").Value;
                String lokal = xmlPos.Element("lokal").Value;
                String kod_pocztowy = xmlPos.Element("kod_pocztowy").Value;
                String miasto = xmlPos.Element("miasto").Value;
                String emial = xmlPos.Element("emial").Value;
                String telefon = xmlPos.Element("telefon").Value;

                List<XmlTmobile> xmlEntries = new List<XmlTmobile>();


                var zgloszenia = xmlFile.Descendants("zgloszenie");
                foreach (var zgloszenie in zgloszenia)
                {
                    xmlEntries.Add(new XmlTmobile(typ, nazwa, ulica, lokal, kod_pocztowy, miasto, emial, telefon, zgloszenie.Element("zgloszenie_id").Value, zgloszenie.Element("data_rejestracji").Value, zgloszenie.Element("data_sprzedazy").Value, zgloszenie.Element("model").Value, zgloszenie.Element("nr_seryjny").Value, zgloszenie.Element("gwarancja").Value, zgloszenie.Element("opis_usterki").Value, zgloszenie.Element("rodzaj_uszkodzenia").Value, zgloszenie.Element("symptom_uszkodzenia").Value));

                }

                for (int i = 0; i < xmlEntries.Count; i++)
                {
                    Console.WriteLine(String.Format("typ: {0}   nazwa: {1}  zgloszenie_id: {2}", xmlEntries[i].typ, xmlEntries[i].nazwa, xmlEntries[i].zgloszenie_id));
                }


                Console.ReadKey();

                var names = xmlFile.Descendants("nazwa");
                foreach (var name in names)
                {
                    Console.WriteLine(name.Value);
                }
                var claims = xmlFile.Descendants("zgloszenie_id");
                foreach (var claim in claims)
                {
                    Console.WriteLine(claim.Value);
                }
                Console.ReadKey();


            }


        }
    }
}
