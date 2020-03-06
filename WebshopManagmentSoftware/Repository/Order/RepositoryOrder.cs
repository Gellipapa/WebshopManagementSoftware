using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopManagmentSoftware.Model;
using WebshopManagmentSoftware.myExceptions;

namespace WebshopManagmentSoftware.Repository
{
  partial class Repo
    {
        //Order lista deklarálása
        List<Order> orders;

        //Orders visszadása a listának
        public List<Order> getOrders()
        {
            return orders;
        }
        //Orders beállítása
        public void setOrders(List<Order> orders)
        {
            this.orders = orders;
        }
        /// <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>
        public DataTable getOrderDataTableFromList()
        {
            DataTable orderDT = new DataTable();
            orderDT.Columns.Add("azon", typeof(int));
            orderDT.Columns.Add("vasarloNev", typeof(string));
            orderDT.Columns.Add("termekNev", typeof(string));
            orderDT.Columns.Add("termekMennyiseg", typeof(int));
            orderDT.Columns.Add("termekAr", typeof(int));

            foreach(Order o in orders)
            {
                orderDT.Rows.Add(o.getId(), o.getCustomerName(), o.getProductName(), o.getProductQuantity(), o.getProductPrice());
            }

            return orderDT;
        }

        /// <summary>
        /// A listát feltöltjük a táblában lévő adatokkal
        /// </summary>
        /// <param name="orderdt">Maga a tábla</param>
        private void fillOrderListFromDataTable(DataTable orderdt)
        {
            foreach(DataRow row in orderdt.Rows)
            {
                int azon = Convert.ToInt32(row[0]);
                string vasarloNev = row[1].ToString();
                string termekNev = row[2].ToString();
                int termekMennyiseg = Convert.ToInt32(row[3]);
                int termekAr = Convert.ToInt32(row[4]);

                Order o = new Order(azon, vasarloNev, termekNev, termekMennyiseg, termekAr);
                orders.Add(o);
            }
        }

        /// <summary>
        /// Rendelést törölni a listából ha az id nem található akkor hibaüzenet dobása
        /// </summary>
        /// <param name="id">Adott rendelés azonosítója</param>
        public void deleteOrderFromList(int id)
        {
            Order o = orders.Find(x => x.getId() == id);

            if (o != null)
                orders.Remove(o);
            else
                throw new RepositoryExceptionCantDelete("A rendelést nem lehet törölni!");
        }


        /// <summary>
        /// Frissiti a lista adott id-jű elemét
        /// </summary>
        /// <param name="id">Rendeles sorának adott azonositója</param>
        /// <param name="modified">Maga a módosítás amely máshol van deklarálva</param>
        public void updateOrderInList(int id,Order modified)
        {
            Order o = orders.Find(x => x.getId() == id);
            if (o != null)
                o.update(modified);
            else
                throw new RepositoryExceptionCantModified("A rendelés módosítása nem sikerült!");

        }

        /// <summary>
        /// Új rendelés hozzáadása
        /// </summary>
        /// <param name="newOrder">Maga az új rendelés</param>
        public void addOrderToList(Order newOrder)
        {
            try
            {
                orders.Add(newOrder);
            }
            catch(Exception ex)
            {
                throw new RepositoryExceptionCantAdd("A rendelés hozzáadása nem sikerült!");
            }
        }

        /// <summary>
        /// Visszaadja az azonosítót
        /// </summary>
        /// <param name="id">Azonosító értéke</param>
        /// <returns></returns>
        public Order getOrder(int id)
        {
            return orders.Find(x => x.getId() == id);
        }

        /// <summary>
        /// Új azonosított hozz létre mindig 1-el növeli az utolsó azonosító számát
        /// </summary>
        /// <returns>A megnövelt ID értékel tér vissza</returns>
        public int getNextOrderId()
        {
            if (orders.Count == 0)
                return 1;
            else
                return orders.Max(x => x.getId() + 1);
        }



    }
}
