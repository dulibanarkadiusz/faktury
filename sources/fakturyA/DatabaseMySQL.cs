using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fakturyA
{
    static class DatabaseMySQL
    {
        public static string Serwer { get; set; }
        public static string Uzytkownik { get; set;  }
        public static string Haslo { private get; set; }
        public static uint Port { get; set; }
        public static string Database { get; set; }

       static DatabaseMySQL()
        {
            Serwer = "localhost";
            Port = 3306;
        }

        public static MySqlConnection Connect(string database)
        {
            MySqlConnectionStringBuilder connection = new MySqlConnectionStringBuilder();
            connection.Server = Serwer;
            connection.UserID = Uzytkownik;
            connection.Password = Haslo;
            connection.Port = Port;
            connection.Database = Database;

            MySqlConnection makeConnect = new MySqlConnection(connection.ConnectionString);
            return makeConnect;
        }

        public static void OpenConnection(MySqlConnection connect)
        {
            connect.Open();
        }

        public static void CloseConnection(MySqlConnection connect)
        {
            connect.Close();
        }

        public static bool TryConnect(string login, string password, string databasename, string host, string port)
        {
            var conn_info = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",host,port,databasename,login,password);
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(conn_info);
                conn.Open();
                isConn = true;
            }
            catch (MySqlException ex)
            {
                isConn = false;
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Nie można było nawiązać połączenia z serwerem.\n Upewnij się, że nie są blokowane porty lub uruchomione jest oprogramowanie typu WebServ.");
                        break;
                    case 0:
                        MessageBox.Show("Logowanie nieudane.");
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                conn.Close();
            }
            return isConn;
        }
        
        public static void LoadInvoicesList()
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string queryText = string.Format("SELECT f.id,numer,id_pracownika, k.nazwa,concat(p.imie,' ',p.nazwisko),ifnull(nip,'-'),ROUND(sum(pf.cena*ilosc),2), ROUND(sum(pf.cena*ilosc)-zaplacona_kwota,2),data_wystawienia,termin_platnosci,data_sprzedazy,forma_platnosci,id_kontrahenta,zaplacona_kwota FROM faktura f, kontrahent k, pracownik p, pozycja_faktury pf WHERE (id_kontrahenta = k.id and id_pracownika = p.id and numer=pf.nr_faktury) GROUP BY numer HAVING (numer LIKE '%%')");
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                while (dataReader.Read())
                {
                    string[] cols = new string[dataReader.FieldCount];

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cols[i] = dataReader[i].ToString();
                    }

                    MainProgram.InvoiceObjectsList.Add(new Invoice(cols));
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }
        }


        public static void CreateNewInvoice(int ConsumerID, string dateInvoice, string dateSell, string datePayment, string paymentForm, string alreadyPaid, DataGridView articlesList)
        {

            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                CreateNumberForNewInvoice(); // tworzy numer faktury
                
                string queryText = string.Format("INSERT INTO faktura SET ");
                queryText += string.Format("numer='{0}', id_kontrahenta={1}, id_pracownika={2}, ", MainProgram.EditedInvoiceNumber, ConsumerID, MainProgram.LoggeUserID);
                queryText += string.Format("data_wystawienia='{0}', termin_platnosci='{1}', forma_platnosci='{2}', zaplacona_kwota={3}", dateInvoice, datePayment, paymentForm, alreadyPaid);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                query.ExecuteNonQuery();

                for (int i = 0; i < articlesList.RowCount; i++ )
                {
                    DataGridViewRow row = articlesList.Rows[i];
                    queryText = string.Format("INSERT INTO pozycja_faktury SET ");
                    queryText += string.Format("kod_artykulu='{0}', nr_faktury='{1}', ilosc={2}, rabat={3}, cena={4}", row.Cells[0].Value, MainProgram.EditedInvoiceNumber, row.Cells[6].Value, row.Cells[5].Value, row.Cells[2].Value);

                    query = new MySqlCommand(queryText, MainProgram.Connection);
                    query.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }

        }


        public static string CreateNumberForNewInvoice()
        {
            // Generowanie kolejnego numeru dla nowej faktury.
            string lastInvoiceNumber = "-1";
            string[] lastInvoiceNumberParts = {""};

            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string queryText = string.Format("SELECT numer from faktura WHERE id=(SELECT MAX(id) FROM faktura)");
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                dataReader.Read();
                lastInvoiceNumber = dataReader[0].ToString();
                lastInvoiceNumberParts = lastInvoiceNumber.Split('/');

                if (lastInvoiceNumberParts[1] == DateTime.Now.Month.ToString("00") && lastInvoiceNumberParts[2] == DateTime.Now.Year.ToString())
                {
                    lastInvoiceNumberParts[0] = (Convert.ToInt16(lastInvoiceNumberParts[0]) + 1).ToString();
                }
                else
                {
                    lastInvoiceNumberParts[0] = "1";
                }
                dataReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to create new number for invoice: "+exc.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }

            return String.Format("{0}/{1}/{2}", lastInvoiceNumberParts[0], DateTime.Now.Month.ToString("00"), DateTime.Now.Year.ToString());
        }



        public static string[] GetCustomerData(int id)
        {
            // Pobiera dane na temat danego kontrahenta
            // Stworzone jedynie testowo. 
            string[] data = new string[8];
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string queryText = string.Format("SELECT * from kontrahent WHERE id={0}", id);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                dataReader.Read();
                for (int i=0; i < dataReader.FieldCount; i++)
                {
                    data[i] = dataReader[i].ToString();
                }
                dataReader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return data;
        }


        public static string[] GetArticleData(string productCode)
        {
            // Pobiera informacje o danym artykule.
            // Stworzone tylko testowo. 
            string[] data = new string[51];
            try
            {
                string queryText = string.Format("SELECT * from artykul WHERE kod='{0}'", productCode);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                dataReader.Read();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    data[i] = dataReader[i].ToString();
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return data;
        }

        public static void LoadPositionsOnInvoice(Invoice invoice)
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                List<string[]> positionList = new List<string[]>();
                string qText = string.Format("SELECT * FROM pozycja_faktury WHERE nr_faktury='{0}';", invoice.Number);
                MySqlCommand command = new MySqlCommand(qText, MainProgram.Connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] cols = new string[3]; //fieldCount ile mamy kolumn z bazy
                    cols[0] = reader[1].ToString();
                    cols[1] = reader[3].ToString();
                    cols[2] = reader[4].ToString();

                    positionList.Add(cols);
                }
                reader.Close();

                foreach (string[] pos in positionList)
                {
                    Article art = new Article(DatabaseMySQL.GetArticleData(pos[0]));
                    MainProgram.InvoiceEditor.AddArticleToInvoice(new ArticleOnInvoice(art, Convert.ToDecimal(pos[2]), Convert.ToDecimal(pos[1])));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }
        }

        public static void LoadCustomerList()
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string queryText = string.Format("SELECT * from kontrahent");
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                while (dataReader.Read())
                {
                    string[] cols = new string[dataReader.FieldCount];

                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        cols[i] = dataReader[i].ToString();
                    }

                    MainProgram.CustomersList.Add(new Customers(cols));
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }
        }
        public static void LoadArticleList()
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string qText = string.Format("select* from artykul;");
                MySqlCommand q = new MySqlCommand(qText, MainProgram.Connection);
                MySqlDataReader reader = q.ExecuteReader();
                while (reader.Read())
                {
                    string[] cols = new string[reader.FieldCount]; //fieldCount ile mamy kolumn z bazy

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        cols[i] = reader[i].ToString();
                    }

                    FormArticles.articlesList.Add(new Article(cols));
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }
        }


        public static int ExecuteQuery(string query)
        {
            // POZWALA ZREALIZOWAĆ DOWOLNE ZAPYTANIE WYSŁANE JAKO TEKST. 
            // Uwaga: zwracana wartość to tylko ilość zmodyfikowanych krotek
            int n = -1;

            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                MySqlCommand command = new MySqlCommand(query, MainProgram.Connection);
                n = command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }

            return n; // zwraca liczbę zmodyfikowanych rekordów.
        }


        public static int ExecuteTransaction(List<string> queryList)
        {
            int n = 0;
            
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            DatabaseMySQL.OpenConnection(MainProgram.Connection);

            MySqlCommand command = MainProgram.Connection.CreateCommand();
            MySqlTransaction transaction;

            transaction = (MainProgram.Connection).BeginTransaction();
            command.Connection = MainProgram.Connection;
            command.Transaction = transaction;

            try
            {
                MessageBox.Show("Zapytań:" + queryList.Count);
                foreach (string query in queryList)
                {
                    MessageBox.Show(query);
                    command.CommandText = query;
                    n += command.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Poszło");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                n = -1;
                transaction.Rollback();
            }
            finally
            {
                DatabaseMySQL.CloseConnection(MainProgram.Connection);
            }

            return n; // zwraca liczbę zmodyfikowanych rekordów.
        }


        //////////////// USERS & PERMISSIONS /////////////
        public static List<string> GetUserPermissions(string username)
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            List<string> data = new List<string>(); 
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);

                string queryText = string.Format("show grants for '{0}'@'{1}';", username, DatabaseMySQL.Serwer);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        data.Add( dataReader[i].ToString());
                    }
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DatabaseMySQL.CloseConnection(MainProgram.Connection);

            return data;
        }


        public static List<string> GetUsersNicknamesList()
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            List<string> data = new List<string>();
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);

                string queryText = string.Format("select User from mysql.user WHERE host='{0}' and Length(User)>0;", DatabaseMySQL.Serwer);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        data.Add(dataReader[i].ToString());
                    }
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DatabaseMySQL.CloseConnection(MainProgram.Connection);

            return data;
        }


        public static string[] GetUserIDandName(string login)
        {
            MainProgram.Connection = DatabaseMySQL.Connect(MainProgram.DatabaseName);
            string[] data = new string[3];
            try
            {
                DatabaseMySQL.OpenConnection(MainProgram.Connection);
                string queryText = string.Format("SELECT id, imie, nazwisko from pracownik WHERE mysql_login='{0}'", login);
                MySqlCommand query = new MySqlCommand(queryText, MainProgram.Connection);
                MySqlDataReader dataReader = query.ExecuteReader();

                dataReader.Read();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    data[i] = dataReader[i].ToString();
                }
                dataReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            DatabaseMySQL.CloseConnection(MainProgram.Connection);

            return data;
        }


    }

}
