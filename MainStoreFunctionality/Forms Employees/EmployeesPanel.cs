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
    public partial class EmployeesPanel : Form
    {
        public EmployeesPanel()
        {
            InitializeComponent();
        }

        private void btnGetEmployees_Click(object sender, EventArgs e)
        {
            FormGetEmployees formGetEmployees = new FormGetEmployees();
            formGetEmployees.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            FormDeleteEmployee formDeleteEmployee = new FormDeleteEmployee();
            formDeleteEmployee.Show();
        }
    }
}
