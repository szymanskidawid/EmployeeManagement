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
            this.Close();
        }
    }
}
