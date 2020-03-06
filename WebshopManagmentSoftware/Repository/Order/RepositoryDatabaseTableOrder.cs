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
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryDatabaseTableOrder()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Tábla létrehozzása a teszt adatoknak
        /// </summary>
        public void createTableOrder()
        {
            string queryUSE = "USE webshoptest;";
        


            string queryCreateTable = "CREATE TABLE `test1` ("+
	                                    "`ID` INT NOT NULL,"+
	                                    "`customerName` VARCHAR(60),"+
	                                    "`productName` VARCHAR(60),"+
	                                    "`productQuantity` INT(11),"+
	                                    "`productPrice` INT(11)"+
                                    ") ENGINE = InnoDB;";

            string queryPrimaryKey =
                "ALTER TABLE `test1`  ADD PRIMARY KEY(`ID`);";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla lérehozása sikertelen.");
            }
        }
        /// <summary>
        /// Order tábla törlése az adatbázisból
        /// </summary>
        public void deleteTableOrder()
        {
            string query =
                "USE webshoptest; " +
                "DROP TABLE test1;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla törlése nem sikerült.");
            }
        }

        /// <summary>
        /// Tesztadatok törlése
        /// </summary>
        public void deleteDataFromTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Order.getSQLCommandDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok törlése sikertelen.");
            }
        }







    }
}
