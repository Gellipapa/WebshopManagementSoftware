using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebshopManagmentSoftware.Model;
using WebshopManagmentSoftware.myExceptions;
using WebshopManagmentSoftware.Repository;

namespace WebshopManagmentSoftware
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        private DataTable orderDT = new DataTable();

        bool newOrderDataInsert = false;

        private void buttonFill_Click(object sender, EventArgs e)
        {
            updateDataToDataGridView();
            setOrderDataGridViewt();
            setButtonsStart();

            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;

        }

        private void setButtonsStart()
        {
            
        }

        private void setOrderDataGridViewt()
        {
            orderDT.Columns[0].ColumnName = "Azonosító";
            orderDT.Columns[0].Caption = "Rendelés azonosító";

            orderDT.Columns[1].ColumnName = "Név";
            orderDT.Columns[1].Caption = "Megrendelő Név";

            orderDT.Columns[2].ColumnName = "Tnév";
            orderDT.Columns[2].Caption = "Termék Név";

            orderDT.Columns[3].ColumnName = "TMennyiség";
            orderDT.Columns[3].Caption = "Termék Mennyiség";

            orderDT.Columns[4].ColumnName = "Ár";
            orderDT.Columns[4].Caption = "Termék Ár";

            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.MultiSelect = false;

        }

        private void updateDataToDataGridView()
        {
            orderDT = repo.getOrderDataTableFromList();
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = orderDT;
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (newOrderDataInsert)
            
                setButtonsStart();
            if (dataGridViewOrders.SelectedRows.Count == 1)
            {

            }
            else
            {

            }

            
        }

        private void metroButtonOrderAdd_Click(object sender, EventArgs e)
        {
            AddOrder ao = new AddOrder();
            ao.Show();

           


            newOrderDataInsert = true;
            int newOrderID = repo.getNextOrderId();
            metroTextBoxID.Text = newOrderID.ToString();

           


            

            try
            {

                Order newOrder = new Order(Convert.ToInt32(metroTextBoxID.Text), metroTextBoxCustomerName.Text, metroTextBoxProductName.Text, metroTextBoxProductQuantity.Text, metroTextBoxProductPrice.Text);

                
                    int OrderId = Convert.ToInt32(metroTextBoxID.Text);

                    //Listához hozzáadás
                    try
                    {
                        repo.addOrderToList(newOrder);
                    }
                    catch(Exception ex)
                    {
                        return;
                    }

                    //Hozzáadni az adatbázishoz az adatokat

                    RepositoryDatabaseTableOrder rdto = new RepositoryDatabaseTableOrder();

                    try
                    {
                        rdto.insertOrderToDatabase(newOrder);

                        
                    }
                    catch(Exception ex)
                    {
                        
                    }

                updateDataToDataGridView();
                    if (dataGridViewOrders.SelectedRows.Count == 1)
                    {
                        setOrderDataGridViewt();
                    }
            }
            catch (ModelOrderNotValidCustomerNameException moe)
            {

            }
            catch(ModelOrderNotValidProductNameException mope)
            {

            }
            catch(ModelOrderNotValidProductQuantityException mopqe)
            {

            }
            catch(ModelOrderNotValidProductPriceException mope)
            {

            }
            catch(Exception ex)
            {

            }
        }
        /// <summary>
        /// Módosítás gomb eseménye
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButtonOrderModify_Click(object sender, EventArgs e)
        {
           
            try
            {

                Order updateOrderData = new Order(Convert.ToInt32(metroTextBoxID.Text), metroTextBoxCustomerName.Text, metroTextBoxProductName.Text, metroTextBoxProductQuantity.Text, metroTextBoxProductPrice.Text);


                int OrderId = Convert.ToInt32(metroTextBoxID.Text);

               
                try
                {
                    repo.updateOrderInList(OrderId,updateOrderData);
                }
                catch (Exception ex)
                {
                    return;
                }


                RepositoryDatabaseTableOrder rdto = new RepositoryDatabaseTableOrder();

                try
                {
                    rdto.updateOrderInDatabase(OrderId, updateOrderData);


                }
                catch (Exception ex)
                {

                }

                updateDataToDataGridView();
                if (dataGridViewOrders.SelectedRows.Count == 1)
                {
                    setOrderDataGridViewt();
                }
            }
            catch (ModelOrderNotValidCustomerNameException moe)
            {

            }
            catch (ModelOrderNotValidProductNameException mope)
            {

            }
            catch (ModelOrderNotValidProductQuantityException mopqe)
            {

            }
            catch (ModelOrderNotValidProductPriceException mope)
            {

            }
            catch(RepositoryExceptionCantModified rem)
            {
                Debug.WriteLine("A módosítás nem sikerült, a rendelés nincs a listában!");
            }
            catch (Exception ex)
            {

            }
        }


        //Törlés gomb

        private void metroButtonOrderDelete_Click(object sender, EventArgs e)
        {
            if ((dataGridViewOrders.Rows == null) ||
                (dataGridViewOrders.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewOrders.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //1. törölni kell a listából
                int id = -1;
                if (!int.TryParse(
                         dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString(),
                         out id))
                    return;
                try
                {
                    repo.deleteOrderFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    kiirHibauzenetet(recd.Message);
                    Debug.WriteLine("A rendelés törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                RepositoryDatabaseTableOrder rdto = new RepositoryDatabaseTableOrder();
                try
                {
                    rdto.deleteOrderFromDatabase(id);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                updateDataToDataGridView();
                if (dataGridViewOrders.SelectedRows.Count <= 0)
                {
                  
                }
                setOrderDataGridViewt();
            }

        }

    }
}
