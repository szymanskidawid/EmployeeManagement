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
    public partial class CreateEditDepartmentForm : Form
    {
        public CreateEditDepartmentForm()
        {
            InitializeComponent();     
        }

        private void departmentSaveButton_Click(object sender, EventArgs e)
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
    }
}
