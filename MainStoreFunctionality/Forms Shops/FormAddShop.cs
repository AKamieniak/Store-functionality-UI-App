using MainStoreFunctionality.Models;
using MainStoreFunctionality.WebApiCore;
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
    public partial class FormAddShop : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormAddShop()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string city = textBoxCity.Text;

            int id = await _webApiCoreClient.GetLastIndexShops();
            id++;

            var shop = new Shop()
            {
                Name = name,
                City = city,
                Id = id
            };

            await _webApiCoreClient.AddShop(shop);
            Close();

            //return sth to different form ?? google it
        }
    }
}
