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
    public partial class FormDeleteShop : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormDeleteShop()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddShops();
            InitializeComponent();
        }

        private async void AddShops()
        {
            //---get Shops from database and add to listbox---
            var shops = await _webApiCoreClient.GetAllShops();
            foreach (var item in shops)
            {
                listBoxShops.Items.Add($"{item.Id} {item.Name} {item.City}");
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string data = listBoxShops.SelectedItem.ToString();
            string searchString = " ";
            int endIndex = data.IndexOf(searchString);
            int id = Convert.ToInt32(data.Substring(0, endIndex));

            //sprawddzic stop
            await _webApiCoreClient.DeleteShop(id);
        }
    }
}
