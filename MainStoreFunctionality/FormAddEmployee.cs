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
    public partial class FormAddEmployee : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormAddEmployee()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddPositions();
            AddShops();
            InitializeComponent();
        }

        private async void AddPositions()
        {
            //---get positions from database and add to listbox---
            var positions = await _webApiCoreClient.GetAllPositions();
            foreach (var item in positions)
            {
                comboBoxPosition.Items.Add($"{item.Id} {item.PositionName}");
            }
        }

        private async void AddShops()
        {
            //---get Shops from database and add to listbox---
            var shops = await _webApiCoreClient.GetAllShops();
            foreach (var item in shops)
            {
                comboBoxShops.Items.Add($"{item.Id} {item.Name} {item.City}");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

            int positionID = Convert.ToInt32(comboBoxPosition.SelectedIndex);
            positionID++;

            int shopId = Convert.ToInt32(comboBoxShops.SelectedIndex);
            shopId++; 

            int id = await _webApiCoreClient.GetLastIndexEmployees();
            id++;

            var employee = new Employee()
            {
                Name = name,
                Surname = surname,
                ShopId = shopId,
                Id = id,
                PositionId = positionID
             
            };

            await _webApiCoreClient.AddEmployee(employee);
            Close();
        }
    }
}
