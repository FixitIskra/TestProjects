using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLCreation
{
    class Program
    {
        static void Main(string[] args)
        {

            // ShipTo
            string shipToCompany = "Marcin Iskra";
            string shipToAttention = "Marcin Iskra";
            string shipToAddress1 = "Nad Serafą 56A";
            string shipToCountryTerritory = "PL";
            string shipToPostalCode = "30-864";
            string shipToCity = "Kraków";
            string shipToPhone = "603793795";
            string shipToEmail = "marcin.iskra@fixit.pl";

            //AccessPoint
            string pointCompany = "";
            string pointAddress1 = "";
            string pointCountryTerritory = "";
            string pointPostalCode = "";
            string pointCity = "";

            //

            //            XNamespace empNM = "x-schema:OpenShipments.xdr";
            XNamespace empNM = "http://www.ups.com/XMLSchema/CT/WorldShip/ImpExp/ShipmentImport/v1_0_0";

            XDocument xmlFile = new XDocument(
                new XDeclaration("1.0", "WINDOWS-1250", null)
                );

                //, new XElement("OpenShipments")
            

            XElement openShipments = new XElement(empNM+"OpenShipments");
            xmlFile.Add(openShipments);

            XElement openShipment = new XElement(empNM + "OpenShipment", new XAttribute("ProcessStatus",""), new XAttribute("ShipmentOption","EU"));
            openShipments.Add(openShipment);

            XElement shipTo = new XElement(empNM + "ShipTo"
                , new XElement(empNM + "CompanyOrName", shipToCompany)
                , new XElement(empNM + "Attention", shipToAttention)
                , new XElement(empNM + "Address1", shipToAddress1)
                , new XElement(empNM + "CountryTerritory", shipToCountryTerritory)
                , new XElement(empNM + "PostalCode", shipToPostalCode)
                , new XElement(empNM + "City", shipToCity)
                , new XElement(empNM + "Phone",shipToPhone)
                , new XElement(empNM + "Email",shipToEmail)
                );
            openShipment.Add(shipTo);

            XElement accessPoint = new XElement(empNM + "AccessPoint"
                , new XElement(empNM + "CompanyOrName",pointCompany)
                , new XElement(empNM + "Address1", pointAddress1)
                , new XElement(empNM + "CountryTerritory", pointCountryTerritory)
                , new XElement(empNM + "PostalCode", pointPostalCode)
                , new XElement(empNM + "CityOrTown",pointCity)
                );
            openShipment.Add(accessPoint);

            XElement shipmentInformation = new XElement(empNM + "ShipmentInformation"
                , new XElement(empNM + "ShipperNumber","WW4502")
                );
            openShipment.Add(shipmentInformation);

            XElement qVNOption = new XElement(empNM + "QVNOption");
            shipmentInformation.Add(qVNOption);

            XElement billingOption = new XElement(empNM + "BillingOption");
            shipmentInformation.Add(billingOption);

            XElement holdAtUPSAccessPointOption = new XElement(empNM + "HoldatUPSAccessPointOption");
            shipmentInformation.Add(holdAtUPSAccessPointOption);



            xmlFile.Save("Q:\\text.xml");


        }
    }
}
