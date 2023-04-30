﻿namespace ProgramUI
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
            this.departmentLocationInfoLabel = new System.Windows.Forms.Label();
            this.departmentNameInfoLabel = new System.Windows.Forms.Label();
            this.departmentIdValue = new System.Windows.Forms.Label();
            this.departmentIdLabel = new System.Windows.Forms.Label();
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
            this.departmentSaveButton.Location = new System.Drawing.Point(297, 411);
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
            this.departmentLocationLabel.Location = new System.Drawing.Point(211, 302);
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
            this.departmentNameLabel.Location = new System.Drawing.Point(70, 213);
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
            this.departmentLocationValue.Location = new System.Drawing.Point(379, 310);
            this.departmentLocationValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentLocationValue.Name = "departmentLocationValue";
            this.departmentLocationValue.Size = new System.Drawing.Size(280, 31);
            this.departmentLocationValue.TabIndex = 23;
            this.departmentLocationValue.TextChanged += new System.EventHandler(this.Department_TextChanged);
            // 
            // departmentNameValue
            // 
            this.departmentNameValue.BackColor = System.Drawing.SystemColors.Window;
            this.departmentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentNameValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.departmentNameValue.Location = new System.Drawing.Point(377, 221);
            this.departmentNameValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentNameValue.Name = "departmentNameValue";
            this.departmentNameValue.Size = new System.Drawing.Size(280, 31);
            this.departmentNameValue.TabIndex = 22;
            this.departmentNameValue.TextChanged += new System.EventHandler(this.Department_TextChanged);
            // 
            // departmentLocationInfoLabel
            // 
            this.departmentLocationInfoLabel.AutoSize = true;
            this.departmentLocationInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLocationInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.departmentLocationInfoLabel.Location = new System.Drawing.Point(379, 340);
            this.departmentLocationInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLocationInfoLabel.Name = "departmentLocationInfoLabel";
            this.departmentLocationInfoLabel.Size = new System.Drawing.Size(292, 42);
            this.departmentLocationInfoLabel.TabIndex = 40;
            this.departmentLocationInfoLabel.Text = "5-15 characters (letters, spaces and \"-\")\r\nRequire at least one letter";
            // 
            // departmentNameInfoLabel
            // 
            this.departmentNameInfoLabel.AutoSize = true;
            this.departmentNameInfoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentNameInfoLabel.ForeColor = System.Drawing.Color.Black;
            this.departmentNameInfoLabel.Location = new System.Drawing.Point(377, 253);
            this.departmentNameInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentNameInfoLabel.Name = "departmentNameInfoLabel";
            this.departmentNameInfoLabel.Size = new System.Drawing.Size(341, 42);
            this.departmentNameInfoLabel.TabIndex = 41;
            this.departmentNameInfoLabel.Text = "5-15 characters (letters, digits, spaces and \"-\")\r\nRequire at least one letter\r\n";
            // 
            // departmentIdValue
            // 
            this.departmentIdValue.AutoSize = true;
            this.departmentIdValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentIdValue.ForeColor = System.Drawing.Color.DarkRed;
            this.departmentIdValue.Location = new System.Drawing.Point(455, 114);
            this.departmentIdValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentIdValue.Name = "departmentIdValue";
            this.departmentIdValue.Size = new System.Drawing.Size(0, 45);
            this.departmentIdValue.TabIndex = 64;
            // 
            // departmentIdLabel
            // 
            this.departmentIdLabel.AutoSize = true;
            this.departmentIdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentIdLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.departmentIdLabel.Location = new System.Drawing.Point(189, 114);
            this.departmentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentIdLabel.Name = "departmentIdLabel";
            this.departmentIdLabel.Size = new System.Drawing.Size(262, 45);
            this.departmentIdLabel.TabIndex = 63;
            this.departmentIdLabel.Text = "Department ID: ";
            // 
            // CreateEditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(743, 594);
            this.Controls.Add(this.departmentIdValue);
            this.Controls.Add(this.departmentIdLabel);
            this.Controls.Add(this.departmentNameInfoLabel);
            this.Controls.Add(this.departmentLocationInfoLabel);
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
        private Label departmentLocationInfoLabel;
        private Label departmentNameInfoLabel;
        private Label departmentIdValue;
        private Label departmentIdLabel;
    }
}