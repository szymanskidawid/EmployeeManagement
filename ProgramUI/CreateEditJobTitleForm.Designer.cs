namespace ProgramUI
{
    partial class CreateEditJobTitleForm
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
            this.jobTitleSaveButton = new System.Windows.Forms.Button();
            this.jobTitleDepartmentLabel = new System.Windows.Forms.Label();
            this.jobTitleNameLabel = new System.Windows.Forms.Label();
            this.createEditJobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleNameValue = new System.Windows.Forms.TextBox();
            this.departmentSupervisorLabel = new System.Windows.Forms.Label();
            this.jobTitleSupervisorDropDown = new System.Windows.Forms.ComboBox();
            this.jobTitleDepartmentDropDown = new System.Windows.Forms.ComboBox();
            this.jobTitleNameInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobTitleSaveButton
            // 
            this.jobTitleSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.jobTitleSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.jobTitleSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.jobTitleSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.jobTitleSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobTitleSaveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitleSaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.jobTitleSaveButton.Location = new System.Drawing.Point(288, 407);
            this.jobTitleSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobTitleSaveButton.Name = "jobTitleSaveButton";
            this.jobTitleSaveButton.Size = new System.Drawing.Size(169, 88);
            this.jobTitleSaveButton.TabIndex = 47;
            this.jobTitleSaveButton.Text = "Save";
            this.jobTitleSaveButton.UseVisualStyleBackColor = false;
            this.jobTitleSaveButton.Click += new System.EventHandler(this.jobTitleSaveButton_Click);
            // 
            // jobTitleDepartmentLabel
            // 
            this.jobTitleDepartmentLabel.AutoSize = true;
            this.jobTitleDepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitleDepartmentLabel.Location = new System.Drawing.Point(150, 232);
            this.jobTitleDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobTitleDepartmentLabel.Name = "jobTitleDepartmentLabel";
            this.jobTitleDepartmentLabel.Size = new System.Drawing.Size(201, 45);
            this.jobTitleDepartmentLabel.TabIndex = 45;
            this.jobTitleDepartmentLabel.Text = "Department";
            // 
            // jobTitleNameLabel
            // 
            this.jobTitleNameLabel.AutoSize = true;
            this.jobTitleNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitleNameLabel.Location = new System.Drawing.Point(235, 140);
            this.jobTitleNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobTitleNameLabel.Name = "jobTitleNameLabel";
            this.jobTitleNameLabel.Size = new System.Drawing.Size(108, 45);
            this.jobTitleNameLabel.TabIndex = 44;
            this.jobTitleNameLabel.Text = "Name";
            // 
            // createEditJobTitleLabel
            // 
            this.createEditJobTitleLabel.AutoSize = true;
            this.createEditJobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createEditJobTitleLabel.Location = new System.Drawing.Point(17, 43);
            this.createEditJobTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createEditJobTitleLabel.Name = "createEditJobTitleLabel";
            this.createEditJobTitleLabel.Size = new System.Drawing.Size(435, 55);
            this.createEditJobTitleLabel.TabIndex = 43;
            this.createEditJobTitleLabel.Text = "Create / Edit Job Title";
            // 
            // jobTitleNameValue
            // 
            this.jobTitleNameValue.BackColor = System.Drawing.SystemColors.Window;
            this.jobTitleNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobTitleNameValue.Location = new System.Drawing.Point(368, 152);
            this.jobTitleNameValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobTitleNameValue.Name = "jobTitleNameValue";
            this.jobTitleNameValue.Size = new System.Drawing.Size(276, 31);
            this.jobTitleNameValue.TabIndex = 41;
            this.jobTitleNameValue.TextChanged += new System.EventHandler(this.JobTitle_TextChanged);
            // 
            // departmentSupervisorLabel
            // 
            this.departmentSupervisorLabel.AutoSize = true;
            this.departmentSupervisorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentSupervisorLabel.Location = new System.Drawing.Point(168, 305);
            this.departmentSupervisorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentSupervisorLabel.Name = "departmentSupervisorLabel";
            this.departmentSupervisorLabel.Size = new System.Drawing.Size(181, 45);
            this.departmentSupervisorLabel.TabIndex = 48;
            this.departmentSupervisorLabel.Text = "Supervisor";
            // 
            // jobTitleSupervisorDropDown
            // 
            this.jobTitleSupervisorDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobTitleSupervisorDropDown.FormattingEnabled = true;
            this.jobTitleSupervisorDropDown.Location = new System.Drawing.Point(368, 317);
            this.jobTitleSupervisorDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobTitleSupervisorDropDown.Name = "jobTitleSupervisorDropDown";
            this.jobTitleSupervisorDropDown.Size = new System.Drawing.Size(171, 33);
            this.jobTitleSupervisorDropDown.TabIndex = 49;
            // 
            // jobTitleDepartmentDropDown
            // 
            this.jobTitleDepartmentDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobTitleDepartmentDropDown.FormattingEnabled = true;
            this.jobTitleDepartmentDropDown.Location = new System.Drawing.Point(368, 244);
            this.jobTitleDepartmentDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobTitleDepartmentDropDown.Name = "jobTitleDepartmentDropDown";
            this.jobTitleDepartmentDropDown.Size = new System.Drawing.Size(171, 33);
            this.jobTitleDepartmentDropDown.TabIndex = 50;
            // 
            // jobTitleNameInfoLabel
            // 
            this.jobTitleNameInfoLabel.AutoSize = true;
            this.jobTitleNameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jobTitleNameInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.jobTitleNameInfoLabel.Location = new System.Drawing.Point(368, 188);
            this.jobTitleNameInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobTitleNameInfoLabel.Name = "jobTitleNameInfoLabel";
            this.jobTitleNameInfoLabel.Size = new System.Drawing.Size(341, 42);
            this.jobTitleNameInfoLabel.TabIndex = 51;
            this.jobTitleNameInfoLabel.Text = "5-15 characters (letters, digits, spaces and \"-\")\r\nRequire at least one letter\r\n";
            // 
            // CreateEditJobTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(736, 540);
            this.Controls.Add(this.jobTitleNameInfoLabel);
            this.Controls.Add(this.jobTitleDepartmentDropDown);
            this.Controls.Add(this.jobTitleSupervisorDropDown);
            this.Controls.Add(this.departmentSupervisorLabel);
            this.Controls.Add(this.jobTitleSaveButton);
            this.Controls.Add(this.jobTitleDepartmentLabel);
            this.Controls.Add(this.jobTitleNameLabel);
            this.Controls.Add(this.createEditJobTitleLabel);
            this.Controls.Add(this.jobTitleNameValue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateEditJobTitleForm";
            this.Text = "CreateEditJobTitleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button jobTitleSaveButton;
        private Label jobTitleDepartmentLabel;
        private Label jobTitleNameLabel;
        private Label createEditJobTitleLabel;
        private TextBox jobTitleNameValue;
        private Label departmentSupervisorLabel;
        private ComboBox jobTitleSupervisorDropDown;
        private ComboBox jobTitleDepartmentDropDown;
        private Label jobTitleNameInfoLabel;
    }
}