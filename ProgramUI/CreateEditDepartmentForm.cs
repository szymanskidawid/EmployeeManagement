using ProgramLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace ProgramUI
{
    public partial class CreateEditDepartmentForm : Form
    {
        public CreateEditDepartmentForm()
        {
            InitializeComponent();
           
        }

        //Function that can be attached to automatically force input to start with capital letter
        private void Department_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            UserInputModifier.CapitalizeFirstLetter(textBox);
        }

        //Save department using values in the form fields.
        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            if (DepartmentFormValidation())
            {
                //Save/Edit department using values in the form fields.
                SqlConnector.CreateDepartment(departmentNameValue.Text,
                    departmentLocationValue.Text);

                //Values will be set back to default after department is created/edited.
                departmentNameValue.Text = "";
                departmentLocationValue.Text = "";

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
        private bool DepartmentFormValidation()
        {
            bool isValid = true;

            string nameValue = departmentNameValue.Text;
            string locationValue = departmentLocationValue.Text;

            //6th parameter accepts values from "ValidationAllowedCharacters.SetAllowFunction" function
            //7th parameter accepts values from "ValidationRequiredCharacters.SetRequireFunction" function
            ValidationApprover.UserInputValidation(departmentNameValue, 5, 15, departmentNameInfoLabel, nameValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(departmentLocationValue, 5, 15, departmentLocationInfoLabel, locationValue, "LetterSpaceDash", "Letter");

            return isValid = ValidationApprover.GetIsValid();
        }
    }
}
