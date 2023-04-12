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
            this.departmentLocationLabel = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.createEditDepartmentLabel = new System.Windows.Forms.Label();
            this.departmentLocationValue = new System.Windows.Forms.TextBox();
            this.departmentNameValue = new System.Windows.Forms.TextBox();
            this.departmentLocationErrorLabel = new System.Windows.Forms.Label();
            this.departmentNameErrorLabel = new System.Windows.Forms.Label();
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
            this.departmentSaveButton.Location = new System.Drawing.Point(295, 289);
            this.departmentSaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentSaveButton.Name = "departmentSaveButton";
            this.departmentSaveButton.Size = new System.Drawing.Size(169, 88);
            this.departmentSaveButton.TabIndex = 39;
            this.departmentSaveButton.Text = "Save";
            this.departmentSaveButton.UseVisualStyleBackColor = false;
            this.departmentSaveButton.Click += new System.EventHandler(this.departmentSaveButton_Click);
            // 
            // departmentLocationLabel
            // 
            this.departmentLocationLabel.AutoSize = true;
            this.departmentLocationLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLocationLabel.Location = new System.Drawing.Point(216, 197);
            this.departmentLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLocationLabel.Name = "departmentLocationLabel";
            this.departmentLocationLabel.Size = new System.Drawing.Size(148, 45);
            this.departmentLocationLabel.TabIndex = 32;
            this.departmentLocationLabel.Text = "Location";
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentNameLabel.Location = new System.Drawing.Point(77, 127);
            this.departmentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(298, 45);
            this.departmentNameLabel.TabIndex = 31;
            this.departmentNameLabel.Text = "Department Name";
            // 
            // createEditDepartmentLabel
            // 
            this.createEditDepartmentLabel.AutoSize = true;
            this.createEditDepartmentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createEditDepartmentLabel.Location = new System.Drawing.Point(17, 33);
            this.createEditDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createEditDepartmentLabel.Name = "createEditDepartmentLabel";
            this.createEditDepartmentLabel.Size = new System.Drawing.Size(501, 55);
            this.createEditDepartmentLabel.TabIndex = 30;
            this.createEditDepartmentLabel.Text = "Create / Edit Department";
            // 
            // departmentLocationValue
            // 
            this.departmentLocationValue.BackColor = System.Drawing.SystemColors.Window;
            this.departmentLocationValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentLocationValue.Location = new System.Drawing.Point(384, 205);
            this.departmentLocationValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentLocationValue.Name = "departmentLocationValue";
            this.departmentLocationValue.Size = new System.Drawing.Size(211, 31);
            this.departmentLocationValue.TabIndex = 23;
            // 
            // departmentNameValue
            // 
            this.departmentNameValue.BackColor = System.Drawing.SystemColors.Window;
            this.departmentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentNameValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.departmentNameValue.Location = new System.Drawing.Point(384, 135);
            this.departmentNameValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentNameValue.Name = "departmentNameValue";
            this.departmentNameValue.Size = new System.Drawing.Size(211, 31);
            this.departmentNameValue.TabIndex = 22;
            // 
            // departmentLocationErrorLabel
            // 
            this.departmentLocationErrorLabel.AutoSize = true;
            this.departmentLocationErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentLocationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.departmentLocationErrorLabel.Location = new System.Drawing.Point(384, 235);
            this.departmentLocationErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLocationErrorLabel.Name = "departmentLocationErrorLabel";
            this.departmentLocationErrorLabel.Size = new System.Drawing.Size(264, 21);
            this.departmentLocationErrorLabel.TabIndex = 40;
            this.departmentLocationErrorLabel.Text = "Max 20 chars (letters, spaces and \"-\")";
            this.departmentLocationErrorLabel.Visible = false;
            // 
            // departmentNameErrorLabel
            // 
            this.departmentNameErrorLabel.AutoSize = true;
            this.departmentNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.departmentNameErrorLabel.Location = new System.Drawing.Point(384, 167);
            this.departmentNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentNameErrorLabel.Name = "departmentNameErrorLabel";
            this.departmentNameErrorLabel.Size = new System.Drawing.Size(309, 21);
            this.departmentNameErrorLabel.TabIndex = 41;
            this.departmentNameErrorLabel.Text = "Max 20 chars (letters, digits, spaces and \"-\")";
            this.departmentNameErrorLabel.Visible = false;
            // 
            // CreateEditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.departmentNameErrorLabel);
            this.Controls.Add(this.departmentLocationErrorLabel);
            this.Controls.Add(this.departmentSaveButton);
            this.Controls.Add(this.departmentLocationLabel);
            this.Controls.Add(this.departmentNameLabel);
            this.Controls.Add(this.createEditDepartmentLabel);
            this.Controls.Add(this.departmentLocationValue);
            this.Controls.Add(this.departmentNameValue);
            this.Name = "CreateEditDepartmentForm";
            this.Text = "Create / Edit Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button departmentSaveButton;
        private Label departmentLocationLabel;
        private Label departmentNameLabel;
        private Label createEditDepartmentLabel;
        private TextBox departmentLocationValue;
        private TextBox departmentNameValue;
        private Label departmentLocationErrorLabel;
        private Label departmentNameErrorLabel;
    }
}