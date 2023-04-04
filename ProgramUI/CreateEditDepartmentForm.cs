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
                ValidationHelper.SetValidationState(true);
            }
        }

        //Function responsible for validating the form.
        private bool DepartmentFormValidation()
        {
            bool isValid = true;

            string nameValue = departmentNameValue.Text;
            string locationValue = departmentLocationValue.Text;
           

            ValidationHelper.UserInputValidation(departmentNameValue, 0, 20, departmentNameErrorLabel, nameValue);
            ValidationHelper.UserInputValidation(departmentLocationValue, 0, 20, departmentLocationErrorLabel, locationValue);


            return isValid = ValidationHelper.GetValidationState();
        }
    }
}
