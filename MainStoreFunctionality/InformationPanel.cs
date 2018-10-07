using MainStoreFunctionality.Forms_Positions;
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
    public partial class InformationPanel : Form
    {
        public InformationPanel()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesPanel employeesPanel = new EmployeesPanel();
            employeesPanel.Show();
        }

        private void btnShops_Click(object sender, EventArgs e)
        {
            ShopsPanel shopsPanel = new ShopsPanel();
            shopsPanel.Show();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            PositionsPanel positionsPanel = new PositionsPanel();
            positionsPanel.Show();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
