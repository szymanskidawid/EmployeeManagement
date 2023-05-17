using ProgramLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            mainEmployeeView.DataSource = SqlConnector.DisplayEmployees();       

            //Allows to sort each column in the table
            foreach (DataGridViewColumn column in mainEmployeeView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        // Function responsible for search engine of DataGridView.
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Remove selection box from a current cell.
            mainEmployeeView.ClearSelection();

            //Reset all cells back to default colour.
            foreach (DataGridViewRow row in mainEmployeeView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }

            // Loops through all rows inside DataGridView
            foreach (DataGridViewRow row in mainEmployeeView.Rows)
            {
                //Loops through all cells in a row inside DataGridView.
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Check if search imput matches with any cell.
                    if (cell.Value != null && cell.Value.ToString().Contains(searchValue.Text))
                    {
                        //Highlight cells that contain the search input.
                        cell.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }

        // Opens up Create Employee Form.
        private void createEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditEmployeeForm employerForm = new();
            employerForm.Show();
        }

        // Opens up Create Department Form.
        private void createDepartmentMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditDepartmentForm departmentForm = new();
            departmentForm.Show();
        }

        // Opens up Create Job Title Form.
        private void createJobTitleManuItem_Click(object sender, EventArgs e)
        {
            CreateEditJobTitleForm jobTitleForm = new();
            jobTitleForm.Show();
        }

        // Opens up Edit Menu SubForm.
        private void toolStripEditButton_Click(object sender, EventArgs e)
        {
            EditMenuSubForm employeeSubForm = new();
            employeeSubForm.Show();
        }

        // Closes the application when MainForm is closed.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
