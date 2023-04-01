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

        private bool DepartmentValidation()
        {
            bool result = true;

            string nameValue = departmentNameValue.Text;
            bool letDigSpaceDash = nameValue.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-');
            string locationValue = departmentLocationValue.Text;
            bool letSpaceDash = locationValue.All(c => Char.IsLetter(c) || c == ' ' || c == '-');


            if (departmentNameValue.Text.Length == 0 || departmentNameValue.Text.Length > 20 || !letDigSpaceDash)
            {
                result = false;
                departmentNameValue.BackColor = Color.Red;
                departmentNameError.Show();
            }

            else
            {
                departmentNameValue.BackColor = Color.White;
                departmentNameError.Hide();
            }

            if (departmentLocationValue.TextLength == 0 || departmentLocationValue.TextLength > 20 || !letSpaceDash)
            {
                result = false;
                departmentLocationValue.BackColor = Color.Red;
                departmentLocationError.Show();
            }

            else
            {
                departmentLocationValue.BackColor = Color.White;
                departmentLocationError.Hide();
            }

            return result;
        }
    }
}
