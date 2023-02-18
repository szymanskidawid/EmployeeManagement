namespace ProgramUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainEmployeeView = new System.Windows.Forms.DataGridView();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.createDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDepartmentView = new System.Windows.Forms.DataGridView();
            this.employeesButton = new System.Windows.Forms.Button();
            this.departmentsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainEmployeeView)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDepartmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainEmployeeView
            // 
            this.mainEmployeeView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mainEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainEmployeeView.Location = new System.Drawing.Point(143, 122);
            this.mainEmployeeView.Name = "mainEmployeeView";
            this.mainEmployeeView.RowTemplate.Height = 25;
            this.mainEmployeeView.Size = new System.Drawing.Size(1002, 481);
            this.mainEmployeeView.TabIndex = 0;
            // 
            // searchValue
            // 
            this.searchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchValue.Location = new System.Drawing.Point(855, 66);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(148, 23);
            this.searchValue.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(1027, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 39);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // toolStrip
            // 
            this.toolStrip.AllowDrop = true;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDropDown});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1273, 28);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // createDropDown
            // 
            this.createDropDown.AutoToolTip = false;
            this.createDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenuItem,
            this.departmentMenuItem});
            this.createDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDropDown.ForeColor = System.Drawing.SystemColors.Control;
            this.createDropDown.Image = ((System.Drawing.Image)(resources.GetObject("createDropDown.Image")));
            this.createDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createDropDown.Name = "createDropDown";
            this.createDropDown.Size = new System.Drawing.Size(77, 25);
            this.createDropDown.Text = "Create...";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(199, 26);
            this.employeeMenuItem.Text = "New Employee";
            this.employeeMenuItem.Click += new System.EventHandler(this.employeeMenuItem_Click);
            // 
            // departmentMenuItem
            // 
            this.departmentMenuItem.Name = "departmentMenuItem";
            this.departmentMenuItem.Size = new System.Drawing.Size(199, 26);
            this.departmentMenuItem.Text = "New Department";
            this.departmentMenuItem.Click += new System.EventHandler(this.departmentMenuItem_Click);
            // 
            // mainDepartmentView
            // 
            this.mainDepartmentView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainDepartmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDepartmentView.Location = new System.Drawing.Point(143, 122);
            this.mainDepartmentView.Name = "mainDepartmentView";
            this.mainDepartmentView.RowTemplate.Height = 25;
            this.mainDepartmentView.Size = new System.Drawing.Size(1002, 481);
            this.mainDepartmentView.TabIndex = 7;
            // 
            // employeesButton
            // 
            this.employeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.employeesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.employeesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.employeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.employeesButton.Location = new System.Drawing.Point(143, 83);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(165, 39);
            this.employeesButton.TabIndex = 8;
            this.employeesButton.Text = "Employees";
            this.employeesButton.UseVisualStyleBackColor = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // departmentsButton
            // 
            this.departmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.departmentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.departmentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.departmentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.departmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.departmentsButton.Location = new System.Drawing.Point(314, 83);
            this.departmentsButton.Name = "departmentsButton";
            this.departmentsButton.Size = new System.Drawing.Size(165, 39);
            this.departmentsButton.TabIndex = 9;
            this.departmentsButton.Text = "Departments";
            this.departmentsButton.UseVisualStyleBackColor = false;
            this.departmentsButton.Click += new System.EventHandler(this.departmentsButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1273, 664);
            this.Controls.Add(this.departmentsButton);
            this.Controls.Add(this.employeesButton);
            this.Controls.Add(this.mainDepartmentView);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.mainEmployeeView);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main View";
            ((System.ComponentModel.ISupportInitialize)(this.mainEmployeeView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDepartmentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchValue;
        private Button searchButton;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton createDropDown;
        private ToolStripMenuItem employeeMenuItem;
        private ToolStripMenuItem departmentMenuItem;
        private DataGridView mainEmployeeView;
        private DataGridView mainDepartmentView;
        private Button employeesButton;
        private Button departmentsButton;
    }
}