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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilebrowserFrame));
            this.FileFrameMainTable = new System.Windows.Forms.TableLayoutPanel();
            this.FileDisplayListBox = new System.Windows.Forms.ListBox();
            this.FilterSearchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SearchFileLable = new System.Windows.Forms.Label();
            this.FileSearchFilterInput = new System.Windows.Forms.TextBox();
            this.ButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileDownloadButton = new System.Windows.Forms.Button();
            this.FileUploadButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileFrameMainTable.SuspendLayout();
            this.FilterSearchTableLayout.SuspendLayout();
            this.ButtonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileFrameMainTable
            // 
            this.FileFrameMainTable.ColumnCount = 1;
            this.FileFrameMainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileFrameMainTable.Controls.Add(this.FileDisplayListBox, 0, 0);
            this.FileFrameMainTable.Controls.Add(this.FilterSearchTableLayout, 0, 1);
            this.FileFrameMainTable.Controls.Add(this.ButtonTableLayout, 0, 2);
            this.FileFrameMainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileFrameMainTable.Location = new System.Drawing.Point(0, 0);
            this.FileFrameMainTable.Name = "FileFrameMainTable";
            this.FileFrameMainTable.RowCount = 3;
            this.FileFrameMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.75829F));
            this.FileFrameMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.241706F));
            this.FileFrameMainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.FileFrameMainTable.Size = new System.Drawing.Size(385, 463);
            this.FileFrameMainTable.TabIndex = 0;
            // 
            // FileDisplayListBox
            // 
            this.FileDisplayListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDisplayListBox.FormattingEnabled = true;
            this.FileDisplayListBox.Location = new System.Drawing.Point(3, 3);
            this.FileDisplayListBox.Name = "FileDisplayListBox";
            this.FileDisplayListBox.Size = new System.Drawing.Size(379, 371);
            this.FileDisplayListBox.TabIndex = 0;
            this.FileDisplayListBox.DoubleClick += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FilterSearchTableLayout
            // 
            this.FilterSearchTableLayout.ColumnCount = 2;
            this.FilterSearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16359F));
            this.FilterSearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.83641F));
            this.FilterSearchTableLayout.Controls.Add(this.SearchFileLable, 0, 0);
            this.FilterSearchTableLayout.Controls.Add(this.FileSearchFilterInput, 1, 0);
            this.FilterSearchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterSearchTableLayout.Location = new System.Drawing.Point(3, 380);
            this.FilterSearchTableLayout.Name = "FilterSearchTableLayout";
            this.FilterSearchTableLayout.RowCount = 1;
            this.FilterSearchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FilterSearchTableLayout.Size = new System.Drawing.Size(379, 32);
            this.FilterSearchTableLayout.TabIndex = 4;
            // 
            // SearchFileLable
            // 
            this.SearchFileLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchFileLable.AutoSize = true;
            this.SearchFileLable.Location = new System.Drawing.Point(8, 9);
            this.SearchFileLable.Name = "SearchFileLable";
            this.SearchFileLable.Size = new System.Drawing.Size(73, 13);
            this.SearchFileLable.TabIndex = 0;
            this.SearchFileLable.Text = "Datei suchen:";
            // 
            // FileSearchFilterInput
            // 
            this.FileSearchFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FileSearchFilterInput.Location = new System.Drawing.Point(87, 6);
            this.FileSearchFilterInput.Name = "FileSearchFilterInput";
            this.FileSearchFilterInput.Size = new System.Drawing.Size(289, 20);
            this.FileSearchFilterInput.TabIndex = 1;
            this.FileSearchFilterInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FileSearchFilterInput_KeyUp);
            // 
            // ButtonTableLayout
            // 
            this.ButtonTableLayout.ColumnCount = 3;
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonTableLayout.Controls.Add(this.FileDownloadButton, 2, 0);
            this.ButtonTableLayout.Controls.Add(this.FileUploadButton, 1, 0);
            this.ButtonTableLayout.Controls.Add(this.OpenFileButton, 0, 0);
            this.ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTableLayout.Location = new System.Drawing.Point(3, 418);
            this.ButtonTableLayout.Name = "ButtonTableLayout";
            this.ButtonTableLayout.RowCount = 1;
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTableLayout.Size = new System.Drawing.Size(379, 42);
            this.ButtonTableLayout.TabIndex = 5;
            // 
            // FileDownloadButton
            // 
            this.FileDownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDownloadButton.Location = new System.Drawing.Point(255, 3);
            this.FileDownloadButton.Name = "FileDownloadButton";
            this.FileDownloadButton.Size = new System.Drawing.Size(121, 36);
            this.FileDownloadButton.TabIndex = 3;
            this.FileDownloadButton.Text = "Datei herunterladen";
            this.FileDownloadButton.UseVisualStyleBackColor = true;
            this.FileDownloadButton.Click += new System.EventHandler(this.FileDownloadButton_Click);
            // 
            // FileUploadButton
            // 
            this.FileUploadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileUploadButton.Location = new System.Drawing.Point(129, 3);
            this.FileUploadButton.Name = "FileUploadButton";
            this.FileUploadButton.Size = new System.Drawing.Size(120, 36);
            this.FileUploadButton.TabIndex = 2;
            this.FileUploadButton.Text = "Datei Hochladen";
            this.FileUploadButton.UseVisualStyleBackColor = true;
            this.FileUploadButton.Click += new System.EventHandler(this.FileUploadButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFileButton.Location = new System.Drawing.Point(3, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(120, 36);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Datei Öffnen";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.InitialDirectory = "C:\\\\";
            // 
            // FilebrowserFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 463);
            this.Controls.Add(this.FileFrameMainTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilebrowserFrame";
            this.Text = "Dateien";
            this.FileFrameMainTable.ResumeLayout(false);
            this.FilterSearchTableLayout.ResumeLayout(false);
            this.FilterSearchTableLayout.PerformLayout();
            this.ButtonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FileFrameMainTable;
        private System.Windows.Forms.ListBox FileDisplayListBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TableLayoutPanel FilterSearchTableLayout;
        private System.Windows.Forms.Label SearchFileLable;
        private System.Windows.Forms.TextBox FileSearchFilterInput;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayout;
        private System.Windows.Forms.Button FileDownloadButton;
        private System.Windows.Forms.Button FileUploadButton;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}