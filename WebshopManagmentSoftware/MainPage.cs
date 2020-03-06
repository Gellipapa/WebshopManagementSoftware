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
        Repo repo = new Repo();

        public MainPage()
        {
            InitializeComponent();
            beallitKezdoFormot();
        }

        public void beallitKezdoFormot()
        {
            this.Size = new Size(1024, 768);
            this.Text = "Phoenix PC Webshop";
        }

        
    }
}
