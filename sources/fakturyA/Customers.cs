using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakturyA
{
    public class Customers
    {
        private int customerID;
        public int IdNumber { get; private set; } //0
        public string CompanyName { get; private set; }//1
        public string CustomerName { get; private set; }//2
        public string Address { get; private set; }//3
        public string City { get; private set; }//4
        public int Code { get; private set; }//5
        public string Email { get; private set; }//6
        public string CustomerNIP { get; private set; }//7
        public int CustomerID
        {
            get { return customerID; }
            set
            {
                // sprawdź, czy klient istnieje
                customerID = value;
            }
        }
        public Customers()
        {

            CompanyName = "";
            CustomerName = "";
            Address = "";
            City = "";
            Code = 0;
            Email = "";
            CustomerNIP = "";

        }
        public Customers(int id)
        {
            string [] dane = DatabaseMySQL.GetCustomerData(id);
            try
            {
                CustomerID = id;
                CompanyName = dane[1];
                CustomerName = dane[2];
                Address = dane[3];
                City = dane[4];
                Code = Convert.ToInt32(dane[5]);
                Email = dane[6];
                CustomerNIP = dane[7];
            }
            catch (Exception exc)
            {
                throw new Exception("One or more variables cannot be converted to correct format: " + exc.Message);
            }
        }
        public Customers(string[] dataRow)
        {

            try
            {
                CustomerID = Convert.ToInt32(dataRow[0]);
                CompanyName = dataRow[1];
                CustomerName = dataRow[2];
                Address = dataRow[3];
                City = dataRow[4];
                Code =Convert.ToInt32(dataRow[5]);
                Email = dataRow[6];
                if (dataRow.Length == 8)
                    CustomerNIP = dataRow[7];



            }
            catch (Exception exc)
            {
                throw new Exception("One or more variables cannot be converted to correct format: " + exc.Message);
            }
        }

        public string GenerateInsertQuery()
        {
            return String.Format("INSERT INTO kontrahent SET  nazwa='{0}', imie_nazwisko='{1}', ulica='{2}', miasto='{3}', kod_pocztowy={4}, email='{5}', NIP='{6}'", CompanyName, CustomerName, Address, City, Code, Email, CustomerNIP);
        }

        public string GenerateQueryDropCustomer()
        {
            return String.Format("Delete from kontrahent where nazwa='{0}'", CompanyName);
        }
    }
}
