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
    }
}
