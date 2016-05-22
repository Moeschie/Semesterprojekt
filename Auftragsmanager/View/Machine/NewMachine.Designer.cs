namespace View
{
    partial class NewMachine
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
            this.NewMashineTable1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewMashineTable2 = new System.Windows.Forms.TableLayoutPanel();
            this.NewMashineNameTextBox = new System.Windows.Forms.TextBox();
            this.NewMashineNameLabel = new System.Windows.Forms.Label();
            this.AddNewMashineButton = new System.Windows.Forms.Button();
            this.NewMashineTable1.SuspendLayout();
            this.NewMashineTable2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewMashineTable1
            // 
            this.NewMashineTable1.ColumnCount = 1;
            this.NewMashineTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewMashineTable1.Controls.Add(this.NewMashineTable2, 0, 0);
            this.NewMashineTable1.Controls.Add(this.AddNewMashineButton, 0, 1);
            this.NewMashineTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewMashineTable1.Location = new System.Drawing.Point(0, 0);
            this.NewMashineTable1.Name = "NewMashineTable1";
            this.NewMashineTable1.RowCount = 2;
            this.NewMashineTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewMashineTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.NewMashineTable1.Size = new System.Drawing.Size(257, 63);
            this.NewMashineTable1.TabIndex = 0;
            // 
            // NewMashineTable2
            // 
            this.NewMashineTable2.ColumnCount = 2;
            this.NewMashineTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.84064F));
            this.NewMashineTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.15936F));
            this.NewMashineTable2.Controls.Add(this.NewMashineNameTextBox, 1, 0);
            this.NewMashineTable2.Controls.Add(this.NewMashineNameLabel, 0, 0);
            this.NewMashineTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewMashineTable2.Location = new System.Drawing.Point(3, 3);
            this.NewMashineTable2.Name = "NewMashineTable2";
            this.NewMashineTable2.RowCount = 1;
            this.NewMashineTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewMashineTable2.Size = new System.Drawing.Size(251, 26);
            this.NewMashineTable2.TabIndex = 0;
            // 
            // NewMashineNameTextBox
            // 
            this.NewMashineNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewMashineNameTextBox.Location = new System.Drawing.Point(103, 3);
            this.NewMashineNameTextBox.Name = "NewMashineNameTextBox";
            this.NewMashineNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NewMashineNameTextBox.TabIndex = 0;
            // 
            // NewMashineNameLabel
            // 
            this.NewMashineNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewMashineNameLabel.AutoSize = true;
            this.NewMashineNameLabel.Location = new System.Drawing.Point(3, 6);
            this.NewMashineNameLabel.Name = "NewMashineNameLabel";
            this.NewMashineNameLabel.Size = new System.Drawing.Size(94, 13);
            this.NewMashineNameLabel.TabIndex = 1;
            this.NewMashineNameLabel.Text = "Maschinenname *";
            // 
            // AddNewMashineButton
            // 
            this.AddNewMashineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewMashineButton.Location = new System.Drawing.Point(179, 35);
            this.AddNewMashineButton.Name = "AddNewMashineButton";
            this.AddNewMashineButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMashineButton.TabIndex = 1;
            this.AddNewMashineButton.Text = "Anlegen";
            this.AddNewMashineButton.UseVisualStyleBackColor = true;
            this.AddNewMashineButton.Click += new System.EventHandler(this.AddNewMashineButton_Click);
            // 
            // NewMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 63);
            this.Controls.Add(this.NewMashineTable1);
            this.Name = "NewMachine";
            this.Text = "NewMachine";
            this.NewMashineTable1.ResumeLayout(false);
            this.NewMashineTable2.ResumeLayout(false);
            this.NewMashineTable2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel NewMashineTable1;
        private System.Windows.Forms.TableLayoutPanel NewMashineTable2;
        private System.Windows.Forms.TextBox NewMashineNameTextBox;
        private System.Windows.Forms.Label NewMashineNameLabel;
        private System.Windows.Forms.Button AddNewMashineButton;
    }
}