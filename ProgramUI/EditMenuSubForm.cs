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

        //Creates variables that will get a chosen entry to edit.
        private static EmployeeModel loadedEmployee = new();
        private static DepartmentModel loadedDepartment = new();
        private static JobTitleModel loadedJobTitle = new();

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
                EmployeeModel selectedEmployee = editListBox.SelectedItem as EmployeeModel;
                SetLoadedEmployee(selectedEmployee);

                CreateEditEmployeeForm employerForm = new();
                employerForm.Show();

                SetLoadedEmployee(null); //Reset the value inside function back to null so that it does not load when Create/Edit form is reopened.
            }
            else if (editCategoryDropDown.Text == "Department")
            {
                DepartmentModel selectedDepartment = editListBox.SelectedItem as DepartmentModel;
                SetLoadedDepartment(selectedDepartment);

                CreateEditDepartmentForm departmentForm = new();
                departmentForm.Show();

                SetLoadedDepartment(null); 
            }
            else if (editCategoryDropDown.Text == "Job Title")
            {
                JobTitleModel selectedJobTitle = editListBox.SelectedItem as JobTitleModel;
                SetLoadedJobTitle(selectedJobTitle);

                CreateEditJobTitleForm jobTitleForm = new();
                jobTitleForm.Show();

                SetLoadedJobTitle(null);
            }   
        }
        internal void SetLoadedEmployee(EmployeeModel model)
        {
            loadedEmployee = model;
        }

        //Below functions are setters and getters for use in a CreateEdit forms.
        internal static EmployeeModel GetLoadedEmployee()
        {
            return loadedEmployee;
        }

        internal void SetLoadedDepartment(DepartmentModel model)
        {
            loadedDepartment = model;
        }

        internal static DepartmentModel GetLoadedDepartment()
        {
            return loadedDepartment;
        }

        internal void SetLoadedJobTitle(JobTitleModel model)
        {
            loadedJobTitle = model;
        }

        internal static JobTitleModel GetLoadedJobTitle()
        {
            return loadedJobTitle;
        }
    }
}
