namespace ProgramUI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(261, 523);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(169, 88);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(141, 237);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(169, 45);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(149, 343);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(163, 45);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameValue
            // 
            this.usernameValue.BackColor = System.Drawing.SystemColors.Window;
            this.usernameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameValue.Location = new System.Drawing.Point(330, 248);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(211, 31);
            this.usernameValue.TabIndex = 3;
            // 
            // passwordValue
            // 
            this.passwordValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordValue.Location = new System.Drawing.Point(330, 358);
            this.passwordValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.PasswordChar = '*';
            this.passwordValue.Size = new System.Drawing.Size(211, 31);
            this.passwordValue.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(690, 682);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameValue;
        private TextBox passwordValue;
    }
}