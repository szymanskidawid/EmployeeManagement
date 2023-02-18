using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {       
            mainDepartmentView.Hide();
            mainEmployeeView.Show();
        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            mainEmployeeView.Hide();
            mainDepartmentView.Show();
        }

        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditEmployeeForm employerForm = new CreateEditEmployeeForm();
            employerForm.Show();
        }

        private void departmentMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditDepartmentForm departmentForm = new CreateEditDepartmentForm();
            departmentForm.Show();
        }
    }
}
