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
                ValidationApprover.SetIsValid(true);
            }
        }

        //Function responsible for validating the form.
        private bool EmployeeFormValidation()
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

            //6th parameter accepts values from "ValidationAllowedCharacters.SetAllowFunction" function
            //7th parameter accepts values from "ValidationRequiredCharacters.SetRequireFunction" function
            ValidationApprover.UserInputValidation(employeeFirstNameValue, 5, 15, employeeNameInfoLabel, firstNameValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeLastNameValue, 5, 15, employeeSurnameInfoLabel, lastNameValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeBirthValue, 5, 15, employeeBirthInfoLabel, birthValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeEmailValue, 5, 15, employeeEmailInfoLabel, emailValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeTelephoneValue, 5, 15, employeeTelephoneInfoLabel, telephoneValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeAddress1Value, 5, 15, employeeAddress1InfoLabel, address1Value, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeAddress2Value, 5, 15, employeeAddress2InfoLabel, address2Value, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeePostcodeValue, 5, 15, employeePostcodeInfoLabel, postcodeValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeTownValue, 5, 15, employeeTownInfoLabel, townValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeContractStartValue, 5, 15, employeeContractStartInfoLabel, contractStartValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeContractEndValue, 5, 15, employeeContractEndInfoLabel, contractEndValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(employeeSalaryValue, 5, 15, employeeSalaryInfoLabel, salaryValue, "LetterDigitSpaceDash", "Letter");

            return isValid = ValidationApprover.GetIsValid();
        }
    }
}
