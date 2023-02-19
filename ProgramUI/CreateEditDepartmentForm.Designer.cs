namespace ProgramUI
{
    partial class CreateEditDepartmentForm
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
            this.departmentSaveButton = new System.Windows.Forms.Button();
            this.departmentSupervisorLabel = new System.Windows.Forms.Label();
            this.departmentLocationLabel = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.createEditDepartmentLabel = new System.Windows.Forms.Label();
            this.departmentLocationValue = new System.Windows.Forms.TextBox();
            this.departmentNameValue = new System.Windows.Forms.TextBox();
            this.departmentSupervisorDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // departmentSaveButton
            // 
            this.departmentSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.departmentSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.departmentSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.departmentSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.departmentSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentSaveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentSaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.departmentSaveButton.Location = new System.Drawing.Point(207, 237);
            this.departmentSaveButton.Name = "departmentSaveButton";
            this.departmentSaveButton.Size = new System.Drawing.Size(118, 53);
            this.departmentSaveButton.TabIndex = 39;
            this.departmentSaveButton.Text = "Save";
            this.departmentSaveButton.UseVisualStyleBackColor = false;
            // 
            // departmentSupervisorLabel
            // 
            this.departmentSupervisorLabel.AutoSize = true;
            this.departmentSupervisorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentSupervisorLabel.Location = new System.Drawing.Point(133, 162);
            this.departmentSupervisorLabel.Name = "departmentSupervisorLabel";
            this.departmentSupervisorLabel.Size = new System.Drawing.Size(118, 30);
            this.departmentSupervisorLabel.TabIndex = 33;
            this.departmentSupervisorLabel.Text = "Supervisor";
            // 
            // departmentLocationLabel
            // 
            this.departmentLocationLabel.AutoSize = true;
            this.departmentLocationLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLocationLabel.Location = new System.Drawing.Point(151, 118);
            this.departmentLocationLabel.Name = "departmentLocationLabel";
            this.departmentLocationLabel.Size = new System.Drawing.Size(98, 30);
            this.departmentLocationLabel.TabIndex = 32;
            this.departmentLocationLabel.Text = "Location";
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentNameLabel.Location = new System.Drawing.Point(54, 76);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(195, 30);
            this.departmentNameLabel.TabIndex = 31;
            this.departmentNameLabel.Text = "Department Name";
            // 
            // createEditDepartmentLabel
            // 
            this.createEditDepartmentLabel.AutoSize = true;
            this.createEditDepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createEditDepartmentLabel.Location = new System.Drawing.Point(12, 20);
            this.createEditDepartmentLabel.Name = "createEditDepartmentLabel";
            this.createEditDepartmentLabel.Size = new System.Drawing.Size(333, 37);
            this.createEditDepartmentLabel.TabIndex = 30;
            this.createEditDepartmentLabel.Text = "Create / Edit Department";
            // 
            // departmentLocationValue
            // 
            this.departmentLocationValue.BackColor = System.Drawing.SystemColors.Window;
            this.departmentLocationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentLocationValue.Location = new System.Drawing.Point(269, 123);
            this.departmentLocationValue.Name = "departmentLocationValue";
            this.departmentLocationValue.Size = new System.Drawing.Size(148, 23);
            this.departmentLocationValue.TabIndex = 23;
            // 
            // departmentNameValue
            // 
            this.departmentNameValue.BackColor = System.Drawing.SystemColors.Window;
            this.departmentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentNameValue.Location = new System.Drawing.Point(269, 81);
            this.departmentNameValue.Name = "departmentNameValue";
            this.departmentNameValue.Size = new System.Drawing.Size(148, 23);
            this.departmentNameValue.TabIndex = 22;
            // 
            // departmentSupervisorDropDown
            // 
            this.departmentSupervisorDropDown.FormattingEnabled = true;
            this.departmentSupervisorDropDown.Location = new System.Drawing.Point(269, 171);
            this.departmentSupervisorDropDown.Name = "departmentSupervisorDropDown";
            this.departmentSupervisorDropDown.Size = new System.Drawing.Size(121, 23);
            this.departmentSupervisorDropDown.TabIndex = 40;
            // 
            // CreateEditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(520, 349);
            this.Controls.Add(this.departmentSupervisorDropDown);
            this.Controls.Add(this.departmentSaveButton);
            this.Controls.Add(this.departmentSupervisorLabel);
            this.Controls.Add(this.departmentLocationLabel);
            this.Controls.Add(this.departmentNameLabel);
            this.Controls.Add(this.createEditDepartmentLabel);
            this.Controls.Add(this.departmentLocationValue);
            this.Controls.Add(this.departmentNameValue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateEditDepartmentForm";
            this.Text = "Create / Edit Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button departmentSaveButton;
        private Label departmentSupervisorLabel;
        private Label departmentLocationLabel;
        private Label departmentNameLabel;
        private Label createEditDepartmentLabel;
        private TextBox departmentLocationValue;
        private TextBox departmentNameValue;
        private ComboBox departmentSupervisorDropDown;
    }
}