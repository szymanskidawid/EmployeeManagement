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
        private static EmployeeModel selectedEmployee = new();
        private static DepartmentModel selectedDepartment = new();
        private static JobTitleModel selectedJobTitle = new();

        private static bool editState = false;

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
                selectedEmployee = editListBox.SelectedItem as EmployeeModel;
                SetEditState(true);

                this.Close();
                CreateEditEmployeeForm employerForm = new();
                employerForm.Show();

                selectedEmployee = null; //Reset the value inside function back to null so that it does not load when Create/Edit form is reopened.
            }
            else if (editCategoryDropDown.Text == "Department")
            {
                selectedDepartment = editListBox.SelectedItem as DepartmentModel;
                SetEditState(true);

                this.Close();
                CreateEditDepartmentForm departmentForm = new();
                departmentForm.Show();

                selectedDepartment = null;
            }
            else if (editCategoryDropDown.Text == "Job Title")
            {
                selectedJobTitle = editListBox.SelectedItem as JobTitleModel;
                SetEditState(true);

                this.Close();
                CreateEditJobTitleForm jobTitleForm = new();
                jobTitleForm.Show();

                selectedJobTitle = null;
            }   
        }

        //Below functions are getters for use in a CreateEdit forms.
        internal static EmployeeModel GetSelectedEmployee()
        {
            return selectedEmployee;
        }

        internal static DepartmentModel GetSelectedDepartment()
        {
            return selectedDepartment;
        }

        internal static JobTitleModel GetSelectedJobTitle()
        {
            return selectedJobTitle;
        }

        //Functions below will determine whether Save button in a CreateEdit forms will save new entries into SQL or update existing ones.
        internal static void SetEditState(bool state)
        {
            editState = state;
        }

        internal static bool GetEditState()
        {
            return editState;
        }
    }
}
