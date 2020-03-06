using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        
    }
}
