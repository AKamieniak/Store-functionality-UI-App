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
    public partial class PositionsPanel : Form
    {
        public PositionsPanel()
        {
            InitializeComponent();
        }

        private void btnGetPositions_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            FormAddPosition formAddPosition = new FormAddPosition();
            formAddPosition.Show();
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            FormDeletePosition formDeletePosition = new FormDeletePosition();
            formDeletePosition.Show();
        }
    }
}
