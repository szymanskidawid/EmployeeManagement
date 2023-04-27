using ProgramLibrary;
using ProgramLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class EditMenuSubForm : Form
    {
        //Creates lists of available entries in each category.
        private List<EmployeeModel> availableEmployees = SqlConnector.GetEmployees_All();
        private List<DepartmentModel> availableDepartments = SqlConnector.GetDepartments_All();
        private List<JobTitleModel> availableJobTitles = SqlConnector.GetJobTitles_All();

        public EditMenuSubForm()
        {
            InitializeComponent();

            EditLoadLists();
        }

        //Fills ListBox with available results depending on a category.
        private void EditLoadLists()
        {
            editCategoryDropDown.DataSource = DropDownLists.EditCategoryList;

            if (editCategoryDropDown.Text == "Employee")
            {
                editListBox.DataSource = availableEmployees;
                editListBox.DisplayMember = "FirstName";
            }
            else if (editCategoryDropDown.Text == "Department")
            {
                editListBox.DataSource = availableDepartments;
                editListBox.DisplayMember = "DepartmentName";
            }
            else if (editCategoryDropDown.Text == "Job Title")
            {
                editListBox.DataSource = availableJobTitles;
                editListBox.DisplayMember = "JobTitleName";
            }
        }

        //Displayed results in ListBox will change depending on selected item in DropDown.
        private void editCategoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditLoadLists();
        }

        private void editMenuButton_Click(object sender, EventArgs e)
        {
            if (editCategoryDropDown.Text == "Employee")
            {
                CreateEditEmployeeForm employerForm = new();
                employerForm.Show();
            }
            else if (editCategoryDropDown.Text == "Department")
            {
                DepartmentModel department = new DepartmentModel();

                //WORK IN PROGRESS
                for (int i = 0; i < availableDepartments.Count; i++)
                {
                    if (editListBox.SelectedItem.ToString() == availableDepartments[i].DepartmentName.ToString())
                    {
                        department = availableDepartments[i];
                    }
                }

                CreateEditDepartmentForm departmentForm = new();
                departmentForm.Show();
            }
            else if (editCategoryDropDown.Text == "Job Title")
            {
                CreateEditJobTitleForm jobTitleForm = new();
                jobTitleForm.Show();
            }   
        }
    }
}
