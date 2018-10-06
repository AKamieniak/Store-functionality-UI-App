using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainStoreFunctionality
{
    public partial class ShopsPanel : Form
    {
        public ShopsPanel()
        {
            InitializeComponent();
        }

        private void btnGetShops_Click(object sender, EventArgs e)
        {
            FormGetShops formGetShops = new FormGetShops();
            formGetShops.Show();
        }

        private void btnAddShop_Click(object sender, EventArgs e)
        {
            FormAddShop formAddShop = new FormAddShop();
            formAddShop.Show();
        }

        private void btnDeleteShop_Click(object sender, EventArgs e)
        {
            FormDeleteShop formDeleteShop = new FormDeleteShop();
            formDeleteShop.Show();
        }
    }
}
