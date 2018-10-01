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
    public partial class FormGetEmployees : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormGetEmployees()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddShops();
            InitializeComponent();  
        }

        private async void AddShops()
        {
            //---get Shops from database and add to combobox---
            var shops = await _webApiCoreClient.GetAllShops();
            foreach (var item in shops)
            {
                comboBoxShops.Items.Add($"{item.Id} {item.Name} {item.City}");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            richTextBoxGetEmployees.Clear();
            int id = Convert.ToInt32(comboBoxShops.SelectedIndex);
            id++;
            

            var employees = await _webApiCoreClient.GetAllEmployees(id);

            foreach (var employee in employees)
            {
                //position id zamienic na position.name
                //dodac /t?
                string text = $"{employee.Id} {employee.Name } {employee.Surname} {employee.PositionId}";
                if (!string.IsNullOrWhiteSpace(richTextBoxGetEmployees.Text))
                {
                    richTextBoxGetEmployees.AppendText("\r\n" + text);
                }
                else
                {
                    richTextBoxGetEmployees.AppendText(text);
                }

            }

            richTextBoxGetEmployees.ScrollToCaret();
        }
    }
}
