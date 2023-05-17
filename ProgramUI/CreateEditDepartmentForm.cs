using ProgramLibrary;
using ProgramLibrary.Models;
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
        //Gets a value of a chosen department from EditMenuSubForm.
        private DepartmentModel loadedDepartment = EditMenuSubForm.GetSelectedDepartment();

        public CreateEditDepartmentForm()
        {
            InitializeComponent();

            //This code will load an existing department ONLY if user accesses Edit mode.
            if (loadedDepartment != null)
            {
                LoadDepartment(loadedDepartment);
            }
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
                if (!EditMenuSubForm.GetEditState())
                {
                    //Save department using values in the form fields.
                    SqlConnector.CreateDepartment(departmentNameValue.Text,
                        departmentLocationValue.Text); 
                }

                else
                {
                    //Edit department using values in the form fields.
                    SqlConnector.EditDepartment(loadedDepartment.Id, departmentNameValue.Text,
                        departmentLocationValue.Text);
                }

                ResetDepartmentFormValues();

                //loadedDepartment = null; //Sets value back to null so that this IF does not trigger automatically when form is opened again.

                EditMenuSubForm.SetEditState(false); //Sets Edit state back to false as we want Create state to be default.

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
        private void ResetDepartmentFormValues()
        { 
            departmentNameValue.Text = "";
            departmentLocationValue.Text = "";
        }

        //Function responsible for validating the form.
        private bool DepartmentFormValidation()
        {
            bool isValid = true;

            string nameValue = departmentNameValue.Text;
            string locationValue = departmentLocationValue.Text;

            //6th parameter accepts values from "ValidationAllowedCharacters.SetAllowFunction" function
            //7th parameter accepts values from "ValidationRequiredCharacters.SetRequireFunction" function
            ValidationApprover.UserInputValidation(departmentNameValue, 5, 20, departmentNameInfoLabel, nameValue, "LetterDigitSpaceDash", "Letter");
            ValidationApprover.UserInputValidation(departmentLocationValue, 5, 15, departmentLocationInfoLabel, locationValue, "LetterSpaceDash", "Letter");

            return isValid = ValidationApprover.GetIsValid();
        }

        //Loads a department into fields when Edit is chosen.
        private void LoadDepartment(DepartmentModel model)
        {
            departmentIdValue.Text = model.Id.ToString();
            departmentNameValue.Text = model.DepartmentName;
            departmentLocationValue.Text = model.DepartmentLocation;
        }
    }
}
