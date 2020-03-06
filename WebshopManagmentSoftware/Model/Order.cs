using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopManagmentSoftware.myExceptions;

namespace WebshopManagmentSoftware.Model
{
    partial class Order
    {
        private int id;
        private string customerName; 
        private string productName; 
        private int productQuantity;
        private int productPrice;
        /// <summary>
        /// Alap Konstruktor
        /// </summary>
        /// <param name="id">Azonosító</param>
        /// <param name="customerName">Vásárló neve</param>
        /// <param name="productName">Megrendelt termék neve</param>
        /// <param name="productQuantity">Megrendelt termék mennyisége</param>
        /// /// <param name="productPrice">Megrendelt termék mennyisége</param>
        public Order(int id,string customerName,string productName,int productQuantity,int productPrice)
        {
            this.id = id;
            this.customerName = customerName;
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
            
        }
        /// <summary>
        /// Validációs konstruktor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerName"></param>
        /// <param name="productName"></param>
        /// <param name="productQuantity"></param>
        /// /// <param name="productPrice"></param>
        public Order(int id, string customerName, string productName, string productQuantity,string productPrice)
        {
            
            this.id = id;
            if (!isValidCustomerName(customerName))
                throw new ModelOrderNotValidCustomerNameException("A vásárló neve helytelen!");
            if (!isValidProductName(productName))
                throw new ModelOrderNotValidProductNameException("A termék neve nem megfelelő!");
            if (!isValidQuantity(productQuantity))
                throw new ModelOrderNotValidProductQuantityException("A termék mennyisége nem megfelelő");
            if (!isValidPrice(productPrice))
                throw new ModelOrderNotValidProductPriceException("A termék ára nem megfelelő!");

            this.customerName = customerName;
            this.productName = productName;
            this.productQuantity = Convert.ToInt32(productQuantity);
            this.productPrice = Convert.ToInt32(productPrice);
        }

        //Getterek létrehozása és beállítása

        public int getId()
        {
            return id;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public string getProductName()
        {
            return productName;
        }

        public int getProductQuantity()
        {
            return productQuantity;
        }

        public int getProductPrice()
        {
            return productPrice;
        }

        //Setterek létrehozása és beállítása

        public void setID(int id)
        {
            this.id = id;
        }

        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public void setProductName(string productName)
        {
            this.productName = productName;
        }

        public void setProductQuantity(int productQuantity)
        {
            this.productQuantity = productQuantity;
        }

        public void setProductPrice(int productPrice)
        {
            this.productPrice = productPrice;
        }


        /// <summary>
        /// Validálása a productQuantity-nek és átalakítása INT-re.
        /// </summary>
        /// <param name="productQuantity"></param>
        /// <returns></returns>
        private bool isValidQuantity(string productQuantity)
        {
            int value_of_quantity= 0; //Mennyiség értéke
            if (int.TryParse(productQuantity, out value_of_quantity))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Validálása a productPrice-nak és átalakítása INT-re.
        /// </summary>
        /// <param name="productPrice"></param>
        /// <returns></returns>
        private bool isValidPrice(string productPrice)
        {
            int result_price = 0; //Kiszámolt ár
            if (int.TryParse(productPrice, out result_price))
                return true;
            else
                return false;
        }

        /// <summary>
        /// customerName validálása
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns></returns>
        private bool isValidCustomerName(string customerName)
        {
            if (customerName == string.Empty)
                return false;
            if (!char.IsUpper(customerName.ElementAt(0)))
                return false;
            for (int i = 1; i < customerName.Length; i = i + 1)
                if (!char.IsLetter(customerName.ElementAt(i)))
                    return false;
            return true;
        }

        /// <summary>
        /// productName validálása
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        private bool isValidProductName(string productName)
        {
            if (productName == string.Empty)
                return false;
            if (!char.IsUpper(productName.ElementAt(0)))
                return false;
            for (int i = 1; i < productName.Length; i = i + 1)
                if (!char.IsLetter(productName.ElementAt(i)))
                    return false;
            return true;
        }

        /// <summary>
        /// Frissíthető változók
        /// </summary>
        /// <param name="modified">frissítést tárolja el</param>
        public void update(Order modified)
        {
            this.customerName = modified.getCustomerName();
            this.productName = modified.getProductName();
            this.productQuantity = modified.getProductQuantity();
            this.productPrice = modified.getProductPrice();
        }







    }
}
