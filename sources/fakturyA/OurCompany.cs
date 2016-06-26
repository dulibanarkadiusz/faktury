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
        public void EditOurCompany()
        {

            XMLEdit.AddToXML("NazwaFirmy", CompanyName);
            XMLEdit.AddToXML("MiastoFirmy", City);
            XMLEdit.AddToXML("UlicaFirmy", PlaceAddres);
            XMLEdit.AddToXML("NIPFirmy", NIP);
            XMLEdit.AddToXML("KodPocztowyFirmy", Code);
            XMLEdit.AddToXML("REGONFirmy", Regon);
            XMLEdit.AddToXML("kontoBankowe1Firmy", BankAccount1);
            XMLEdit.AddToXML("kontoBankowe2Firmy", BankAccount2);

        }
    }
}
