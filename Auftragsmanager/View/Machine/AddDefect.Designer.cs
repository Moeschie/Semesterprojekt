namespace View
{ 
    partial class AddDefect
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
            this.AddDefectTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddDefectSelectLable = new System.Windows.Forms.Label();
            this.AddDefectStartDateLabel = new System.Windows.Forms.Label();
            this.AddDefektEndDateLable = new System.Windows.Forms.Label();
            this.AddDefectSelectMashineComboBox = new System.Windows.Forms.ComboBox();
            this.AddDefectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddDefectEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddDefectSubmitButton = new System.Windows.Forms.Button();
            this.AddDefectTitleLabel = new System.Windows.Forms.Label();
            this.AddDefectTitleTextBox = new System.Windows.Forms.TextBox();
            this.AddDefectTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDefectTable
            // 
            this.AddDefectTable.ColumnCount = 2;
            this.AddDefectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.80282F));
            this.AddDefectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.19718F));
            this.AddDefectTable.Controls.Add(this.AddDefectSelectLable, 0, 0);
            this.AddDefectTable.Controls.Add(this.AddDefectSelectMashineComboBox, 1, 0);
            this.AddDefectTable.Controls.Add(this.AddDefectSubmitButton, 1, 4);
            this.AddDefectTable.Controls.Add(this.AddDefektEndDateLable, 0, 3);
            this.AddDefectTable.Controls.Add(this.AddDefectEndDateTimePicker, 1, 3);
            this.AddDefectTable.Controls.Add(this.AddDefectStartDateLabel, 0, 2);
            this.AddDefectTable.Controls.Add(this.AddDefectStartDateTimePicker, 1, 2);
            this.AddDefectTable.Controls.Add(this.AddDefectTitleLabel, 0, 1);
            this.AddDefectTable.Controls.Add(this.AddDefectTitleTextBox, 1, 1);
            this.AddDefectTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDefectTable.Location = new System.Drawing.Point(0, 0);
            this.AddDefectTable.Name = "AddDefectTable";
            this.AddDefectTable.RowCount = 5;
            this.AddDefectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909F));
            this.AddDefectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091F));
            this.AddDefectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.AddDefectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.AddDefectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.AddDefectTable.Size = new System.Drawing.Size(284, 130);
            this.AddDefectTable.TabIndex = 0;
            // 
            // AddDefectSelectLable
            // 
            this.AddDefectSelectLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefectSelectLable.AutoSize = true;
            this.AddDefectSelectLable.Location = new System.Drawing.Point(3, 7);
            this.AddDefectSelectLable.Name = "AddDefectSelectLable";
            this.AddDefectSelectLable.Size = new System.Drawing.Size(90, 13);
            this.AddDefectSelectLable.TabIndex = 0;
            this.AddDefectSelectLable.Text = "Maschine";
            // 
            // AddDefectStartDateLabel
            // 
            this.AddDefectStartDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefectStartDateLabel.AutoSize = true;
            this.AddDefectStartDateLabel.Location = new System.Drawing.Point(3, 59);
            this.AddDefectStartDateLabel.Name = "AddDefectStartDateLabel";
            this.AddDefectStartDateLabel.Size = new System.Drawing.Size(90, 13);
            this.AddDefectStartDateLabel.TabIndex = 1;
            this.AddDefectStartDateLabel.Text = "Begin";
            // 
            // AddDefektEndDateLable
            // 
            this.AddDefektEndDateLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefektEndDateLable.AutoSize = true;
            this.AddDefektEndDateLable.Location = new System.Drawing.Point(3, 84);
            this.AddDefektEndDateLable.Name = "AddDefektEndDateLable";
            this.AddDefektEndDateLable.Size = new System.Drawing.Size(90, 13);
            this.AddDefektEndDateLable.TabIndex = 2;
            this.AddDefektEndDateLable.Text = "Ende";
            // 
            // AddDefectSelectMashineComboBox
            // 
            this.AddDefectSelectMashineComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDefectSelectMashineComboBox.FormattingEnabled = true;
            this.AddDefectSelectMashineComboBox.Location = new System.Drawing.Point(99, 3);
            this.AddDefectSelectMashineComboBox.Name = "AddDefectSelectMashineComboBox";
            this.AddDefectSelectMashineComboBox.Size = new System.Drawing.Size(182, 21);
            this.AddDefectSelectMashineComboBox.TabIndex = 4;
            // 
            // AddDefectStartDateTimePicker
            // 
            this.AddDefectStartDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDefectStartDateTimePicker.Location = new System.Drawing.Point(99, 56);
            this.AddDefectStartDateTimePicker.Name = "AddDefectStartDateTimePicker";
            this.AddDefectStartDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.AddDefectStartDateTimePicker.TabIndex = 5;
            // 
            // AddDefectEndDateTimePicker
            // 
            this.AddDefectEndDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefectEndDateTimePicker.Location = new System.Drawing.Point(99, 81);
            this.AddDefectEndDateTimePicker.Name = "AddDefectEndDateTimePicker";
            this.AddDefectEndDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.AddDefectEndDateTimePicker.TabIndex = 6;
            // 
            // AddDefectSubmitButton
            // 
            this.AddDefectSubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefectSubmitButton.Location = new System.Drawing.Point(206, 106);
            this.AddDefectSubmitButton.Name = "AddDefectSubmitButton";
            this.AddDefectSubmitButton.Size = new System.Drawing.Size(75, 21);
            this.AddDefectSubmitButton.TabIndex = 8;
            this.AddDefectSubmitButton.Text = "Erstellen";
            this.AddDefectSubmitButton.UseVisualStyleBackColor = true;
            this.AddDefectSubmitButton.Click += new System.EventHandler(this.AddDefectSubmitButton_Click);
            // 
            // AddDefectTitleLabel
            // 
            this.AddDefectTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDefectTitleLabel.AutoSize = true;
            this.AddDefectTitleLabel.Location = new System.Drawing.Point(3, 33);
            this.AddDefectTitleLabel.Name = "AddDefectTitleLabel";
            this.AddDefectTitleLabel.Size = new System.Drawing.Size(90, 13);
            this.AddDefectTitleLabel.TabIndex = 9;
            this.AddDefectTitleLabel.Text = "Defekt";
            // 
            // AddDefectTitleTextBox
            // 
            this.AddDefectTitleTextBox.Location = new System.Drawing.Point(99, 30);
            this.AddDefectTitleTextBox.Name = "AddDefectTitleTextBox";
            this.AddDefectTitleTextBox.Size = new System.Drawing.Size(182, 20);
            this.AddDefectTitleTextBox.TabIndex = 10;
            // 
            // AddDefect
            // 
            this.AcceptButton = this.AddDefectSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.AddDefectTable);
            this.Name = "AddDefect";
            this.Text = "AddDefect";
            this.AddDefectTable.ResumeLayout(false);
            this.AddDefectTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddDefectTable;
        private System.Windows.Forms.Label AddDefectSelectLable;
        private System.Windows.Forms.Label AddDefectStartDateLabel;
        private System.Windows.Forms.Label AddDefektEndDateLable;
        private System.Windows.Forms.ComboBox AddDefectSelectMashineComboBox;
        private System.Windows.Forms.DateTimePicker AddDefectStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker AddDefectEndDateTimePicker;
        private System.Windows.Forms.Button AddDefectSubmitButton;
        private System.Windows.Forms.Label AddDefectTitleLabel;
        private System.Windows.Forms.TextBox AddDefectTitleTextBox;
    }
}