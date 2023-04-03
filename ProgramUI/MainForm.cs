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

        public MainForm()
        {
            InitializeComponent();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
  
            mainDepartmentView.Hide();
            mainEmployeeView.Show();
            mainEmployeeView.DataSource = SqlConnector.DisplayEmployees();

        }

        private void departmentsButton_Click(object sender, EventArgs e)
        {
            mainEmployeeView.Hide();
            mainDepartmentView.Show();
            mainDepartmentView.DataSource = SqlConnector.DisplayDepartments();
        }

        //Opens up Create Employee Form.
        private void createEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditEmployeeForm employerForm = new();
            employerForm.Show();
        }

        //Opens up Create Department Form.
        private void createDepartmentMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditDepartmentForm departmentForm = new();
            departmentForm.Show();
        }

        //Opens up Create Job Title Form.
        private void createJobTitleManuItem_Click(object sender, EventArgs e)
        {
            CreateEditJobTitleForm jobTitleForm = new();
            jobTitleForm.Show();
        }

        //Opens up Edit Menu SubForm.
        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            EditMenuSubForm employeeSubForm = new();
            employeeSubForm.Show();
        }
    }
}
