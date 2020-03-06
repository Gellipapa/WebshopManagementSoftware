using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopManagmentSoftware.Model;
using WebshopManagmentSoftware.myExceptions;

namespace WebshopManagmentSoftware.Repository
{
    partial class RepositoryDatabaseTableOrder
    {
        public void fillOrdersWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `test1` (`ID`, `customerName`, `productName`,`productQuantity`,`productPrice`) VALUES " +
                            " (1, 'Jancsi', 'Alaplap',1,20000), " +
                            " (2, 'Béla','Videókártya',1,45000), " +
                            " (3, 'Gáspár','Egér',1,780), " +
                            " (4, 'Gellért','Egérpad',2,350), " +
                            " (5, 'Dávid','Monitor',1,990); ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok feltöltése sikertelen.");
            }
        }
    }
}
