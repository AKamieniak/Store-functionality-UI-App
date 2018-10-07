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
    public partial class FormDeletePosition : Form
    {
        private readonly IWebApiCoreClient _webApiCoreClient;

        public FormDeletePosition()
        {
            _webApiCoreClient = Bootstrapper.container.GetInstance<IWebApiCoreClient>();
            AddPositions();
            InitializeComponent();
        }

        private async void AddPositions()
        {
            //---get Positions from database and add to listbox---
            var positions = await _webApiCoreClient.GetAllPositions();
            foreach (var item in positions)
            {
                listBoxPositions.Items.Add($"{item.Id} {item.PositionName}");
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string data = listBoxPositions.SelectedItem.ToString();
            string searchString = " ";
            int endIndex = data.IndexOf(searchString);
            int id = Convert.ToInt32(data.Substring(0, endIndex));

            //sprawddzic stop
            await _webApiCoreClient.DeletePosition(id);
        }
    } //polazyc delete i add do jednego formularza
}
