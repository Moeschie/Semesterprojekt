namespace View
{
    partial class FilebrowserFrame
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
            this.FileFrameMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.FileDisplayListBox = new System.Windows.Forms.ListBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileFrameMainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileFrameMainTable
            // 
            this.FileFrameMainTable.ColumnCount = 1;
            this.FileFrameMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileFrameMainTable.Controls.Add(this.FileDisplayListBox, 0, 1);
            this.FileFrameMainTable.Controls.Add(this.OpenFileButton, 0, 0);
            this.FileFrameMainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileFrameMainTable.Location = new System.Drawing.Point(0, 0);
            this.FileFrameMainTable.Name = "FileFrameMainTable";
            this.FileFrameMainTable.RowCount = 2;
            this.FileFrameMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileFrameMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileFrameMainTable.Size = new System.Drawing.Size(853, 463);
            this.FileFrameMainTable.TabIndex = 0;
            // 
            // FileDisplayListBox
            // 
            this.FileDisplayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDisplayListBox.FormattingEnabled = true;
            this.FileDisplayListBox.Location = new System.Drawing.Point(3, 234);
            this.FileDisplayListBox.Name = "FileDisplayListBox";
            this.FileDisplayListBox.Size = new System.Drawing.Size(847, 226);
            this.FileDisplayListBox.TabIndex = 0;
            this.FileDisplayListBox.DoubleClick += new System.EventHandler(this.FileDisplayListBox_DoubleClick);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(3, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FilebrowserFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 463);
            this.Controls.Add(this.FileFrameMainTable);
            this.Name = "FilebrowserFrame";
            this.Text = "FilebrowserFrame";
            this.FileFrameMainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FileFrameMainTable;
        private System.Windows.Forms.ListBox FileDisplayListBox;
        private System.Windows.Forms.Button OpenFileButton;
    }
}