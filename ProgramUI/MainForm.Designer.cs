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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainEmployeeView = new System.Windows.Forms.DataGridView();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripCreateDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.createEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDepartmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJobTitleManuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainEmployeeView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainEmployeeView
            // 
            this.mainEmployeeView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mainEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainEmployeeView.DefaultCellStyle = dataGridViewCellStyle1;
            this.mainEmployeeView.Location = new System.Drawing.Point(204, 203);
            this.mainEmployeeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainEmployeeView.Name = "mainEmployeeView";
            this.mainEmployeeView.RowHeadersWidth = 62;
            this.mainEmployeeView.RowTemplate.Height = 25;
            this.mainEmployeeView.Size = new System.Drawing.Size(1431, 802);
            this.mainEmployeeView.TabIndex = 0;
            // 
            // searchValue
            // 
            this.searchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchValue.Location = new System.Drawing.Point(1221, 110);
            this.searchValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(211, 31);
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
            this.searchButton.Location = new System.Drawing.Point(1467, 97);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(169, 65);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AllowDrop = true;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreateDropDown,
            this.toolStripEditButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1819, 41);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripCreateDropDown
            // 
            this.toolStripCreateDropDown.AutoToolTip = false;
            this.toolStripCreateDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCreateDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeMenuItem,
            this.createDepartmentMenuItem,
            this.createJobTitleManuItem});
            this.toolStripCreateDropDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripCreateDropDown.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripCreateDropDown.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCreateDropDown.Image")));
            this.toolStripCreateDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCreateDropDown.Name = "toolStripCreateDropDown";
            this.toolStripCreateDropDown.Size = new System.Drawing.Size(122, 36);
            this.toolStripCreateDropDown.Text = "Create...";
            // 
            // createEmployeeMenuItem
            // 
            this.createEmployeeMenuItem.Name = "createEmployeeMenuItem";
            this.createEmployeeMenuItem.Size = new System.Drawing.Size(307, 40);
            this.createEmployeeMenuItem.Text = "New Employee";
            this.createEmployeeMenuItem.Click += new System.EventHandler(this.createEmployeeMenuItem_Click);
            // 
            // createDepartmentMenuItem
            // 
            this.createDepartmentMenuItem.Name = "createDepartmentMenuItem";
            this.createDepartmentMenuItem.Size = new System.Drawing.Size(307, 40);
            this.createDepartmentMenuItem.Text = "New Department";
            this.createDepartmentMenuItem.Click += new System.EventHandler(this.createDepartmentMenuItem_Click);
            // 
            // createJobTitleManuItem
            // 
            this.createJobTitleManuItem.Name = "createJobTitleManuItem";
            this.createJobTitleManuItem.Size = new System.Drawing.Size(307, 40);
            this.createJobTitleManuItem.Text = "New Job Title";
            this.createJobTitleManuItem.Click += new System.EventHandler(this.createJobTitleManuItem_Click);
            // 
            // toolStripEditButton
            // 
            this.toolStripEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripEditButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditButton.Image")));
            this.toolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditButton.Name = "toolStripEditButton";
            this.toolStripEditButton.Size = new System.Drawing.Size(59, 36);
            this.toolStripEditButton.Text = "Edit";
            this.toolStripEditButton.Click += new System.EventHandler(this.toolStripEditButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1819, 1107);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchValue);
            this.Controls.Add(this.mainEmployeeView);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MainForm";
            this.Text = "Main View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mainEmployeeView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchValue;
        private Button searchButton;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripCreateDropDown;
        private ToolStripMenuItem createEmployeeMenuItem;
        private ToolStripMenuItem createDepartmentMenuItem;
        private DataGridView mainEmployeeView;
        private ToolStripMenuItem createJobTitleManuItem;
        private ToolStripButton toolStripEditButton;
    }
}