using ProgramLibrary;
using ProgramLibrary.Models;
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
    public partial class CreateEditJobTitleForm : Form
    {
        //Gets a value of a chosen job title from EditMenuSubForm.
        private JobTitleModel loadedJobTitle = EditMenuSubForm.GetLoadedJobTitle();

        //Variable that gets values of  all available departments from Sql Departments table.
        private List<DepartmentModel> availableDepartments = SqlConnector.GetDepartments_All();

        public CreateEditJobTitleForm()
        {
            InitializeComponent();

            JobTitleLoadLists();

            //This code will load an existing department ONLY if user accesses Edit mode.
            if (loadedJobTitle != null)
            {
                LoadJobTitle(loadedJobTitle);
            }
        }

        //Function that can be attached to automatically force input to start with capital letter
        private void JobTitle_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            UserInputModifier.CapitalizeFirstLetter(textBox);
        }

        //Fills DropDowns with information from the SqlConnector and DropDownLists classes.
        private void JobTitleLoadLists()
        {
            jobTitleDepartmentDropDown.DataSource = availableDepartments;
            jobTitleDepartmentDropDown.DisplayMember = "DepartmentName";

            jobTitleSupervisorDropDown.DataSource = DropDownLists.IsSupervisorList;
        }

        //Save job title using values in the form fields.
        private void jobTitleSaveButton_Click(object sender, EventArgs e)
        {
            if (JobTitleFormValidation())
            {
                if (!EditMenuSubForm.GetEditState())
                {
                    //Save job title using values in the form fields.
                    SqlConnector.CreateJobTitle(jobTitleNameValue.Text,
                        jobTitleDepartmentDropDown.Text,
                        jobTitleSupervisorDropDown.Text);
                }

                else
                {
                    //Edit job title using values in the form fields.
                    SqlConnector.EditJobTitle(loadedJobTitle.Id, jobTitleNameValue.Text,
                        jobTitleDepartmentDropDown.Text, jobTitleSupervisorDropDown.Text);
                }

                ResetJobTitleFormValues();

                loadedJobTitle = null; // Sets value back to null so that this IF does not trigger automatically when form is opened again.

                EditMenuSubForm.SetEditState(false); //Sets Edit state back to false as we want Create state to be default.

                //JobTitleLoadLists();

                //Closes the form
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Invalid information provided, please check comments and try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ValidationApprover.SetIsValid(true);
            }
        }

        //Values will be set back to default after department is created/edited.
        private void ResetJobTitleFormValues()
        {
            jobTitleNameValue.Text = "";
        }

        //Function responsible for validating the form.
        private bool JobTitleFormValidation()
        {
            bool isValid = true;

            string nameValue = jobTitleNameValue.Text;

            //6th parameter accepts values from "ValidationAllowedCharacters.SetAllowFunction" function
            //7th parameter accepts values from "ValidationRequiredCharacters.SetRequireFunction" function
            ValidationApprover.UserInputValidation(jobTitleNameValue, 5, 20, jobTitleNameInfoLabel, nameValue, "LetterDigitSpaceDash", "Letter");

            return isValid = ValidationApprover.GetIsValid();
        }

        //Loads a department into fields when Edit is chosen.
        private void LoadJobTitle(JobTitleModel model)
        {
            jobTitleIdValue.Text = model.Id.ToString();
            jobTitleNameValue.Text = model.JobTitleName;
            jobTitleDepartmentDropDown.Text = model.JobTitleName;
            jobTitleSupervisorDropDown.Text = model.IsSupervisor;
        }
    }
}
