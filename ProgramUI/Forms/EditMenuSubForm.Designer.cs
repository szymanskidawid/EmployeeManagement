namespace ProgramUI
{
    partial class EditMenuSubForm
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
            this.editMenuSubFormLabel = new System.Windows.Forms.Label();
            this.editMenuButton = new System.Windows.Forms.Button();
            this.editListBox = new System.Windows.Forms.ListBox();
            this.editCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.editCategoryLabel = new System.Windows.Forms.Label();
            this.deleteMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editMenuSubFormLabel
            // 
            this.editMenuSubFormLabel.AutoSize = true;
            this.editMenuSubFormLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.editMenuSubFormLabel.Location = new System.Drawing.Point(47, 40);
            this.editMenuSubFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editMenuSubFormLabel.Name = "editMenuSubFormLabel";
            this.editMenuSubFormLabel.Size = new System.Drawing.Size(216, 55);
            this.editMenuSubFormLabel.TabIndex = 13;
            this.editMenuSubFormLabel.Text = "Edit Menu";
            // 
            // editMenuButton
            // 
            this.editMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.editMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.editMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.editMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.editMenuButton.Location = new System.Drawing.Point(110, 702);
            this.editMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editMenuButton.Name = "editMenuButton";
            this.editMenuButton.Size = new System.Drawing.Size(169, 88);
            this.editMenuButton.TabIndex = 29;
            this.editMenuButton.Text = "Edit";
            this.editMenuButton.UseVisualStyleBackColor = false;
            this.editMenuButton.Click += new System.EventHandler(this.editMenuButton_Click);
            // 
            // editListBox
            // 
            this.editListBox.FormattingEnabled = true;
            this.editListBox.ItemHeight = 25;
            this.editListBox.Location = new System.Drawing.Point(161, 237);
            this.editListBox.Name = "editListBox";
            this.editListBox.Size = new System.Drawing.Size(420, 429);
            this.editListBox.TabIndex = 30;
            // 
            // editCategoryDropDown
            // 
            this.editCategoryDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoryDropDown.FormattingEnabled = true;
            this.editCategoryDropDown.Location = new System.Drawing.Point(319, 148);
            this.editCategoryDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editCategoryDropDown.Name = "editCategoryDropDown";
            this.editCategoryDropDown.Size = new System.Drawing.Size(262, 33);
            this.editCategoryDropDown.TabIndex = 32;
            this.editCategoryDropDown.SelectedIndexChanged += new System.EventHandler(this.editCategoryDropDown_SelectedIndexChanged);
            // 
            // editCategoryLabel
            // 
            this.editCategoryLabel.AutoSize = true;
            this.editCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editCategoryLabel.Location = new System.Drawing.Point(161, 139);
            this.editCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editCategoryLabel.Name = "editCategoryLabel";
            this.editCategoryLabel.Size = new System.Drawing.Size(157, 45);
            this.editCategoryLabel.TabIndex = 31;
            this.editCategoryLabel.Text = "Category";
            // 
            // deleteMenuButton
            // 
            this.deleteMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deleteMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.deleteMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteMenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteMenuButton.Location = new System.Drawing.Point(454, 702);
            this.deleteMenuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteMenuButton.Name = "deleteMenuButton";
            this.deleteMenuButton.Size = new System.Drawing.Size(169, 88);
            this.deleteMenuButton.TabIndex = 33;
            this.deleteMenuButton.Text = "Delete";
            this.deleteMenuButton.UseVisualStyleBackColor = false;
            this.deleteMenuButton.Click += new System.EventHandler(this.deleteMenuButton_Click);
            // 
            // EditMenuSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(736, 828);
            this.Controls.Add(this.deleteMenuButton);
            this.Controls.Add(this.editCategoryDropDown);
            this.Controls.Add(this.editCategoryLabel);
            this.Controls.Add(this.editListBox);
            this.Controls.Add(this.editMenuButton);
            this.Controls.Add(this.editMenuSubFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EditMenuSubForm";
            this.Text = "Edit / Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label editMenuSubFormLabel;
        private Button editMenuButton;
        private ListBox editListBox;
        private ComboBox editCategoryDropDown;
        private Label editCategoryLabel;
        private Button deleteMenuButton;
    }
}