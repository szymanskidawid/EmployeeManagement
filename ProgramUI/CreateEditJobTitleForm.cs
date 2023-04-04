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
        private List<DepartmentModel> availableDepartments = SqlConnector.GetDepartments_All();

        public CreateEditJobTitleForm()
        {
            InitializeComponent();

            JobTitleLoadLists();
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
                SqlConnector.CreateJobTitle(jobTitleNameValue.Text,
                        jobTitleDepartmentDropDown.Text,
                        jobTitleSupervisorDropDown.Text);

                //Values will be set back to default after job title is created/edited
                jobTitleNameValue.Text = "";
                JobTitleLoadLists();

                //Closes the form
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Invalid information provided, please check comments and try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Function responsible for validating the form.
        private bool JobTitleFormValidation()
        {
            bool isValid = true;

            string nameValue = jobTitleNameValue.Text;

            if (jobTitleNameValue.Text.Length == 0 || jobTitleNameValue.Text.Length > 20 || !ValidationHelper.AllowLetterSpaceDash(nameValue))
            {
                isValid = false;
                ValidationHelper.SetTextboxState(jobTitleNameValue, jobTitleNameErrorLabel, true);
            }

            else
            {
                ValidationHelper.SetTextboxState(jobTitleNameValue, jobTitleNameErrorLabel, false);
            }

            return isValid;
        }
    }
}
