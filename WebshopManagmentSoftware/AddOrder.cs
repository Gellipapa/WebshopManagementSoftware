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
    public partial class AddOrder : MetroFramework.Forms.MetroForm
    {
        public AddOrder()
        {
            InitializeComponent();

            
        }

        public string TheValue
        {

            get { return metroTextBoxCustomerName1.Text; }

        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {

        }

       

    }
}
