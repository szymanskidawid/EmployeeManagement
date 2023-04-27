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

            //Code that modifies min/max value of Date Time Pickers.
            employeeBirthTimePicker.MaxDate = DateTime.Now.AddYears(-18);

            employeeContractStartTimePicker.MinDate = DateTime.Today;
            employeeContractStartTimePicker.MaxDate = DateTime.Now.AddMonths(1);
        }

        //Contract End rules will update each time Contract Start changes
        private void employeeContractStartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            employeeContractEndTimePicker.MinDate = employeeContractStartTimePicker.Value.AddMonths(3);
            employeeContractEndTimePicker.MaxDate = employeeContractStartTimePicker.Value.AddYears(1);
        }

        //Function that can be attached to automatically force input to start with capital letter
        private void Employee_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            UserInputModifier.CapitalizeFirstLetter(textBox);
        }

        //Fills DropDowns with information from the DropDownLists class.
        private void EmployeeLoadLists()
        {
            employeeJobTitleDropDown.DataSource = availableJobTitles;
            employeeJobTitleDropDown.DisplayMember = "JobTitleName";

            employeeCountryDropDown.DataSource = DropDownLists.CountryList();
            employeeGenderDropDown.DataSource = DropDownLists.GenderList;
            employeeCurrencyDropDown.DataSource = DropDownLists.CurrencyList;
        }

        //Save employee using values in the form fields.
        private void employeeSaveButton_Click(object sender, EventArgs e)
        {

            if (EmployeeFormValidation())
            {
                SqlConnector.CreateEmployee(employeeFirstNameValue.Text,
                        employeeLastNameValue.Text,
                        employeeBirthTimePicker.Text,
                        employeeGenderDropDown.Text,
                        employeeEmailValue.Text,
                        employeeTelephoneValue.Text,
                        employeeAddress1Value.Text,
                        employeePostcodeValue.Text,
                        employeeTownValue.Text,
                        employeeCountryDropDown.Text,
                        employeeJobTitleDropDown.Text,
                        employeeContractStartTimePicker.Text,
                        employeeContractEndTimePicker.Text,
                        employeeSalaryValue.Text,
                        employeeCurrencyDropDown.Text);

                //Values will be set back to default after employee is created/edited
                employeeFirstNameValue.Text = "";
                employeeLastNameValue.Text = "";
                employeeBirthTimePicker.Text = "";
                employeeEmailValue.Text = "";
                employeeTelephoneValue.Text = "";
                employeeAddress1Value.Text = "";
                employeePostcodeValue.Text = "";
                employeeTownValue.Text = "";
                employeeContractStartTimePicker.Text = "";
                employeeContractEndTimePicker.Text = "";
                employeeSalaryValue.Text = "";
                EmployeeLoadLists();

                //Closes the form
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Invalid information provided, please check comments and try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ValidationApprover.SetIsValid(true);
            }
        }

        //Function responsible for validating the form.
        private bool EmployeeFormValidation()
        {
            bool isValid = true;

            string firstNameValue = employeeFirstNameValue.Text;
            string lastNameValue = employeeLastNameValue.Text;
            string emailValue = employeeEmailValue.Text;
            string telephoneValue = employeeTelephoneValue.Text;
            string address1Value = employeeAddress1Value.Text;
            string postcodeValue = employeePostcodeValue.Text;
            string townValue = employeeTownValue.Text;
            string salaryValue = employeeSalaryValue.Text;

            //6th parameter accepts values from "ValidationAllowedCharacters.SetAllowFunction" function
            //7th parameter accepts values from "ValidationRequiredCharacters.SetRequireFunction" function
            ValidationApprover.UserInputValidation(employeeFirstNameValue, 2, 15, employeeNameInfoLabel, firstNameValue, "LetterDash", "Letter");
            ValidationApprover.UserInputValidation(employeeLastNameValue, 2, 15, employeeSurnameInfoLabel, lastNameValue, "LetterDash", "Letter");
            ValidationApprover.UserInputValidation(employeeEmailValue, 7, 30, employeeEmailInfoLabel, emailValue, "LetterDigitSpaceDashDotAt", "LetterAtDot");
            ValidationApprover.UserInputValidation(employeeTelephoneValue, 10, 20, employeeTelephoneInfoLabel, telephoneValue, "DigitPlus", "Digit");
            ValidationApprover.UserInputValidation(employeeAddress1Value, 5, 20, employeeAddress1InfoLabel, address1Value, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeePostcodeValue, 4, 10, employeePostcodeInfoLabel, postcodeValue, "LetterDigitSpace", "Digit");
            ValidationApprover.UserInputValidation(employeeTownValue, 3, 20, employeeTownInfoLabel, townValue, "LetterSpaceDash", "Letter"); 
            ValidationApprover.UserInputValidation(employeeSalaryValue, 6, 10, employeeSalaryInfoLabel, salaryValue, "Digit", "Digit");

            return isValid = ValidationApprover.GetIsValid();
        }

        
    }
}
