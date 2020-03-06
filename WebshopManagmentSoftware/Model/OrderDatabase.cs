using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopManagmentSoftware.Model
{
    partial class Order
    {
        /// <summary>
        /// Adatbázisban történő adat beszúrás
        /// </summary>
        /// <returns></returns>
        public string getInsert()
        {
            return
                "INSERT INTO `test` (`ID`, `customerName`, `productName`,`productQuantity`,`productPrice`) " +
                "VALUES ('" +
                id +
                "', '" +
                getCustomerName() +
                "', '" +
                getProductName() +
                "','"+
                getProductQuantity()+
                "','" +
                getProductPrice()+
                "');";
        }

        /// <summary>
        /// Frissíti az adott mezőket az adatbázisban
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUpdate(int id)
        {
            return
                "UPDATE `test` SET `customerName` = '" +
                getCustomerName() +
                "', `productName` = '" +
                getProductName() +
                "', `productQuantity` = '" +
                getProductQuantity() +

                "', `productPrice` = '" +
                getProductPrice()+

                "' WHERE `test`.`ID` = " +
                id;
        }

        /// <summary>
        /// Törli az összes sort az adatbázisból
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM test";
        }

        /// <summary>
        /// Ki listázza az összes megtalálható sort az adatbázis táblából
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM test1";
        }


    }
}
