using ProgramLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class MainForm : Form
    {
        SqlConnector sql = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
  
            mainDepartmentView.Hide();
            mainEmployeeView.Show();
            mainEmployeeView.DataSource = sql.DisplayEmployees();

        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            mainEmployeeView.Hide();
            mainDepartmentView.Show();
            mainDepartmentView.DataSource = sql.DisplayDepartments();
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

        private void jobTitleManuItem_Click(object sender, EventArgs e)
        {
            CreateEditJobTitleForm jobTitleForm = new CreateEditJobTitleForm();
            jobTitleForm.Show();
        }
    }
}
