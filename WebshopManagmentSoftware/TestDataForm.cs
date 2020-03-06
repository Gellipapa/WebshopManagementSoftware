using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebshopManagmentSoftware.Repository;

namespace WebshopManagmentSoftware
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {

        RepositoryDatabase rd = new RepositoryDatabase();
        RepositoryDatabaseTableOrder rdOrder = new RepositoryDatabaseTableOrder();

        private void torolHibauzenetet()
        {
            metroLabelHiba.ForeColor = Color.Black;
            metroLabelHiba.Text = "";
        }
        private void kiirHibauzenetet(string hibauzenet)
        {
            metroLabelHiba.ForeColor = Color.Red;
            metroLabelHiba.Text = hibauzenet;
        }

        private void metroButtonCreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rd.createDatabase();
            }
            catch(Exception ex)
            {
                kiirHibauzenetet("Adatbázis létrehozási hiba!");
            }
        }

        private void metroButtonDeleteDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rd.deleteDatabase();
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Adatbázis törlési hiba!");
            }
        }


        private void metroButtonFillDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();

                //táblák létrehozása
                rdOrder.createTableOrder();
          

                //tesztadatok feltöltése adatbázisba
                rdOrder.fillOrdersWithTestDataFromSQLCommand();
                

                //adatbázisból listák feltöltése
                repo.setOrders(rdOrder.getOrdersFromDatabaseTable());
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Tesztadatok felöltése sikertelen!");
            }
        }

        private void metroButtonDeleteData_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rdOrder.deleteTableOrder();
               
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Táblák törlése sikertelen!");
            }
        }
    }






    }

