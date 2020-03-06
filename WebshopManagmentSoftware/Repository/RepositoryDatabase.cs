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
    class RepositoryDatabase
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public RepositoryDatabase()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Adatábázis létrehozzása
        /// </summary>
        public void createDatabase()
        {
            string query =
                "CREATE DATABASE IF NOT EXISTS webshoptest " +
                "DEFAULT CHARACTER SET utf8 " +
                "COLLATE utf8_hungarian_ci ";

            MySqlConnection connection =
                new MySqlConnection(connectionStringCreate);
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
                throw new RepositoryException("Adatbázis létrehozás nem sikerült vagy már létezik!");
            }


        }
        /// <summary>
        /// Törli az egész adatbázist
        /// </summary>
        public void deleteDatabase()
        {
            string query =
                "DROP DATABASE webshoptest;";

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
                throw new RepositoryException("Adatbázis törlése nem sikerült.");
            }
        }

    }
}
