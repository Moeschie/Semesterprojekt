namespace View
{
    partial class LoginFrame
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LoginNameInput = new System.Windows.Forms.TextBox();
            this.LoginPasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoginTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(18, 7);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(78, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Benutzername:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(43, 34);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Passwort:";
            // 
            // LoginNameInput
            // 
            this.LoginNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginNameInput.Location = new System.Drawing.Point(102, 3);
            this.LoginNameInput.Name = "LoginNameInput";
            this.LoginNameInput.Size = new System.Drawing.Size(115, 20);
            this.LoginNameInput.TabIndex = 2;
            // 
            // LoginPasswordInput
            // 
            this.LoginPasswordInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginPasswordInput.Location = new System.Drawing.Point(102, 30);
            this.LoginPasswordInput.Name = "LoginPasswordInput";
            this.LoginPasswordInput.Size = new System.Drawing.Size(115, 20);
            this.LoginPasswordInput.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(102, 57);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(115, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginTableLayout
            // 
            this.LoginTableLayout.ColumnCount = 2;
            this.LoginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.LoginTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.LoginTableLayout.Controls.Add(this.usernameLabel, 0, 0);
            this.LoginTableLayout.Controls.Add(this.LoginNameInput, 1, 0);
            this.LoginTableLayout.Controls.Add(this.LoginPasswordInput, 1, 1);
            this.LoginTableLayout.Controls.Add(this.passwordLabel, 0, 1);
            this.LoginTableLayout.Controls.Add(this.LoginButton, 1, 2);
            this.LoginTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTableLayout.Location = new System.Drawing.Point(0, 0);
            this.LoginTableLayout.Name = "LoginTableLayout";
            this.LoginTableLayout.RowCount = 3;
            this.LoginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LoginTableLayout.Size = new System.Drawing.Size(220, 83);
            this.LoginTableLayout.TabIndex = 5;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 83);
            this.Controls.Add(this.LoginTableLayout);
            this.Name = "LoginFrame";
            this.Text = "Auftragsmanager";
            this.LoginTableLayout.ResumeLayout(false);
            this.LoginTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox LoginNameInput;
        private System.Windows.Forms.TextBox LoginPasswordInput;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TableLayoutPanel LoginTableLayout;
    }
}