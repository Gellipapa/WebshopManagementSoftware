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
        //Ha namespace used hiba van akkor a namespacet kell ellenőrizni új fájlnál előfordul!

            /// <summary>
            /// Visszadja a adatbázisban lévő Orderst
            /// </summary>
            /// <returns>Visszatér az Orders adatokal</returns>
        public List<Order> getOrdersFromDatabaseTable()
        {
            List<Order> orders = new List<Order>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Order.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string customerName = dr["customerName"].ToString();
                    string productName = dr["productName"].ToString();
                    
                   
                    bool goodResult = false;

                    int id = -1;

                    goodResult = int.TryParse(dr["ID"].ToString(), out id);



                    if (goodResult)
                    {


                        int quantity_of_pieces = -1; //Mennyiség darabszáma
                        goodResult = int.TryParse(dr["productQuantity"].ToString(), out quantity_of_pieces);

                        int price = -1;
                        goodResult = int.TryParse(dr["productPrice"].ToString(), out price);

                        if (goodResult)
                        {
                            Order o = new Order(id, customerName,productName,quantity_of_pieces,price);
                            orders.Add(o);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Pizzaadatok beolvasása az adatbázisból nem sikerült!");
            }
            return orders;
        }
        /// <summary>
        /// Törli a ordert az adatbázisból
        /// </summary>
        /// <param name="id">Adott ID törli</param>
        public void deleteOrderFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM test1 WHERE ID=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idéjű rendelés törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        /// <summary>
        /// Módosítja a rendeléseket az adatbázisban
        /// </summary>
        /// <param name="id">Adott ID modosítja</param>
        /// <param name="modified">Maga a módosítás</param>
        public void updateOrderInDatabase(int id, Order modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(id);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idéjű rendelés módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        /// <summary>
        /// Új rendelést beszúr az adatbázisba
        /// </summary>
        /// <param name="newOrder">Az új rendelés</param>
        public void insertOrderToDatabase(Order newOrder)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = newOrder.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(newOrder + " rendelés beszúrása adatbázisba nem sikerült!");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisba!");
            }
        }












    }

     

    }

