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
    public partial class FormGetShops : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormGetShops()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddShops();
            InitializeComponent();
        }

        private async void AddShops()
        {
            //---get Shops from database and add to richTextBox---
            var shops = await _webApiCoreClient.GetAllShops();
            foreach (var shop in shops)
            {
                richTextBoxGetShops.AppendText($"{shop.Id} {shop.Name} {shop.City}");
            }
            richTextBoxGetShops.ScrollToCaret();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            richTextBoxGetShops.Clear();
            string city = textBoxCity.Text;

            var shops = await _webApiCoreClient.GetShopsByCity(city);

            foreach (var shop in shops)
            {
                string text = $"{shop.Id} {shop.Name } {shop.City}";
                if (!string.IsNullOrWhiteSpace(richTextBoxGetShops.Text))
                {
                    richTextBoxGetShops.AppendText("\r\n" + text);
                }
                else
                {
                    richTextBoxGetShops.AppendText(text);
                }

            }

            richTextBoxGetShops.ScrollToCaret();
        }
    }
}
