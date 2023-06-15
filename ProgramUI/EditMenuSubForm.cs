using ProgramLibrary;
using ProgramLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramUI
{
    public partial class EditMenuSubForm : Form
    {
        // Creates lists of available entries in each category.
        private readonly List<EmployeeModel> availableEmployees = SqlConnector.GetEmployees_All();
        private readonly List<DepartmentModel> availableDepartments = SqlConnector.GetDepartments_All();
        private readonly List<JobTitleModel> availableJobTitles = SqlConnector.GetJobTitles_All();

        // Creates variables that will get a chosen entry to edit.
        private static EmployeeModel selectedEmployee = new();
        private static DepartmentModel selectedDepartment = new();
        private static JobTitleModel selectedJobTitle = new();

        private static bool editState = false;

        public EditMenuSubForm()
        {
            InitializeComponent();

            EditLoadLists();
        }

        // Fills ListBox with available results depending on a category.
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

        // Displayed results in ListBox will change depending on selected item in DropDown.
        private void editCategoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditLoadLists();
        }

        // Below actions are triggered after Edit button is clicked.
        private void editMenuButton_Click(object sender, EventArgs e)
        {
            if (editCategoryDropDown.Text == "Employee")
            {
                selectedEmployee = editListBox.SelectedItem as EmployeeModel;
                IsEdit(true);

                this.Close();
                CreateEditEmployeeForm employerForm = new();
                employerForm.Show();

                //Reset the value inside function back to null so that it does not load when Create/Edit form is reopened.
                selectedEmployee = null; 
            }
            else if (editCategoryDropDown.Text == "Department")
            {
                selectedDepartment = editListBox.SelectedItem as DepartmentModel;
                IsEdit(true);

                this.Close();
                CreateEditDepartmentForm departmentForm = new();
                departmentForm.Show();

                //Reset the value inside function back to null so that it does not load when Create/Edit form is reopened.
                selectedDepartment = null;
            }
            else if (editCategoryDropDown.Text == "Job Title")
            {
                selectedJobTitle = editListBox.SelectedItem as JobTitleModel;
                IsEdit(true);

                this.Close();
                CreateEditJobTitleForm jobTitleForm = new();
                jobTitleForm.Show();

                //Reset the value inside function back to null so that it does not load when Create/Edit form is reopened.
                selectedJobTitle = null;
            }   
        }

        // Below actions are triggered after Delete button is clicked.
        private void deleteMenuButton_Click(object sender, EventArgs e)
        {
            if (editCategoryDropDown.Text == "Employee")
            {
                selectedEmployee = editListBox.SelectedItem as EmployeeModel;

                if (ConfirmMessageBox(selectedEmployee))
                {
                    SqlConnector.DeleteEmployee(selectedEmployee);

                    this.Close();

                    selectedEmployee = null;
                }
            }

            else if (editCategoryDropDown.Text == "Department")
            {
                selectedDepartment = editListBox.SelectedItem as DepartmentModel;

                if (ConfirmMessageBox(selectedDepartment))
                {
                    SqlConnector.DeleteDepartment(selectedDepartment);

                    this.Close();

                    selectedDepartment = null;
                }
            }

            else if (editCategoryDropDown.Text == "Job Title")
            {
                selectedJobTitle = editListBox.SelectedItem as JobTitleModel;
                
                if (ConfirmMessageBox(selectedJobTitle))
                {
                    SqlConnector.DeleteJobTitle(selectedJobTitle);

                    this.Close();

                    selectedJobTitle = null;
                }
            }
        }

        // Message box that pops up when Delete button is clicked.
        internal static bool ConfirmMessageBox<T>(T selectedEntry)
        {
            if (selectedEntry != null)
            {
                //Retrieve an array of all properties and get value from the 2nd property (in all models it will be a name).
                var entryProperties = selectedEntry.GetType().GetProperties();
                var nameValue = entryProperties[1].GetValue(selectedEntry)?.ToString();

                string message = $"Are you sure you want to delete {nameValue}?";

                DialogResult dr = MessageBox.Show(message, "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                return dr == DialogResult.Yes;

            }

            return false;
        }

        // Below functions are getters for use in a CreateEdit forms.
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

        // Functions below will determine whether Save button in a CreateEdit forms will save new entries into SQL or update existing ones.
        internal static void IsEdit(bool state)
        {
            editState = state;
        }

        internal static bool GetIsEdit()
        {
            return editState;
        }
    }
}
