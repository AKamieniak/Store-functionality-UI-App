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

namespace MainStoreFunctionality.Forms_Positions
{
    public partial class FormAddPosition : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormAddPosition()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddPositions();
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            int id = await _webApiCoreClient.GetLastIndexPositions();
            id++;

            var position = new Position()
            {
                PositionName = name,
                Id = id
            };

            await _webApiCoreClient.AddPosition(position);
            Close();

            //add access box
        }
    }
}
