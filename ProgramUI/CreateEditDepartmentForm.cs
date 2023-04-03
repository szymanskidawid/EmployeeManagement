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

namespace ProgramUI
{
    public partial class CreateEditDepartmentForm : Form
    {
        public CreateEditDepartmentForm()
        {
            InitializeComponent();     
        }

        //Save department using values in the form fields
        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            if (DepartmentValidation())
            {
                //Save/Edit department using values in the form fields
                SqlConnector.CreateDepartment(departmentNameValue.Text,
                    departmentLocationValue.Text);

                //Values will be set back to default after department is created/edited
                departmentNameValue.Text = "";
                departmentLocationValue.Text = "";
            
                //Closes the form
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid information provided, please check comments and try again.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Function responsible for validation of data provided by user.
        private bool DepartmentValidation()
        {
            bool isValid = true;

            string nameValue = departmentNameValue.Text;
            string locationValue = departmentLocationValue.Text;

            if (departmentNameValue.Text.Length == 0 || departmentNameValue.Text.Length > 20 || !ValidationHelper.AllowLetterDigitSpaceDash(nameValue))
            {
                isValid = false;
                ValidationHelper.SetTextboxState(departmentNameValue, departmentNameErrorLabel, true);
            }

            else
            {
                ValidationHelper.SetTextboxState(departmentNameValue, departmentNameErrorLabel, false);
            }

            if (departmentLocationValue.TextLength == 0 || departmentLocationValue.TextLength > 20 || !ValidationHelper.AllowLetterSpaceDash(locationValue))
            {
                isValid = false;
                ValidationHelper.SetTextboxState(departmentLocationValue, departmentLocationErrorLabel, true);
            }

            else
            {
                ValidationHelper.SetTextboxState(departmentLocationValue, departmentLocationErrorLabel, false);
            }

            //ValidationHelper.ValidAssist(departmentNameValue, 0, 20, departmentNameErrorLabel, nameValue, isValid);
            //ValidationHelper.ValidAssist(departmentLocationValue, 0, 20, departmentLocationErrorLabel, locationValue, isValid);

            return isValid;
        }    
    }
}
