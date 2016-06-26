using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakturyA
{
    class OurCompany
    {
        public string Regon { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string PlaceAddres { get; set; }
        public string NIP { get; set; }
        public string Code { get; set; }
        public string BankAccount1 { get; set; }
        public string BankAccount2 { get; set; }

        EditorXML XMLEdit = new EditorXML(MainProgram.NameConfigFile);
        public OurCompany()
        {
            CompanyName = XMLEdit.FindInXML("NazwaFirmy");
            City = XMLEdit.FindInXML("MiastoFirmy");
            PlaceAddres = XMLEdit.FindInXML("UlicaFirmy");
            NIP = XMLEdit.FindInXML("NIPFirmy");
            Regon = XMLEdit.FindInXML("REGONFirmy");
            Code = XMLEdit.FindInXML("KodFirmy");
            BankAccount1 = XMLEdit.FindInXML("kontoBankowe1Firmy");
            BankAccount2 = XMLEdit.FindInXML("kontoBankowe2Firmy");


        }
        public void EditOurCompany(OurCompany a)
        {

            XMLEdit.AddToXML("NazwaFirmy", a.CompanyName);
            XMLEdit.AddToXML("MiastoFirmy", a.City);
            XMLEdit.AddToXML("UlicaFirmy", a.PlaceAddres);
            XMLEdit.AddToXML("NIPFirmy", a.NIP);
            XMLEdit.AddToXML("KodFirmy", a.Code);
            XMLEdit.AddToXML("REGONFirmy", a.Regon);
            XMLEdit.AddToXML("kontoBankowe1Firmy", a.BankAccount1);
            XMLEdit.AddToXML("kontoBankowe2Firmy", a.BankAccount2);

        }
    }
}
