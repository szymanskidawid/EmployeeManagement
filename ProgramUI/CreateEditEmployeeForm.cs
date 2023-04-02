using ProgramLibrary.Models;
using ProgramLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Metrics;
using System.Net.Mail;

namespace ProgramUI
{
    public partial class CreateEditEmployeeForm : Form
    {
        private List<JobTitleModel> availableJobTitles = SqlConnector.GetJobTitles_All();

        public CreateEditEmployeeForm()
        {
            InitializeComponent();

            EmployeeLoadLists();
        }

        //Fills DropDowns with information from the DropDownLists class
        private void EmployeeLoadLists()
        {
            employeeJobTitleDropDown.DataSource = availableJobTitles;
            employeeJobTitleDropDown.DisplayMember = "JobTitleName";

            employeeCountryDropDown.DataSource = DropDownLists.CountryList();
            employeeGenderDropDown.DataSource = DropDownLists.GenderList;
            employeeCurrencyDropDown.DataSource = DropDownLists.CurrencyList;
        }

        //Save/Edit employee using values in the form fields
        private void employeeSaveButton_Click(object sender, EventArgs e)
        {

            if (EmployeeValidation())
            {
                SqlConnector.CreateEmployee(employeeFirstNameValue.Text,
                        employeeLastNameValue.Text,
                        employeeBirthValue.Text,
                        employeeGenderDropDown.Text,
                        employeeEmailValue.Text,
                        employeeTelephoneValue.Text,
                        employeeAddress1Value.Text,
                        employeeAddress2Value.Text,
                        employeePostcodeValue.Text,
                        employeeTownValue.Text,
                        employeeCountryDropDown.Text,
                        employeeJobTitleDropDown.Text,
                        employeeContractStartValue.Text,
                        employeeContractEndValue.Text,
                        employeeSalaryValue.Text,
                        employeeCurrencyDropDown.Text);

                //Values will be set back to default after employee is created/edited
                employeeFirstNameValue.Text = "";
                employeeLastNameValue.Text = "";
                employeeBirthValue.Text = "";
                employeeEmailValue.Text = "";
                employeeTelephoneValue.Text = "";
                employeeAddress1Value.Text = "";
                employeeAddress2Value.Text = "";
                employeePostcodeValue.Text = "";
                employeeTownValue.Text = "";
                employeeContractStartValue.Text = "";
                employeeContractEndValue.Text = "";
                employeeSalaryValue.Text = "";
                EmployeeLoadLists();

                //Closes the form
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Invalid information provided, please check comments and try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Function responsible for validation of data provided by user.
        private bool EmployeeValidation()
        {
            bool isValid = true;

            string firstNameValue = employeeFirstNameValue.Text;
            string lastNameValue = employeeLastNameValue.Text;
            string birthValue = employeeBirthValue.Text;
            string emailValue = employeeEmailValue.Text;
            string telephoneValue = employeeTelephoneValue.Text;
            string address1Value = employeeAddress1Value.Text;
            string address2Value = employeeAddress2Value.Text;
            string postcodeValue = employeePostcodeValue.Text;
            string townValue = employeeTownValue.Text;
            string contractStartValue = employeeContractStartValue.Text;
            string contractEndValue = employeeContractEndValue.Text;
            string salaryValue = employeeSalaryValue.Text;

            //if (employeeFirstNameValue.Text.Length == 0 || employeeFirstNameValue.Text.Length > 20 || !ValidationHelper.AllowLetter(firstNameValue))
            //{
            //    isValid = false;
            //    ValidationHelper.SetTextboxState(employeeFirstNameValue, null, true);
            //}

            //else
            //{
            //    ValidationHelper.SetTextboxState(employeeFirstNameValue, null, false);
            //}

            //if (employeeLastNameValue.Text.Length == 0 || employeeLastNameValue.Text.Length > 20 || !ValidationHelper.AllowLetter(firstNameValue))
            //{
            //    isValid = false;
            //    ValidationHelper.SetTextboxState(employeeLastNameValue, null, true);
            //}

            //else
            //{
            //    ValidationHelper.SetTextboxState(employeeLastNameValue, null, false);
            //}

            return isValid;
        }
    }
}
