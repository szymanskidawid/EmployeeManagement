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

namespace ProgramUI
{
    public partial class CreateEditEmployeeForm : Form
    {
        public CreateEditEmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeSaveButton_Click(object sender, EventArgs e)
        {
            /*EmployeeModel model = new(
                employeeFirstNameValue.Text,
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
                employeeSalaryValue.Text);*/

            SqlConnector sqlSave = new();
            sqlSave.CreateEmployee(model);


            this.Close();
        }
    }
}
