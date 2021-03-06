﻿using Repository.Models;
using System.Collections.Generic;
using System.Data;

namespace View
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.FileArchivTab = new System.Windows.Forms.TabPage();
            this.ArchivMainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileSeachTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FileSeachLabel = new System.Windows.Forms.Label();
            this.FileSeachFilterInput = new System.Windows.Forms.TextBox();
            this.DirSearchTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DirSearchLabel = new System.Windows.Forms.Label();
            this.DirSearchFilterInput = new System.Windows.Forms.TextBox();
            this.FileDisplayTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.filesFromOrderGrpbox = new System.Windows.Forms.GroupBox();
            this.MainFrameFileListBox = new System.Windows.Forms.ListBox();
            this.FileBtnTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DownloadFileButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderFileGrpBox = new System.Windows.Forms.GroupBox();
            this.MainFrameDirListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refeshListButton = new System.Windows.Forms.Button();
            this.DownloadDirButton = new System.Windows.Forms.Button();
            this.MachineTab = new System.Windows.Forms.TabPage();
            this.MachineUsageChart = new Braincase.GanttChart.Chart();
            this.MachineMenu = new System.Windows.Forms.MenuStrip();
            this.NewMachineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMachineCreateSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMachineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefectMachineSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMachineNameSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maschinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeitraumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gesammtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewOrderGrpBox = new System.Windows.Forms.GroupBox();
            this.OrderDisplayMainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EDVGrpBox = new System.Windows.Forms.GroupBox();
            this.EDVTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Taetigkeit1Label = new System.Windows.Forms.Label();
            this.ProduktionszeitLabel = new System.Windows.Forms.Label();
            this.MaschineLabel = new System.Windows.Forms.Label();
            this.Taetigkeit2Label = new System.Windows.Forms.Label();
            this.Taetigkeit3Label = new System.Windows.Forms.Label();
            this.Taetigkeit4Label = new System.Windows.Forms.Label();
            this.Taetigkeit5Label = new System.Windows.Forms.Label();
            this.Taetigkeit6Label = new System.Windows.Forms.Label();
            this.OrderEDVJob1Input = new System.Windows.Forms.Label();
            this.OrderEDVJob2Input = new System.Windows.Forms.Label();
            this.OrderEDVJob3Input = new System.Windows.Forms.Label();
            this.OrderEDVJob4Input = new System.Windows.Forms.Label();
            this.OrderEDVJob5Input = new System.Windows.Forms.Label();
            this.OrderEDVJob6Input = new System.Windows.Forms.Label();
            this.MaschineSelectInput = new System.Windows.Forms.Label();
            this.ProudctionTimeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.EndMachineUsagesLabel = new System.Windows.Forms.Label();
            this.endLabelDisplay = new System.Windows.Forms.Label();
            this.OrderMaxProTimeInput = new System.Windows.Forms.Label();
            this.StartLabelDisplay = new System.Windows.Forms.Label();
            this.StartMachineUsagesLabel = new System.Windows.Forms.Label();
            this.ProductionGrpBox = new System.Windows.Forms.GroupBox();
            this.ProduktionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderInsertKindInput = new System.Windows.Forms.Label();
            this.OrderInsertInput = new System.Windows.Forms.Label();
            this.OrderProJob6Input = new System.Windows.Forms.Label();
            this.OrderProJob5Input = new System.Windows.Forms.Label();
            this.OrderProJob4Input = new System.Windows.Forms.Label();
            this.OrderProJob3Input = new System.Windows.Forms.Label();
            this.OrderProJob2Input = new System.Windows.Forms.Label();
            this.OrderProJob1Input = new System.Windows.Forms.Label();
            this.Taetigkeit12Label = new System.Windows.Forms.Label();
            this.Taetigkeit11Label = new System.Windows.Forms.Label();
            this.Taetigkeit10Label = new System.Windows.Forms.Label();
            this.Taetigkeit9Label = new System.Windows.Forms.Label();
            this.Taetigkeit8Label = new System.Windows.Forms.Label();
            this.Taetigkeit7Label = new System.Windows.Forms.Label();
            this.VerarbeitungTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.folierenCBInput = new System.Windows.Forms.CheckBox();
            this.inkenCBInput = new System.Windows.Forms.CheckBox();
            this.kuvertierenCBInput = new System.Windows.Forms.CheckBox();
            this.VerarbeitungLabel = new System.Windows.Forms.Label();
            this.BeilagenLabel = new System.Windows.Forms.Label();
            this.BeilagenartLabel = new System.Windows.Forms.Label();
            this.InfoGrpBox = new System.Windows.Forms.GroupBox();
            this.ZusatzTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.Zusatz_InfosLabel = new System.Windows.Forms.Label();
            this.RechnungLabel = new System.Windows.Forms.Label();
            this.OrderInfoInput = new System.Windows.Forms.Label();
            this.OrderBillInput = new System.Windows.Forms.Label();
            this.OrderMaterialInput = new System.Windows.Forms.Label();
            this.AuftragsdatenGrpBox = new System.Windows.Forms.GroupBox();
            this.CustomerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderRemainsInput = new System.Windows.Forms.Label();
            this.KundeLabel = new System.Windows.Forms.Label();
            this.AufteilungTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderForeignInput = new System.Windows.Forms.Label();
            this.OrderInlandInput = new System.Windows.Forms.Label();
            this.AuslandLabel = new System.Windows.Forms.Label();
            this.InlandLabel = new System.Windows.Forms.Label();
            this.ObjektLabel = new System.Windows.Forms.Label();
            this.AnsprechpartnerLabel = new System.Windows.Forms.Label();
            this.BearbeiterLabel = new System.Windows.Forms.Label();
            this.GesamtmengeLabel = new System.Windows.Forms.Label();
            this.AufteilungLabel = new System.Windows.Forms.Label();
            this.ResteLabel = new System.Windows.Forms.Label();
            this.OrderCustomerInput = new System.Windows.Forms.Label();
            this.OrderObjectInput = new System.Windows.Forms.Label();
            this.OrderConsultantInput = new System.Windows.Forms.Label();
            this.OrderEditorInput = new System.Windows.Forms.Label();
            this.OrderQuantityInput = new System.Windows.Forms.Label();
            this.ImportantInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.OrderLeftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.trifft_einLabel = new System.Windows.Forms.Label();
            this.OrderIncomeDateInput = new System.Windows.Forms.Label();
            this.OrderEditionInput = new System.Windows.Forms.Label();
            this.AuflageLabel = new System.Windows.Forms.Label();
            this.OrderDeadlineInput = new System.Windows.Forms.Label();
            this.PALLabel = new System.Windows.Forms.Label();
            this.OrderIncomeTimeInput = new System.Windows.Forms.Label();
            this.UhrzeitLabel = new System.Windows.Forms.Label();
            this.TopRightTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FunctionGrpBox = new System.Windows.Forms.GroupBox();
            this.TopRight3rdTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Editbutton = new System.Windows.Forms.Button();
            this.StatusChangeButton = new System.Windows.Forms.Button();
            this.ImportantInfo2GrpBox = new System.Windows.Forms.GroupBox();
            this.OrderRight1TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AuftragsNrLabel = new System.Windows.Forms.Label();
            this.OrderNumberInput = new System.Windows.Forms.Label();
            this.AuftragLabel = new System.Windows.Forms.Label();
            this.OrderNameInput = new System.Windows.Forms.Label();
            this.PrintGrpBox = new System.Windows.Forms.GroupBox();
            this.OrderRight2TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PrintOrderFolderButton = new System.Windows.Forms.Button();
            this.PrintLaufzettelButton = new System.Windows.Forms.Button();
            this.OrderTabLeftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ActiveOrderGrpBox = new System.Windows.Forms.GroupBox();
            this.SelectedOrderListBox = new System.Windows.Forms.ListBox();
            this.OrderTabLeftTopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderSelectFilterInput = new System.Windows.Forms.TextBox();
            this.OrderSelectFilterLabel = new System.Windows.Forms.Label();
            this.MainFrameMenu = new System.Windows.Forms.MenuStrip();
            this.NewFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenBenutzerAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrameTabControl = new System.Windows.Forms.TabControl();
            this.FileArchivTab.SuspendLayout();
            this.ArchivMainTableLayout.SuspendLayout();
            this.FileSeachTableLayout.SuspendLayout();
            this.DirSearchTableLayout.SuspendLayout();
            this.FileDisplayTableLayout.SuspendLayout();
            this.filesFromOrderGrpbox.SuspendLayout();
            this.FileBtnTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.orderFileGrpBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MachineTab.SuspendLayout();
            this.MachineMenu.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.PreviewOrderGrpBox.SuspendLayout();
            this.OrderDisplayMainTableLayout.SuspendLayout();
            this.EDVGrpBox.SuspendLayout();
            this.EDVTableLayout.SuspendLayout();
            this.ProudctionTimeTableLayout.SuspendLayout();
            this.ProductionGrpBox.SuspendLayout();
            this.ProduktionTableLayout.SuspendLayout();
            this.VerarbeitungTableLayout.SuspendLayout();
            this.InfoGrpBox.SuspendLayout();
            this.ZusatzTableLayout.SuspendLayout();
            this.AuftragsdatenGrpBox.SuspendLayout();
            this.CustomerTableLayout.SuspendLayout();
            this.AufteilungTableLayout.SuspendLayout();
            this.ImportantInfoGrpBox.SuspendLayout();
            this.OrderLeftTableLayout.SuspendLayout();
            this.TopRightTableLayout.SuspendLayout();
            this.FunctionGrpBox.SuspendLayout();
            this.TopRight3rdTableLayout.SuspendLayout();
            this.ImportantInfo2GrpBox.SuspendLayout();
            this.OrderRight1TableLayout.SuspendLayout();
            this.PrintGrpBox.SuspendLayout();
            this.OrderRight2TableLayout.SuspendLayout();
            this.OrderTabLeftTableLayout.SuspendLayout();
            this.ActiveOrderGrpBox.SuspendLayout();
            this.OrderTabLeftTopTableLayout.SuspendLayout();
            this.MainFrameMenu.SuspendLayout();
            this.MainFrameTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileArchivTab
            // 
            this.FileArchivTab.Controls.Add(this.ArchivMainTableLayout);
            this.FileArchivTab.Location = new System.Drawing.Point(4, 22);
            this.FileArchivTab.Name = "FileArchivTab";
            this.FileArchivTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileArchivTab.Size = new System.Drawing.Size(1354, 715);
            this.FileArchivTab.TabIndex = 3;
            this.FileArchivTab.Text = "Archiv";
            this.FileArchivTab.UseVisualStyleBackColor = true;
            // 
            // ArchivMainTableLayout
            // 
            this.ArchivMainTableLayout.ColumnCount = 3;
            this.ArchivMainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ArchivMainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ArchivMainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ArchivMainTableLayout.Controls.Add(this.FileSeachTableLayout, 1, 0);
            this.ArchivMainTableLayout.Controls.Add(this.DirSearchTableLayout, 0, 0);
            this.ArchivMainTableLayout.Controls.Add(this.FileDisplayTableLayout, 1, 1);
            this.ArchivMainTableLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ArchivMainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivMainTableLayout.Location = new System.Drawing.Point(3, 3);
            this.ArchivMainTableLayout.Name = "ArchivMainTableLayout";
            this.ArchivMainTableLayout.RowCount = 2;
            this.ArchivMainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.092716F));
            this.ArchivMainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.90729F));
            this.ArchivMainTableLayout.Size = new System.Drawing.Size(1348, 709);
            this.ArchivMainTableLayout.TabIndex = 0;
            // 
            // FileSeachTableLayout
            // 
            this.FileSeachTableLayout.ColumnCount = 2;
            this.FileSeachTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44776F));
            this.FileSeachTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.55224F));
            this.FileSeachTableLayout.Controls.Add(this.FileSeachLabel, 0, 0);
            this.FileSeachTableLayout.Controls.Add(this.FileSeachFilterInput, 1, 0);
            this.FileSeachTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSeachTableLayout.Location = new System.Drawing.Point(272, 3);
            this.FileSeachTableLayout.Name = "FileSeachTableLayout";
            this.FileSeachTableLayout.RowCount = 1;
            this.FileSeachTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileSeachTableLayout.Size = new System.Drawing.Size(263, 37);
            this.FileSeachTableLayout.TabIndex = 8;
            // 
            // FileSeachLabel
            // 
            this.FileSeachLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FileSeachLabel.AutoSize = true;
            this.FileSeachLabel.Location = new System.Drawing.Point(15, 12);
            this.FileSeachLabel.Name = "FileSeachLabel";
            this.FileSeachLabel.Size = new System.Drawing.Size(75, 13);
            this.FileSeachLabel.TabIndex = 0;
            this.FileSeachLabel.Text = "Datei Suchen:";
            // 
            // FileSeachFilterInput
            // 
            this.FileSeachFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FileSeachFilterInput.Location = new System.Drawing.Point(96, 8);
            this.FileSeachFilterInput.Name = "FileSeachFilterInput";
            this.FileSeachFilterInput.Size = new System.Drawing.Size(164, 20);
            this.FileSeachFilterInput.TabIndex = 1;
            // 
            // DirSearchTableLayout
            // 
            this.DirSearchTableLayout.ColumnCount = 2;
            this.DirSearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44776F));
            this.DirSearchTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.55224F));
            this.DirSearchTableLayout.Controls.Add(this.DirSearchLabel, 0, 0);
            this.DirSearchTableLayout.Controls.Add(this.DirSearchFilterInput, 1, 0);
            this.DirSearchTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirSearchTableLayout.Location = new System.Drawing.Point(3, 3);
            this.DirSearchTableLayout.Name = "DirSearchTableLayout";
            this.DirSearchTableLayout.RowCount = 1;
            this.DirSearchTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DirSearchTableLayout.Size = new System.Drawing.Size(263, 37);
            this.DirSearchTableLayout.TabIndex = 7;
            // 
            // DirSearchLabel
            // 
            this.DirSearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DirSearchLabel.AutoSize = true;
            this.DirSearchLabel.Location = new System.Drawing.Point(6, 12);
            this.DirSearchLabel.Name = "DirSearchLabel";
            this.DirSearchLabel.Size = new System.Drawing.Size(84, 13);
            this.DirSearchLabel.TabIndex = 0;
            this.DirSearchLabel.Text = "Auftrag Suchen:";
            // 
            // DirSearchFilterInput
            // 
            this.DirSearchFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DirSearchFilterInput.Location = new System.Drawing.Point(96, 8);
            this.DirSearchFilterInput.Name = "DirSearchFilterInput";
            this.DirSearchFilterInput.Size = new System.Drawing.Size(164, 20);
            this.DirSearchFilterInput.TabIndex = 1;
            this.DirSearchFilterInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DirSearchFilterInput_KeyUp);
            // 
            // FileDisplayTableLayout
            // 
            this.FileDisplayTableLayout.ColumnCount = 1;
            this.FileDisplayTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileDisplayTableLayout.Controls.Add(this.filesFromOrderGrpbox, 0, 1);
            this.FileDisplayTableLayout.Controls.Add(this.FileBtnTableLayout, 0, 0);
            this.FileDisplayTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDisplayTableLayout.Location = new System.Drawing.Point(272, 46);
            this.FileDisplayTableLayout.Name = "FileDisplayTableLayout";
            this.FileDisplayTableLayout.RowCount = 2;
            this.FileDisplayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.30303F));
            this.FileDisplayTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.69697F));
            this.FileDisplayTableLayout.Size = new System.Drawing.Size(263, 660);
            this.FileDisplayTableLayout.TabIndex = 9;
            // 
            // filesFromOrderGrpbox
            // 
            this.filesFromOrderGrpbox.Controls.Add(this.MainFrameFileListBox);
            this.filesFromOrderGrpbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesFromOrderGrpbox.Location = new System.Drawing.Point(3, 37);
            this.filesFromOrderGrpbox.Name = "filesFromOrderGrpbox";
            this.filesFromOrderGrpbox.Size = new System.Drawing.Size(257, 620);
            this.filesFromOrderGrpbox.TabIndex = 11;
            this.filesFromOrderGrpbox.TabStop = false;
            this.filesFromOrderGrpbox.Text = "Dateien des Auftrags";
            // 
            // MainFrameFileListBox
            // 
            this.MainFrameFileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFrameFileListBox.FormattingEnabled = true;
            this.MainFrameFileListBox.Location = new System.Drawing.Point(3, 16);
            this.MainFrameFileListBox.Name = "MainFrameFileListBox";
            this.MainFrameFileListBox.Size = new System.Drawing.Size(251, 601);
            this.MainFrameFileListBox.TabIndex = 0;
            this.MainFrameFileListBox.DoubleClick += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // FileBtnTableLayout
            // 
            this.FileBtnTableLayout.ColumnCount = 2;
            this.FileBtnTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileBtnTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileBtnTableLayout.Controls.Add(this.DownloadFileButton, 1, 0);
            this.FileBtnTableLayout.Controls.Add(this.OpenFileButton, 0, 0);
            this.FileBtnTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileBtnTableLayout.Location = new System.Drawing.Point(3, 3);
            this.FileBtnTableLayout.Name = "FileBtnTableLayout";
            this.FileBtnTableLayout.RowCount = 1;
            this.FileBtnTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileBtnTableLayout.Size = new System.Drawing.Size(257, 28);
            this.FileBtnTableLayout.TabIndex = 0;
            // 
            // DownloadFileButton
            // 
            this.DownloadFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadFileButton.Location = new System.Drawing.Point(131, 3);
            this.DownloadFileButton.Name = "DownloadFileButton";
            this.DownloadFileButton.Size = new System.Drawing.Size(123, 22);
            this.DownloadFileButton.TabIndex = 1;
            this.DownloadFileButton.Text = "Datei herunterladen";
            this.DownloadFileButton.UseVisualStyleBackColor = true;
            this.DownloadFileButton.Click += new System.EventHandler(this.DownloadFileButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFileButton.Location = new System.Drawing.Point(3, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(122, 22);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Datei Öffnen";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderFileGrpBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.30303F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.69697F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 660);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // orderFileGrpBox
            // 
            this.orderFileGrpBox.Controls.Add(this.MainFrameDirListBox);
            this.orderFileGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderFileGrpBox.Location = new System.Drawing.Point(3, 37);
            this.orderFileGrpBox.Name = "orderFileGrpBox";
            this.orderFileGrpBox.Size = new System.Drawing.Size(257, 620);
            this.orderFileGrpBox.TabIndex = 6;
            this.orderFileGrpBox.TabStop = false;
            this.orderFileGrpBox.Text = "Auftrag";
            // 
            // MainFrameDirListBox
            // 
            this.MainFrameDirListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFrameDirListBox.FormattingEnabled = true;
            this.MainFrameDirListBox.Location = new System.Drawing.Point(3, 16);
            this.MainFrameDirListBox.Name = "MainFrameDirListBox";
            this.MainFrameDirListBox.Size = new System.Drawing.Size(251, 601);
            this.MainFrameDirListBox.TabIndex = 0;
            this.MainFrameDirListBox.Click += new System.EventHandler(this.MainFrameDirListBox_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.refeshListButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DownloadDirButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 28);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // refeshListButton
            // 
            this.refeshListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refeshListButton.Location = new System.Drawing.Point(131, 3);
            this.refeshListButton.Name = "refeshListButton";
            this.refeshListButton.Size = new System.Drawing.Size(123, 22);
            this.refeshListButton.TabIndex = 2;
            this.refeshListButton.Text = "Liste aktualisieren";
            this.refeshListButton.UseVisualStyleBackColor = true;
            this.refeshListButton.Click += new System.EventHandler(this.refeshListButton_Click);
            // 
            // DownloadDirButton
            // 
            this.DownloadDirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadDirButton.Location = new System.Drawing.Point(3, 3);
            this.DownloadDirButton.Name = "DownloadDirButton";
            this.DownloadDirButton.Size = new System.Drawing.Size(122, 22);
            this.DownloadDirButton.TabIndex = 1;
            this.DownloadDirButton.Text = "Ordner Herunterladen";
            this.DownloadDirButton.UseVisualStyleBackColor = true;
            // 
            // MachineTab
            // 
            this.MachineTab.Controls.Add(this.MachineUsageChart);
            this.MachineTab.Controls.Add(this.MachineMenu);
            this.MachineTab.Location = new System.Drawing.Point(4, 22);
            this.MachineTab.Name = "MachineTab";
            this.MachineTab.Padding = new System.Windows.Forms.Padding(3);
            this.MachineTab.Size = new System.Drawing.Size(1354, 715);
            this.MachineTab.TabIndex = 4;
            this.MachineTab.Text = "Maschinen";
            this.MachineTab.UseVisualStyleBackColor = true;
            // 
            // MachineUsageChart
            // 
            this.MachineUsageChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineUsageChart.FullDateStringFormat = null;
            this.MachineUsageChart.Location = new System.Drawing.Point(3, 27);
            this.MachineUsageChart.Margin = new System.Windows.Forms.Padding(0);
            this.MachineUsageChart.Name = "MachineUsageChart";
            this.MachineUsageChart.Size = new System.Drawing.Size(1348, 685);
            this.MachineUsageChart.TabIndex = 2;
            // 
            // MachineMenu
            // 
            this.MachineMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMachineMenuItem,
            this.EditMachineMenuItem,
            this.anzeigeToolStripMenuItem});
            this.MachineMenu.Location = new System.Drawing.Point(3, 3);
            this.MachineMenu.Name = "MachineMenu";
            this.MachineMenu.Size = new System.Drawing.Size(1348, 24);
            this.MachineMenu.TabIndex = 0;
            this.MachineMenu.Text = "menuStrip2";
            // 
            // NewMachineMenuItem
            // 
            this.NewMachineMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMachineCreateSubMenuItem});
            this.NewMachineMenuItem.Name = "NewMachineMenuItem";
            this.NewMachineMenuItem.Size = new System.Drawing.Size(41, 20);
            this.NewMachineMenuItem.Text = "Neu";
            this.NewMachineMenuItem.Visible = false;
            // 
            // NewMachineCreateSubMenuItem
            // 
            this.NewMachineCreateSubMenuItem.Name = "NewMachineCreateSubMenuItem";
            this.NewMachineCreateSubMenuItem.Size = new System.Drawing.Size(136, 22);
            this.NewMachineCreateSubMenuItem.Text = "Hinzufügen";
            this.NewMachineCreateSubMenuItem.Click += new System.EventHandler(this.newMachine);
            // 
            // EditMachineMenuItem
            // 
            this.EditMachineMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DefectMachineSubMenuItem,
            this.EditMachineNameSubMenuItem});
            this.EditMachineMenuItem.Name = "EditMachineMenuItem";
            this.EditMachineMenuItem.Size = new System.Drawing.Size(75, 20);
            this.EditMachineMenuItem.Text = "Bearbeiten";
            this.EditMachineMenuItem.Visible = false;
            // 
            // DefectMachineSubMenuItem
            // 
            this.DefectMachineSubMenuItem.Name = "DefectMachineSubMenuItem";
            this.DefectMachineSubMenuItem.Size = new System.Drawing.Size(185, 22);
            this.DefectMachineSubMenuItem.Text = "Maschinen Belegung";
            this.DefectMachineSubMenuItem.Click += new System.EventHandler(this.addDefect);
            // 
            // EditMachineNameSubMenuItem
            // 
            this.EditMachineNameSubMenuItem.Name = "EditMachineNameSubMenuItem";
            this.EditMachineNameSubMenuItem.Size = new System.Drawing.Size(185, 22);
            this.EditMachineNameSubMenuItem.Text = "Maschinen Editieren";
            this.EditMachineNameSubMenuItem.Click += new System.EventHandler(this.editMaschine);
            // 
            // anzeigeToolStripMenuItem
            // 
            this.anzeigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maschinenToolStripMenuItem,
            this.zeitraumToolStripMenuItem});
            this.anzeigeToolStripMenuItem.Name = "anzeigeToolStripMenuItem";
            this.anzeigeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.anzeigeToolStripMenuItem.Text = "Anzeige";
            // 
            // maschinenToolStripMenuItem
            // 
            this.maschinenToolStripMenuItem.Name = "maschinenToolStripMenuItem";
            this.maschinenToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.maschinenToolStripMenuItem.Text = "Maschinen";
            // 
            // zeitraumToolStripMenuItem
            // 
            this.zeitraumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gesammtToolStripMenuItem});
            this.zeitraumToolStripMenuItem.Name = "zeitraumToolStripMenuItem";
            this.zeitraumToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zeitraumToolStripMenuItem.Text = "Zeitraum";
            // 
            // gesammtToolStripMenuItem
            // 
            this.gesammtToolStripMenuItem.Enabled = false;
            this.gesammtToolStripMenuItem.Name = "gesammtToolStripMenuItem";
            this.gesammtToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.gesammtToolStripMenuItem.Text = "Gesamt";
            this.gesammtToolStripMenuItem.Click += new System.EventHandler(this.switchScrollTO);
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.MainTableLayout);
            this.OrderTab.Controls.Add(this.MainFrameMenu);
            this.OrderTab.Location = new System.Drawing.Point(4, 22);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(1354, 715);
            this.OrderTab.TabIndex = 0;
            this.OrderTab.Text = "Aufträge";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.4095F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.59051F));
            this.MainTableLayout.Controls.Add(this.PreviewOrderGrpBox, 1, 0);
            this.MainTableLayout.Controls.Add(this.OrderTabLeftTableLayout, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(3, 27);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(1348, 685);
            this.MainTableLayout.TabIndex = 1;
            // 
            // PreviewOrderGrpBox
            // 
            this.PreviewOrderGrpBox.Controls.Add(this.OrderDisplayMainTableLayout);
            this.PreviewOrderGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewOrderGrpBox.Location = new System.Drawing.Point(359, 3);
            this.PreviewOrderGrpBox.Name = "PreviewOrderGrpBox";
            this.PreviewOrderGrpBox.Size = new System.Drawing.Size(986, 679);
            this.PreviewOrderGrpBox.TabIndex = 1;
            this.PreviewOrderGrpBox.TabStop = false;
            this.PreviewOrderGrpBox.Text = "Vorschau";
            // 
            // OrderDisplayMainTableLayout
            // 
            this.OrderDisplayMainTableLayout.ColumnCount = 2;
            this.OrderDisplayMainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.25569F));
            this.OrderDisplayMainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.74431F));
            this.OrderDisplayMainTableLayout.Controls.Add(this.EDVGrpBox, 1, 1);
            this.OrderDisplayMainTableLayout.Controls.Add(this.ProductionGrpBox, 1, 2);
            this.OrderDisplayMainTableLayout.Controls.Add(this.InfoGrpBox, 0, 2);
            this.OrderDisplayMainTableLayout.Controls.Add(this.AuftragsdatenGrpBox, 0, 1);
            this.OrderDisplayMainTableLayout.Controls.Add(this.ImportantInfoGrpBox, 0, 0);
            this.OrderDisplayMainTableLayout.Controls.Add(this.TopRightTableLayout, 1, 0);
            this.OrderDisplayMainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDisplayMainTableLayout.Location = new System.Drawing.Point(3, 16);
            this.OrderDisplayMainTableLayout.Name = "OrderDisplayMainTableLayout";
            this.OrderDisplayMainTableLayout.RowCount = 3;
            this.OrderDisplayMainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.OrderDisplayMainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.37736F));
            this.OrderDisplayMainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.69811F));
            this.OrderDisplayMainTableLayout.Size = new System.Drawing.Size(980, 660);
            this.OrderDisplayMainTableLayout.TabIndex = 1;
            // 
            // EDVGrpBox
            // 
            this.EDVGrpBox.Controls.Add(this.EDVTableLayout);
            this.EDVGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EDVGrpBox.Location = new System.Drawing.Point(466, 121);
            this.EDVGrpBox.Name = "EDVGrpBox";
            this.EDVGrpBox.Size = new System.Drawing.Size(511, 260);
            this.EDVGrpBox.TabIndex = 6;
            this.EDVGrpBox.TabStop = false;
            this.EDVGrpBox.Text = "EDV";
            // 
            // EDVTableLayout
            // 
            this.EDVTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.EDVTableLayout.ColumnCount = 2;
            this.EDVTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.01786F));
            this.EDVTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.98214F));
            this.EDVTableLayout.Controls.Add(this.Taetigkeit1Label, 0, 0);
            this.EDVTableLayout.Controls.Add(this.ProduktionszeitLabel, 0, 7);
            this.EDVTableLayout.Controls.Add(this.MaschineLabel, 0, 6);
            this.EDVTableLayout.Controls.Add(this.Taetigkeit2Label, 0, 1);
            this.EDVTableLayout.Controls.Add(this.Taetigkeit3Label, 0, 2);
            this.EDVTableLayout.Controls.Add(this.Taetigkeit4Label, 0, 3);
            this.EDVTableLayout.Controls.Add(this.Taetigkeit5Label, 0, 4);
            this.EDVTableLayout.Controls.Add(this.Taetigkeit6Label, 0, 5);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob1Input, 1, 0);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob2Input, 1, 1);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob3Input, 1, 2);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob4Input, 1, 3);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob5Input, 1, 4);
            this.EDVTableLayout.Controls.Add(this.OrderEDVJob6Input, 1, 5);
            this.EDVTableLayout.Controls.Add(this.MaschineSelectInput, 1, 6);
            this.EDVTableLayout.Controls.Add(this.ProudctionTimeTableLayout, 1, 7);
            this.EDVTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EDVTableLayout.Location = new System.Drawing.Point(3, 16);
            this.EDVTableLayout.Name = "EDVTableLayout";
            this.EDVTableLayout.RowCount = 8;
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.EDVTableLayout.Size = new System.Drawing.Size(505, 241);
            this.EDVTableLayout.TabIndex = 4;
            // 
            // Taetigkeit1Label
            // 
            this.Taetigkeit1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit1Label.AutoSize = true;
            this.Taetigkeit1Label.Location = new System.Drawing.Point(83, 9);
            this.Taetigkeit1Label.Name = "Taetigkeit1Label";
            this.Taetigkeit1Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit1Label.TabIndex = 9;
            this.Taetigkeit1Label.Text = "Tätigkeit 1:";
            // 
            // ProduktionszeitLabel
            // 
            this.ProduktionszeitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProduktionszeitLabel.AutoSize = true;
            this.ProduktionszeitLabel.Location = new System.Drawing.Point(36, 215);
            this.ProduktionszeitLabel.Name = "ProduktionszeitLabel";
            this.ProduktionszeitLabel.Size = new System.Drawing.Size(107, 13);
            this.ProduktionszeitLabel.TabIndex = 12;
            this.ProduktionszeitLabel.Text = "max. Produktionszeit:";
            // 
            // MaschineLabel
            // 
            this.MaschineLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaschineLabel.AutoSize = true;
            this.MaschineLabel.Location = new System.Drawing.Point(43, 183);
            this.MaschineLabel.Name = "MaschineLabel";
            this.MaschineLabel.Size = new System.Drawing.Size(100, 13);
            this.MaschineLabel.TabIndex = 13;
            this.MaschineLabel.Text = "geplante Maschine:";
            // 
            // Taetigkeit2Label
            // 
            this.Taetigkeit2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit2Label.AutoSize = true;
            this.Taetigkeit2Label.Location = new System.Drawing.Point(83, 38);
            this.Taetigkeit2Label.Name = "Taetigkeit2Label";
            this.Taetigkeit2Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit2Label.TabIndex = 14;
            this.Taetigkeit2Label.Text = "Tätigkeit 2:";
            // 
            // Taetigkeit3Label
            // 
            this.Taetigkeit3Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit3Label.AutoSize = true;
            this.Taetigkeit3Label.Location = new System.Drawing.Point(83, 67);
            this.Taetigkeit3Label.Name = "Taetigkeit3Label";
            this.Taetigkeit3Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit3Label.TabIndex = 15;
            this.Taetigkeit3Label.Text = "Tätigkeit 3:";
            // 
            // Taetigkeit4Label
            // 
            this.Taetigkeit4Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit4Label.AutoSize = true;
            this.Taetigkeit4Label.Location = new System.Drawing.Point(83, 96);
            this.Taetigkeit4Label.Name = "Taetigkeit4Label";
            this.Taetigkeit4Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit4Label.TabIndex = 16;
            this.Taetigkeit4Label.Text = "Tätigkeit 4:";
            // 
            // Taetigkeit5Label
            // 
            this.Taetigkeit5Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit5Label.AutoSize = true;
            this.Taetigkeit5Label.Location = new System.Drawing.Point(83, 125);
            this.Taetigkeit5Label.Name = "Taetigkeit5Label";
            this.Taetigkeit5Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit5Label.TabIndex = 17;
            this.Taetigkeit5Label.Text = "Tätigkeit 5:";
            // 
            // Taetigkeit6Label
            // 
            this.Taetigkeit6Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit6Label.AutoSize = true;
            this.Taetigkeit6Label.Location = new System.Drawing.Point(83, 154);
            this.Taetigkeit6Label.Name = "Taetigkeit6Label";
            this.Taetigkeit6Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit6Label.TabIndex = 18;
            this.Taetigkeit6Label.Text = "Tätigkeit 6:";
            // 
            // OrderEDVJob1Input
            // 
            this.OrderEDVJob1Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderEDVJob1Input.Location = new System.Drawing.Point(151, 2);
            this.OrderEDVJob1Input.Name = "OrderEDVJob1Input";
            this.OrderEDVJob1Input.Size = new System.Drawing.Size(349, 27);
            this.OrderEDVJob1Input.TabIndex = 19;
            // 
            // OrderEDVJob2Input
            // 
            this.OrderEDVJob2Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEDVJob2Input.Location = new System.Drawing.Point(151, 34);
            this.OrderEDVJob2Input.Name = "OrderEDVJob2Input";
            this.OrderEDVJob2Input.Size = new System.Drawing.Size(248, 20);
            this.OrderEDVJob2Input.TabIndex = 20;
            // 
            // OrderEDVJob3Input
            // 
            this.OrderEDVJob3Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEDVJob3Input.Location = new System.Drawing.Point(151, 63);
            this.OrderEDVJob3Input.Name = "OrderEDVJob3Input";
            this.OrderEDVJob3Input.Size = new System.Drawing.Size(248, 20);
            this.OrderEDVJob3Input.TabIndex = 21;
            // 
            // OrderEDVJob4Input
            // 
            this.OrderEDVJob4Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEDVJob4Input.Location = new System.Drawing.Point(151, 92);
            this.OrderEDVJob4Input.Name = "OrderEDVJob4Input";
            this.OrderEDVJob4Input.Size = new System.Drawing.Size(248, 20);
            this.OrderEDVJob4Input.TabIndex = 22;
            // 
            // OrderEDVJob5Input
            // 
            this.OrderEDVJob5Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEDVJob5Input.Location = new System.Drawing.Point(151, 121);
            this.OrderEDVJob5Input.Name = "OrderEDVJob5Input";
            this.OrderEDVJob5Input.Size = new System.Drawing.Size(248, 20);
            this.OrderEDVJob5Input.TabIndex = 23;
            // 
            // OrderEDVJob6Input
            // 
            this.OrderEDVJob6Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEDVJob6Input.Location = new System.Drawing.Point(151, 150);
            this.OrderEDVJob6Input.Name = "OrderEDVJob6Input";
            this.OrderEDVJob6Input.Size = new System.Drawing.Size(248, 20);
            this.OrderEDVJob6Input.TabIndex = 24;
            // 
            // MaschineSelectInput
            // 
            this.MaschineSelectInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaschineSelectInput.Location = new System.Drawing.Point(151, 179);
            this.MaschineSelectInput.Name = "MaschineSelectInput";
            this.MaschineSelectInput.Size = new System.Drawing.Size(248, 21);
            this.MaschineSelectInput.TabIndex = 27;
            // 
            // ProudctionTimeTableLayout
            // 
            this.ProudctionTimeTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.ProudctionTimeTableLayout.ColumnCount = 5;
            this.ProudctionTimeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14451F));
            this.ProudctionTimeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.71676F));
            this.ProudctionTimeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.69942F));
            this.ProudctionTimeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.00578F));
            this.ProudctionTimeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.85549F));
            this.ProudctionTimeTableLayout.Controls.Add(this.EndMachineUsagesLabel, 3, 0);
            this.ProudctionTimeTableLayout.Controls.Add(this.endLabelDisplay, 4, 0);
            this.ProudctionTimeTableLayout.Controls.Add(this.OrderMaxProTimeInput, 0, 0);
            this.ProudctionTimeTableLayout.Controls.Add(this.StartLabelDisplay, 2, 0);
            this.ProudctionTimeTableLayout.Controls.Add(this.StartMachineUsagesLabel, 1, 0);
            this.ProudctionTimeTableLayout.Location = new System.Drawing.Point(151, 208);
            this.ProudctionTimeTableLayout.Name = "ProudctionTimeTableLayout";
            this.ProudctionTimeTableLayout.RowCount = 1;
            this.ProudctionTimeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProudctionTimeTableLayout.Size = new System.Drawing.Size(348, 28);
            this.ProudctionTimeTableLayout.TabIndex = 29;
            // 
            // EndMachineUsagesLabel
            // 
            this.EndMachineUsagesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EndMachineUsagesLabel.AutoSize = true;
            this.EndMachineUsagesLabel.Location = new System.Drawing.Point(219, 7);
            this.EndMachineUsagesLabel.Name = "EndMachineUsagesLabel";
            this.EndMachineUsagesLabel.Size = new System.Drawing.Size(35, 13);
            this.EndMachineUsagesLabel.TabIndex = 29;
            this.EndMachineUsagesLabel.Text = "Ende:";
            // 
            // endLabelDisplay
            // 
            this.endLabelDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endLabelDisplay.AutoSize = true;
            this.endLabelDisplay.Location = new System.Drawing.Point(262, 7);
            this.endLabelDisplay.Name = "endLabelDisplay";
            this.endLabelDisplay.Size = new System.Drawing.Size(0, 13);
            this.endLabelDisplay.TabIndex = 28;
            // 
            // OrderMaxProTimeInput
            // 
            this.OrderMaxProTimeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderMaxProTimeInput.AutoSize = true;
            this.OrderMaxProTimeInput.Location = new System.Drawing.Point(5, 7);
            this.OrderMaxProTimeInput.Name = "OrderMaxProTimeInput";
            this.OrderMaxProTimeInput.Size = new System.Drawing.Size(0, 13);
            this.OrderMaxProTimeInput.TabIndex = 32;
            // 
            // StartLabelDisplay
            // 
            this.StartLabelDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StartLabelDisplay.AutoSize = true;
            this.StartLabelDisplay.Location = new System.Drawing.Point(135, 7);
            this.StartLabelDisplay.Name = "StartLabelDisplay";
            this.StartLabelDisplay.Size = new System.Drawing.Size(0, 13);
            this.StartLabelDisplay.TabIndex = 31;
            // 
            // StartMachineUsagesLabel
            // 
            this.StartMachineUsagesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StartMachineUsagesLabel.AutoSize = true;
            this.StartMachineUsagesLabel.Location = new System.Drawing.Point(95, 7);
            this.StartMachineUsagesLabel.Name = "StartMachineUsagesLabel";
            this.StartMachineUsagesLabel.Size = new System.Drawing.Size(32, 13);
            this.StartMachineUsagesLabel.TabIndex = 30;
            this.StartMachineUsagesLabel.Text = "Start:";
            // 
            // ProductionGrpBox
            // 
            this.ProductionGrpBox.Controls.Add(this.ProduktionTableLayout);
            this.ProductionGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductionGrpBox.Location = new System.Drawing.Point(466, 387);
            this.ProductionGrpBox.Name = "ProductionGrpBox";
            this.ProductionGrpBox.Size = new System.Drawing.Size(511, 270);
            this.ProductionGrpBox.TabIndex = 7;
            this.ProductionGrpBox.TabStop = false;
            this.ProductionGrpBox.Text = "Produktion";
            // 
            // ProduktionTableLayout
            // 
            this.ProduktionTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.ProduktionTableLayout.ColumnCount = 2;
            this.ProduktionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.98953F));
            this.ProduktionTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.01047F));
            this.ProduktionTableLayout.Controls.Add(this.OrderInsertKindInput, 1, 7);
            this.ProduktionTableLayout.Controls.Add(this.OrderInsertInput, 1, 6);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob6Input, 1, 5);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob5Input, 1, 4);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob4Input, 1, 3);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob3Input, 1, 2);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob2Input, 1, 1);
            this.ProduktionTableLayout.Controls.Add(this.OrderProJob1Input, 1, 0);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit12Label, 0, 5);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit11Label, 0, 4);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit10Label, 0, 3);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit9Label, 0, 2);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit8Label, 0, 1);
            this.ProduktionTableLayout.Controls.Add(this.Taetigkeit7Label, 0, 0);
            this.ProduktionTableLayout.Controls.Add(this.VerarbeitungTableLayout, 1, 8);
            this.ProduktionTableLayout.Controls.Add(this.VerarbeitungLabel, 0, 8);
            this.ProduktionTableLayout.Controls.Add(this.BeilagenLabel, 0, 6);
            this.ProduktionTableLayout.Controls.Add(this.BeilagenartLabel, 0, 7);
            this.ProduktionTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduktionTableLayout.Location = new System.Drawing.Point(3, 16);
            this.ProduktionTableLayout.Name = "ProduktionTableLayout";
            this.ProduktionTableLayout.RowCount = 9;
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.ProduktionTableLayout.Size = new System.Drawing.Size(505, 251);
            this.ProduktionTableLayout.TabIndex = 6;
            // 
            // OrderInsertKindInput
            // 
            this.OrderInsertKindInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderInsertKindInput.Location = new System.Drawing.Point(118, 194);
            this.OrderInsertKindInput.Name = "OrderInsertKindInput";
            this.OrderInsertKindInput.Size = new System.Drawing.Size(292, 20);
            this.OrderInsertKindInput.TabIndex = 33;
            // 
            // OrderInsertInput
            // 
            this.OrderInsertInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderInsertInput.Location = new System.Drawing.Point(118, 167);
            this.OrderInsertInput.Name = "OrderInsertInput";
            this.OrderInsertInput.Size = new System.Drawing.Size(292, 20);
            this.OrderInsertInput.TabIndex = 32;
            // 
            // OrderProJob6Input
            // 
            this.OrderProJob6Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob6Input.Location = new System.Drawing.Point(118, 140);
            this.OrderProJob6Input.Name = "OrderProJob6Input";
            this.OrderProJob6Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob6Input.TabIndex = 31;
            // 
            // OrderProJob5Input
            // 
            this.OrderProJob5Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob5Input.Location = new System.Drawing.Point(118, 113);
            this.OrderProJob5Input.Name = "OrderProJob5Input";
            this.OrderProJob5Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob5Input.TabIndex = 30;
            // 
            // OrderProJob4Input
            // 
            this.OrderProJob4Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob4Input.Location = new System.Drawing.Point(118, 86);
            this.OrderProJob4Input.Name = "OrderProJob4Input";
            this.OrderProJob4Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob4Input.TabIndex = 29;
            // 
            // OrderProJob3Input
            // 
            this.OrderProJob3Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob3Input.Location = new System.Drawing.Point(118, 59);
            this.OrderProJob3Input.Name = "OrderProJob3Input";
            this.OrderProJob3Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob3Input.TabIndex = 28;
            // 
            // OrderProJob2Input
            // 
            this.OrderProJob2Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob2Input.Location = new System.Drawing.Point(118, 32);
            this.OrderProJob2Input.Name = "OrderProJob2Input";
            this.OrderProJob2Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob2Input.TabIndex = 27;
            // 
            // OrderProJob1Input
            // 
            this.OrderProJob1Input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderProJob1Input.Location = new System.Drawing.Point(118, 5);
            this.OrderProJob1Input.Name = "OrderProJob1Input";
            this.OrderProJob1Input.Size = new System.Drawing.Size(292, 20);
            this.OrderProJob1Input.TabIndex = 25;
            // 
            // Taetigkeit12Label
            // 
            this.Taetigkeit12Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit12Label.AutoSize = true;
            this.Taetigkeit12Label.Location = new System.Drawing.Point(49, 143);
            this.Taetigkeit12Label.Name = "Taetigkeit12Label";
            this.Taetigkeit12Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit12Label.TabIndex = 22;
            this.Taetigkeit12Label.Text = "Tätigkeit 6:";
            // 
            // Taetigkeit11Label
            // 
            this.Taetigkeit11Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit11Label.AutoSize = true;
            this.Taetigkeit11Label.Location = new System.Drawing.Point(49, 116);
            this.Taetigkeit11Label.Name = "Taetigkeit11Label";
            this.Taetigkeit11Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit11Label.TabIndex = 20;
            this.Taetigkeit11Label.Text = "Tätigkeit 5:";
            // 
            // Taetigkeit10Label
            // 
            this.Taetigkeit10Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit10Label.AutoSize = true;
            this.Taetigkeit10Label.Location = new System.Drawing.Point(49, 89);
            this.Taetigkeit10Label.Name = "Taetigkeit10Label";
            this.Taetigkeit10Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit10Label.TabIndex = 18;
            this.Taetigkeit10Label.Text = "Tätigkeit 4:";
            // 
            // Taetigkeit9Label
            // 
            this.Taetigkeit9Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit9Label.AutoSize = true;
            this.Taetigkeit9Label.Location = new System.Drawing.Point(49, 62);
            this.Taetigkeit9Label.Name = "Taetigkeit9Label";
            this.Taetigkeit9Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit9Label.TabIndex = 16;
            this.Taetigkeit9Label.Text = "Tätigkeit 3:";
            // 
            // Taetigkeit8Label
            // 
            this.Taetigkeit8Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit8Label.AutoSize = true;
            this.Taetigkeit8Label.Location = new System.Drawing.Point(49, 35);
            this.Taetigkeit8Label.Name = "Taetigkeit8Label";
            this.Taetigkeit8Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit8Label.TabIndex = 14;
            this.Taetigkeit8Label.Text = "Tätigkeit 2:";
            // 
            // Taetigkeit7Label
            // 
            this.Taetigkeit7Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taetigkeit7Label.AutoSize = true;
            this.Taetigkeit7Label.Location = new System.Drawing.Point(49, 8);
            this.Taetigkeit7Label.Name = "Taetigkeit7Label";
            this.Taetigkeit7Label.Size = new System.Drawing.Size(60, 13);
            this.Taetigkeit7Label.TabIndex = 12;
            this.Taetigkeit7Label.Text = "Tätigkeit 1:";
            // 
            // VerarbeitungTableLayout
            // 
            this.VerarbeitungTableLayout.ColumnCount = 3;
            this.VerarbeitungTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65289F));
            this.VerarbeitungTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.04471F));
            this.VerarbeitungTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.32771F));
            this.VerarbeitungTableLayout.Controls.Add(this.folierenCBInput, 2, 0);
            this.VerarbeitungTableLayout.Controls.Add(this.inkenCBInput, 1, 0);
            this.VerarbeitungTableLayout.Controls.Add(this.kuvertierenCBInput, 0, 0);
            this.VerarbeitungTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerarbeitungTableLayout.Location = new System.Drawing.Point(118, 222);
            this.VerarbeitungTableLayout.Name = "VerarbeitungTableLayout";
            this.VerarbeitungTableLayout.RowCount = 1;
            this.VerarbeitungTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VerarbeitungTableLayout.Size = new System.Drawing.Size(381, 23);
            this.VerarbeitungTableLayout.TabIndex = 0;
            // 
            // folierenCBInput
            // 
            this.folierenCBInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.folierenCBInput.AutoSize = true;
            this.folierenCBInput.Enabled = false;
            this.folierenCBInput.Location = new System.Drawing.Point(256, 3);
            this.folierenCBInput.Name = "folierenCBInput";
            this.folierenCBInput.Size = new System.Drawing.Size(60, 17);
            this.folierenCBInput.TabIndex = 2;
            this.folierenCBInput.Text = "folieren";
            this.folierenCBInput.UseVisualStyleBackColor = true;
            // 
            // inkenCBInput
            // 
            this.inkenCBInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inkenCBInput.AutoSize = true;
            this.inkenCBInput.Enabled = false;
            this.inkenCBInput.Location = new System.Drawing.Point(123, 3);
            this.inkenCBInput.Name = "inkenCBInput";
            this.inkenCBInput.Size = new System.Drawing.Size(52, 17);
            this.inkenCBInput.TabIndex = 1;
            this.inkenCBInput.Text = "inken";
            this.inkenCBInput.UseVisualStyleBackColor = true;
            // 
            // kuvertierenCBInput
            // 
            this.kuvertierenCBInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kuvertierenCBInput.AutoSize = true;
            this.kuvertierenCBInput.Enabled = false;
            this.kuvertierenCBInput.Location = new System.Drawing.Point(3, 3);
            this.kuvertierenCBInput.Name = "kuvertierenCBInput";
            this.kuvertierenCBInput.Size = new System.Drawing.Size(79, 17);
            this.kuvertierenCBInput.TabIndex = 0;
            this.kuvertierenCBInput.Text = "kuvertieren";
            this.kuvertierenCBInput.UseVisualStyleBackColor = true;
            // 
            // VerarbeitungLabel
            // 
            this.VerarbeitungLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VerarbeitungLabel.AutoSize = true;
            this.VerarbeitungLabel.Location = new System.Drawing.Point(42, 227);
            this.VerarbeitungLabel.Name = "VerarbeitungLabel";
            this.VerarbeitungLabel.Size = new System.Drawing.Size(67, 13);
            this.VerarbeitungLabel.TabIndex = 10;
            this.VerarbeitungLabel.Text = "Verarbeitung";
            // 
            // BeilagenLabel
            // 
            this.BeilagenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BeilagenLabel.AutoSize = true;
            this.BeilagenLabel.Location = new System.Drawing.Point(58, 170);
            this.BeilagenLabel.Name = "BeilagenLabel";
            this.BeilagenLabel.Size = new System.Drawing.Size(51, 13);
            this.BeilagenLabel.TabIndex = 23;
            this.BeilagenLabel.Text = "Beilagen:";
            // 
            // BeilagenartLabel
            // 
            this.BeilagenartLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BeilagenartLabel.AutoSize = true;
            this.BeilagenartLabel.Location = new System.Drawing.Point(46, 197);
            this.BeilagenartLabel.Name = "BeilagenartLabel";
            this.BeilagenartLabel.Size = new System.Drawing.Size(63, 13);
            this.BeilagenartLabel.TabIndex = 24;
            this.BeilagenartLabel.Text = "Beilagenart:";
            // 
            // InfoGrpBox
            // 
            this.InfoGrpBox.Controls.Add(this.ZusatzTableLayout);
            this.InfoGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGrpBox.Location = new System.Drawing.Point(3, 387);
            this.InfoGrpBox.Name = "InfoGrpBox";
            this.InfoGrpBox.Size = new System.Drawing.Size(457, 270);
            this.InfoGrpBox.TabIndex = 8;
            this.InfoGrpBox.TabStop = false;
            this.InfoGrpBox.Text = "Infos";
            // 
            // ZusatzTableLayout
            // 
            this.ZusatzTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.ZusatzTableLayout.ColumnCount = 2;
            this.ZusatzTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.82271F));
            this.ZusatzTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.17728F));
            this.ZusatzTableLayout.Controls.Add(this.MaterialLabel, 0, 2);
            this.ZusatzTableLayout.Controls.Add(this.Zusatz_InfosLabel, 0, 0);
            this.ZusatzTableLayout.Controls.Add(this.RechnungLabel, 0, 1);
            this.ZusatzTableLayout.Controls.Add(this.OrderInfoInput, 1, 0);
            this.ZusatzTableLayout.Controls.Add(this.OrderBillInput, 1, 1);
            this.ZusatzTableLayout.Controls.Add(this.OrderMaterialInput, 1, 2);
            this.ZusatzTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZusatzTableLayout.Location = new System.Drawing.Point(3, 16);
            this.ZusatzTableLayout.Name = "ZusatzTableLayout";
            this.ZusatzTableLayout.RowCount = 3;
            this.ZusatzTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ZusatzTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ZusatzTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ZusatzTableLayout.Size = new System.Drawing.Size(451, 251);
            this.ZusatzTableLayout.TabIndex = 5;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(58, 202);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(47, 13);
            this.MaterialLabel.TabIndex = 11;
            this.MaterialLabel.Text = "Material:";
            // 
            // Zusatz_InfosLabel
            // 
            this.Zusatz_InfosLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Zusatz_InfosLabel.AutoSize = true;
            this.Zusatz_InfosLabel.Location = new System.Drawing.Point(37, 36);
            this.Zusatz_InfosLabel.Name = "Zusatz_InfosLabel";
            this.Zusatz_InfosLabel.Size = new System.Drawing.Size(68, 13);
            this.Zusatz_InfosLabel.TabIndex = 9;
            this.Zusatz_InfosLabel.Text = "Zusatz-Infos:";
            // 
            // RechnungLabel
            // 
            this.RechnungLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RechnungLabel.AutoSize = true;
            this.RechnungLabel.Location = new System.Drawing.Point(30, 119);
            this.RechnungLabel.Name = "RechnungLabel";
            this.RechnungLabel.Size = new System.Drawing.Size(75, 13);
            this.RechnungLabel.TabIndex = 10;
            this.RechnungLabel.Text = "Rechnung an:";
            // 
            // OrderInfoInput
            // 
            this.OrderInfoInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderInfoInput.Location = new System.Drawing.Point(113, 20);
            this.OrderInfoInput.Name = "OrderInfoInput";
            this.OrderInfoInput.Size = new System.Drawing.Size(254, 45);
            this.OrderInfoInput.TabIndex = 13;
            // 
            // OrderBillInput
            // 
            this.OrderBillInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderBillInput.Location = new System.Drawing.Point(113, 103);
            this.OrderBillInput.Name = "OrderBillInput";
            this.OrderBillInput.Size = new System.Drawing.Size(254, 45);
            this.OrderBillInput.TabIndex = 14;
            // 
            // OrderMaterialInput
            // 
            this.OrderMaterialInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderMaterialInput.Location = new System.Drawing.Point(113, 185);
            this.OrderMaterialInput.Name = "OrderMaterialInput";
            this.OrderMaterialInput.Size = new System.Drawing.Size(254, 46);
            this.OrderMaterialInput.TabIndex = 15;
            // 
            // AuftragsdatenGrpBox
            // 
            this.AuftragsdatenGrpBox.Controls.Add(this.CustomerTableLayout);
            this.AuftragsdatenGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuftragsdatenGrpBox.Location = new System.Drawing.Point(3, 121);
            this.AuftragsdatenGrpBox.Name = "AuftragsdatenGrpBox";
            this.AuftragsdatenGrpBox.Size = new System.Drawing.Size(457, 260);
            this.AuftragsdatenGrpBox.TabIndex = 9;
            this.AuftragsdatenGrpBox.TabStop = false;
            this.AuftragsdatenGrpBox.Text = "Auftragsdaten";
            // 
            // CustomerTableLayout
            // 
            this.CustomerTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.CustomerTableLayout.ColumnCount = 2;
            this.CustomerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.97784F));
            this.CustomerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.02216F));
            this.CustomerTableLayout.Controls.Add(this.OrderRemainsInput, 1, 6);
            this.CustomerTableLayout.Controls.Add(this.KundeLabel, 0, 0);
            this.CustomerTableLayout.Controls.Add(this.AufteilungTableLayout, 1, 5);
            this.CustomerTableLayout.Controls.Add(this.ObjektLabel, 0, 1);
            this.CustomerTableLayout.Controls.Add(this.AnsprechpartnerLabel, 0, 2);
            this.CustomerTableLayout.Controls.Add(this.BearbeiterLabel, 0, 3);
            this.CustomerTableLayout.Controls.Add(this.GesamtmengeLabel, 0, 4);
            this.CustomerTableLayout.Controls.Add(this.AufteilungLabel, 0, 5);
            this.CustomerTableLayout.Controls.Add(this.ResteLabel, 0, 6);
            this.CustomerTableLayout.Controls.Add(this.OrderCustomerInput, 1, 0);
            this.CustomerTableLayout.Controls.Add(this.OrderObjectInput, 1, 1);
            this.CustomerTableLayout.Controls.Add(this.OrderConsultantInput, 1, 2);
            this.CustomerTableLayout.Controls.Add(this.OrderEditorInput, 1, 3);
            this.CustomerTableLayout.Controls.Add(this.OrderQuantityInput, 1, 4);
            this.CustomerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTableLayout.Location = new System.Drawing.Point(3, 16);
            this.CustomerTableLayout.Name = "CustomerTableLayout";
            this.CustomerTableLayout.RowCount = 7;
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.53623F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.07729F));
            this.CustomerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CustomerTableLayout.Size = new System.Drawing.Size(451, 241);
            this.CustomerTableLayout.TabIndex = 1;
            // 
            // OrderRemainsInput
            // 
            this.OrderRemainsInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderRemainsInput.Location = new System.Drawing.Point(131, 213);
            this.OrderRemainsInput.Name = "OrderRemainsInput";
            this.OrderRemainsInput.Size = new System.Drawing.Size(239, 23);
            this.OrderRemainsInput.TabIndex = 20;
            // 
            // KundeLabel
            // 
            this.KundeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.KundeLabel.AutoSize = true;
            this.KundeLabel.Location = new System.Drawing.Point(82, 9);
            this.KundeLabel.Name = "KundeLabel";
            this.KundeLabel.Size = new System.Drawing.Size(41, 13);
            this.KundeLabel.TabIndex = 3;
            this.KundeLabel.Text = "Kunde:";
            // 
            // AufteilungTableLayout
            // 
            this.AufteilungTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.AufteilungTableLayout.ColumnCount = 2;
            this.AufteilungTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.57143F));
            this.AufteilungTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.42857F));
            this.AufteilungTableLayout.Controls.Add(this.OrderForeignInput, 1, 1);
            this.AufteilungTableLayout.Controls.Add(this.OrderInlandInput, 1, 0);
            this.AufteilungTableLayout.Controls.Add(this.AuslandLabel, 0, 1);
            this.AufteilungTableLayout.Controls.Add(this.InlandLabel, 0, 0);
            this.AufteilungTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AufteilungTableLayout.Location = new System.Drawing.Point(131, 150);
            this.AufteilungTableLayout.Name = "AufteilungTableLayout";
            this.AufteilungTableLayout.RowCount = 2;
            this.AufteilungTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AufteilungTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AufteilungTableLayout.Size = new System.Drawing.Size(315, 55);
            this.AufteilungTableLayout.TabIndex = 0;
            // 
            // OrderForeignInput
            // 
            this.OrderForeignInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderForeignInput.Location = new System.Drawing.Point(79, 30);
            this.OrderForeignInput.Name = "OrderForeignInput";
            this.OrderForeignInput.Size = new System.Drawing.Size(177, 20);
            this.OrderForeignInput.TabIndex = 19;
            // 
            // OrderInlandInput
            // 
            this.OrderInlandInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderInlandInput.Location = new System.Drawing.Point(79, 4);
            this.OrderInlandInput.Name = "OrderInlandInput";
            this.OrderInlandInput.Size = new System.Drawing.Size(177, 20);
            this.OrderInlandInput.TabIndex = 18;
            // 
            // AuslandLabel
            // 
            this.AuslandLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuslandLabel.AutoSize = true;
            this.AuslandLabel.Location = new System.Drawing.Point(23, 34);
            this.AuslandLabel.Name = "AuslandLabel";
            this.AuslandLabel.Size = new System.Drawing.Size(48, 13);
            this.AuslandLabel.TabIndex = 10;
            this.AuslandLabel.Text = "Ausland:";
            // 
            // InlandLabel
            // 
            this.InlandLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InlandLabel.AutoSize = true;
            this.InlandLabel.Location = new System.Drawing.Point(32, 7);
            this.InlandLabel.Name = "InlandLabel";
            this.InlandLabel.Size = new System.Drawing.Size(39, 13);
            this.InlandLabel.TabIndex = 9;
            this.InlandLabel.Text = "Inland:";
            // 
            // ObjektLabel
            // 
            this.ObjektLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ObjektLabel.AutoSize = true;
            this.ObjektLabel.Location = new System.Drawing.Point(82, 38);
            this.ObjektLabel.Name = "ObjektLabel";
            this.ObjektLabel.Size = new System.Drawing.Size(41, 13);
            this.ObjektLabel.TabIndex = 4;
            this.ObjektLabel.Text = "Objekt:";
            // 
            // AnsprechpartnerLabel
            // 
            this.AnsprechpartnerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AnsprechpartnerLabel.AutoSize = true;
            this.AnsprechpartnerLabel.Location = new System.Drawing.Point(35, 67);
            this.AnsprechpartnerLabel.Name = "AnsprechpartnerLabel";
            this.AnsprechpartnerLabel.Size = new System.Drawing.Size(88, 13);
            this.AnsprechpartnerLabel.TabIndex = 5;
            this.AnsprechpartnerLabel.Text = "Ansprechpartner:";
            // 
            // BearbeiterLabel
            // 
            this.BearbeiterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BearbeiterLabel.AutoSize = true;
            this.BearbeiterLabel.Location = new System.Drawing.Point(37, 96);
            this.BearbeiterLabel.Name = "BearbeiterLabel";
            this.BearbeiterLabel.Size = new System.Drawing.Size(86, 13);
            this.BearbeiterLabel.TabIndex = 6;
            this.BearbeiterLabel.Text = "Bearbeiter(EDV):";
            // 
            // GesamtmengeLabel
            // 
            this.GesamtmengeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GesamtmengeLabel.AutoSize = true;
            this.GesamtmengeLabel.Location = new System.Drawing.Point(45, 125);
            this.GesamtmengeLabel.Name = "GesamtmengeLabel";
            this.GesamtmengeLabel.Size = new System.Drawing.Size(78, 13);
            this.GesamtmengeLabel.TabIndex = 7;
            this.GesamtmengeLabel.Text = "Gesamtmenge:";
            // 
            // AufteilungLabel
            // 
            this.AufteilungLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AufteilungLabel.AutoSize = true;
            this.AufteilungLabel.Location = new System.Drawing.Point(66, 171);
            this.AufteilungLabel.Name = "AufteilungLabel";
            this.AufteilungLabel.Size = new System.Drawing.Size(57, 13);
            this.AufteilungLabel.TabIndex = 8;
            this.AufteilungLabel.Text = "Aufteilung:";
            // 
            // ResteLabel
            // 
            this.ResteLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResteLabel.AutoSize = true;
            this.ResteLabel.Location = new System.Drawing.Point(70, 218);
            this.ResteLabel.Name = "ResteLabel";
            this.ResteLabel.Size = new System.Drawing.Size(53, 13);
            this.ResteLabel.TabIndex = 9;
            this.ResteLabel.Text = "Reste an:";
            // 
            // OrderCustomerInput
            // 
            this.OrderCustomerInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderCustomerInput.Location = new System.Drawing.Point(131, 5);
            this.OrderCustomerInput.Name = "OrderCustomerInput";
            this.OrderCustomerInput.Size = new System.Drawing.Size(239, 20);
            this.OrderCustomerInput.TabIndex = 13;
            // 
            // OrderObjectInput
            // 
            this.OrderObjectInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderObjectInput.Location = new System.Drawing.Point(131, 34);
            this.OrderObjectInput.Name = "OrderObjectInput";
            this.OrderObjectInput.Size = new System.Drawing.Size(239, 20);
            this.OrderObjectInput.TabIndex = 14;
            // 
            // OrderConsultantInput
            // 
            this.OrderConsultantInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderConsultantInput.Location = new System.Drawing.Point(131, 63);
            this.OrderConsultantInput.Name = "OrderConsultantInput";
            this.OrderConsultantInput.Size = new System.Drawing.Size(239, 20);
            this.OrderConsultantInput.TabIndex = 15;
            // 
            // OrderEditorInput
            // 
            this.OrderEditorInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEditorInput.Location = new System.Drawing.Point(131, 92);
            this.OrderEditorInput.Name = "OrderEditorInput";
            this.OrderEditorInput.Size = new System.Drawing.Size(239, 20);
            this.OrderEditorInput.TabIndex = 16;
            // 
            // OrderQuantityInput
            // 
            this.OrderQuantityInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderQuantityInput.Location = new System.Drawing.Point(131, 121);
            this.OrderQuantityInput.Name = "OrderQuantityInput";
            this.OrderQuantityInput.Size = new System.Drawing.Size(239, 20);
            this.OrderQuantityInput.TabIndex = 17;
            // 
            // ImportantInfoGrpBox
            // 
            this.ImportantInfoGrpBox.Controls.Add(this.OrderLeftTableLayout);
            this.ImportantInfoGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportantInfoGrpBox.Location = new System.Drawing.Point(3, 3);
            this.ImportantInfoGrpBox.Name = "ImportantInfoGrpBox";
            this.ImportantInfoGrpBox.Size = new System.Drawing.Size(457, 112);
            this.ImportantInfoGrpBox.TabIndex = 10;
            this.ImportantInfoGrpBox.TabStop = false;
            this.ImportantInfoGrpBox.Text = "Wichtige Daten";
            // 
            // OrderLeftTableLayout
            // 
            this.OrderLeftTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.OrderLeftTableLayout.ColumnCount = 4;
            this.OrderLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00554F));
            this.OrderLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.47091F));
            this.OrderLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.51247F));
            this.OrderLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.73407F));
            this.OrderLeftTableLayout.Controls.Add(this.trifft_einLabel, 0, 0);
            this.OrderLeftTableLayout.Controls.Add(this.OrderIncomeDateInput, 1, 0);
            this.OrderLeftTableLayout.Controls.Add(this.OrderEditionInput, 3, 1);
            this.OrderLeftTableLayout.Controls.Add(this.AuflageLabel, 2, 1);
            this.OrderLeftTableLayout.Controls.Add(this.OrderDeadlineInput, 3, 0);
            this.OrderLeftTableLayout.Controls.Add(this.PALLabel, 2, 0);
            this.OrderLeftTableLayout.Controls.Add(this.OrderIncomeTimeInput, 1, 1);
            this.OrderLeftTableLayout.Controls.Add(this.UhrzeitLabel, 0, 1);
            this.OrderLeftTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLeftTableLayout.Location = new System.Drawing.Point(3, 16);
            this.OrderLeftTableLayout.Name = "OrderLeftTableLayout";
            this.OrderLeftTableLayout.RowCount = 2;
            this.OrderLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderLeftTableLayout.Size = new System.Drawing.Size(451, 93);
            this.OrderLeftTableLayout.TabIndex = 2;
            // 
            // trifft_einLabel
            // 
            this.trifft_einLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trifft_einLabel.AutoSize = true;
            this.trifft_einLabel.Location = new System.Drawing.Point(34, 17);
            this.trifft_einLabel.Name = "trifft_einLabel";
            this.trifft_einLabel.Size = new System.Drawing.Size(44, 13);
            this.trifft_einLabel.TabIndex = 4;
            this.trifft_einLabel.Text = "trifft ein:";
            // 
            // OrderIncomeDateInput
            // 
            this.OrderIncomeDateInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderIncomeDateInput.Location = new System.Drawing.Point(86, 13);
            this.OrderIncomeDateInput.Name = "OrderIncomeDateInput";
            this.OrderIncomeDateInput.Size = new System.Drawing.Size(97, 20);
            this.OrderIncomeDateInput.TabIndex = 14;
            // 
            // OrderEditionInput
            // 
            this.OrderEditionInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderEditionInput.Location = new System.Drawing.Point(292, 50);
            this.OrderEditionInput.Name = "OrderEditionInput";
            this.OrderEditionInput.Size = new System.Drawing.Size(117, 37);
            this.OrderEditionInput.TabIndex = 13;
            // 
            // AuflageLabel
            // 
            this.AuflageLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuflageLabel.AutoSize = true;
            this.AuflageLabel.Location = new System.Drawing.Point(238, 62);
            this.AuflageLabel.Name = "AuflageLabel";
            this.AuflageLabel.Size = new System.Drawing.Size(46, 13);
            this.AuflageLabel.TabIndex = 9;
            this.AuflageLabel.Text = "Auflage:";
            // 
            // OrderDeadlineInput
            // 
            this.OrderDeadlineInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderDeadlineInput.Location = new System.Drawing.Point(292, 5);
            this.OrderDeadlineInput.Name = "OrderDeadlineInput";
            this.OrderDeadlineInput.Size = new System.Drawing.Size(117, 36);
            this.OrderDeadlineInput.TabIndex = 5;
            // 
            // PALLabel
            // 
            this.PALLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PALLabel.AutoSize = true;
            this.PALLabel.Location = new System.Drawing.Point(254, 17);
            this.PALLabel.Name = "PALLabel";
            this.PALLabel.Size = new System.Drawing.Size(30, 13);
            this.PALLabel.TabIndex = 3;
            this.PALLabel.Text = "PAL:";
            // 
            // OrderIncomeTimeInput
            // 
            this.OrderIncomeTimeInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderIncomeTimeInput.Location = new System.Drawing.Point(86, 59);
            this.OrderIncomeTimeInput.Name = "OrderIncomeTimeInput";
            this.OrderIncomeTimeInput.Size = new System.Drawing.Size(97, 20);
            this.OrderIncomeTimeInput.TabIndex = 17;
            // 
            // UhrzeitLabel
            // 
            this.UhrzeitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UhrzeitLabel.AutoSize = true;
            this.UhrzeitLabel.Location = new System.Drawing.Point(35, 62);
            this.UhrzeitLabel.Name = "UhrzeitLabel";
            this.UhrzeitLabel.Size = new System.Drawing.Size(43, 13);
            this.UhrzeitLabel.TabIndex = 16;
            this.UhrzeitLabel.Text = "Uhrzeit:";
            // 
            // TopRightTableLayout
            // 
            this.TopRightTableLayout.ColumnCount = 3;
            this.TopRightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.38818F));
            this.TopRightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.57732F));
            this.TopRightTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.18557F));
            this.TopRightTableLayout.Controls.Add(this.FunctionGrpBox, 0, 0);
            this.TopRightTableLayout.Controls.Add(this.ImportantInfo2GrpBox, 0, 0);
            this.TopRightTableLayout.Controls.Add(this.PrintGrpBox, 1, 0);
            this.TopRightTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRightTableLayout.Location = new System.Drawing.Point(466, 3);
            this.TopRightTableLayout.Name = "TopRightTableLayout";
            this.TopRightTableLayout.RowCount = 1;
            this.TopRightTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopRightTableLayout.Size = new System.Drawing.Size(511, 112);
            this.TopRightTableLayout.TabIndex = 11;
            // 
            // FunctionGrpBox
            // 
            this.FunctionGrpBox.Controls.Add(this.TopRight3rdTableLayout);
            this.FunctionGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionGrpBox.Location = new System.Drawing.Point(214, 3);
            this.FunctionGrpBox.Name = "FunctionGrpBox";
            this.FunctionGrpBox.Size = new System.Drawing.Size(134, 106);
            this.FunctionGrpBox.TabIndex = 14;
            this.FunctionGrpBox.TabStop = false;
            this.FunctionGrpBox.Text = "Funktionen";
            // 
            // TopRight3rdTableLayout
            // 
            this.TopRight3rdTableLayout.ColumnCount = 1;
            this.TopRight3rdTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRight3rdTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopRight3rdTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopRight3rdTableLayout.Controls.Add(this.Editbutton, 0, 0);
            this.TopRight3rdTableLayout.Controls.Add(this.StatusChangeButton, 0, 1);
            this.TopRight3rdTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRight3rdTableLayout.Location = new System.Drawing.Point(3, 16);
            this.TopRight3rdTableLayout.Name = "TopRight3rdTableLayout";
            this.TopRight3rdTableLayout.RowCount = 2;
            this.TopRight3rdTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRight3rdTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRight3rdTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopRight3rdTableLayout.Size = new System.Drawing.Size(128, 87);
            this.TopRight3rdTableLayout.TabIndex = 4;
            // 
            // Editbutton
            // 
            this.Editbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editbutton.Location = new System.Drawing.Point(3, 3);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(122, 37);
            this.Editbutton.TabIndex = 15;
            this.Editbutton.Text = "Bearbeiten";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // StatusChangeButton
            // 
            this.StatusChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusChangeButton.Location = new System.Drawing.Point(3, 46);
            this.StatusChangeButton.Name = "StatusChangeButton";
            this.StatusChangeButton.Size = new System.Drawing.Size(122, 38);
            this.StatusChangeButton.TabIndex = 16;
            this.StatusChangeButton.Text = "Klonen";
            this.StatusChangeButton.UseVisualStyleBackColor = true;
            this.StatusChangeButton.Click += new System.EventHandler(this.CloneOrder);
            // 
            // ImportantInfo2GrpBox
            // 
            this.ImportantInfo2GrpBox.Controls.Add(this.OrderRight1TableLayout);
            this.ImportantInfo2GrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportantInfo2GrpBox.Location = new System.Drawing.Point(3, 3);
            this.ImportantInfo2GrpBox.Name = "ImportantInfo2GrpBox";
            this.ImportantInfo2GrpBox.Size = new System.Drawing.Size(205, 106);
            this.ImportantInfo2GrpBox.TabIndex = 12;
            this.ImportantInfo2GrpBox.TabStop = false;
            this.ImportantInfo2GrpBox.Text = "Details";
            // 
            // OrderRight1TableLayout
            // 
            this.OrderRight1TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.OrderRight1TableLayout.ColumnCount = 2;
            this.OrderRight1TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OrderRight1TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OrderRight1TableLayout.Controls.Add(this.AuftragsNrLabel, 0, 1);
            this.OrderRight1TableLayout.Controls.Add(this.OrderNumberInput, 1, 1);
            this.OrderRight1TableLayout.Controls.Add(this.AuftragLabel, 0, 0);
            this.OrderRight1TableLayout.Controls.Add(this.OrderNameInput, 1, 0);
            this.OrderRight1TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderRight1TableLayout.Location = new System.Drawing.Point(3, 16);
            this.OrderRight1TableLayout.Name = "OrderRight1TableLayout";
            this.OrderRight1TableLayout.RowCount = 2;
            this.OrderRight1TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderRight1TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderRight1TableLayout.Size = new System.Drawing.Size(199, 87);
            this.OrderRight1TableLayout.TabIndex = 3;
            // 
            // AuftragsNrLabel
            // 
            this.AuftragsNrLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuftragsNrLabel.AutoSize = true;
            this.AuftragsNrLabel.Location = new System.Drawing.Point(29, 58);
            this.AuftragsNrLabel.Name = "AuftragsNrLabel";
            this.AuftragsNrLabel.Size = new System.Drawing.Size(66, 13);
            this.AuftragsNrLabel.TabIndex = 11;
            this.AuftragsNrLabel.Text = "Auftrags-Nr.:";
            // 
            // OrderNumberInput
            // 
            this.OrderNumberInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderNumberInput.Location = new System.Drawing.Point(103, 54);
            this.OrderNumberInput.Name = "OrderNumberInput";
            this.OrderNumberInput.Size = new System.Drawing.Size(91, 20);
            this.OrderNumberInput.TabIndex = 13;
            // 
            // AuftragLabel
            // 
            this.AuftragLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AuftragLabel.AutoSize = true;
            this.AuftragLabel.Location = new System.Drawing.Point(51, 15);
            this.AuftragLabel.Name = "AuftragLabel";
            this.AuftragLabel.Size = new System.Drawing.Size(44, 13);
            this.AuftragLabel.TabIndex = 2;
            this.AuftragLabel.Text = "Auftrag:";
            // 
            // OrderNameInput
            // 
            this.OrderNameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderNameInput.Location = new System.Drawing.Point(103, 12);
            this.OrderNameInput.Name = "OrderNameInput";
            this.OrderNameInput.Size = new System.Drawing.Size(91, 20);
            this.OrderNameInput.TabIndex = 4;
            // 
            // PrintGrpBox
            // 
            this.PrintGrpBox.Controls.Add(this.OrderRight2TableLayout);
            this.PrintGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintGrpBox.Location = new System.Drawing.Point(354, 3);
            this.PrintGrpBox.Name = "PrintGrpBox";
            this.PrintGrpBox.Size = new System.Drawing.Size(154, 106);
            this.PrintGrpBox.TabIndex = 13;
            this.PrintGrpBox.TabStop = false;
            this.PrintGrpBox.Text = "Drucken";
            // 
            // OrderRight2TableLayout
            // 
            this.OrderRight2TableLayout.ColumnCount = 1;
            this.OrderRight2TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderRight2TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderRight2TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderRight2TableLayout.Controls.Add(this.PrintOrderFolderButton, 0, 0);
            this.OrderRight2TableLayout.Controls.Add(this.PrintLaufzettelButton, 0, 1);
            this.OrderRight2TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderRight2TableLayout.Location = new System.Drawing.Point(3, 16);
            this.OrderRight2TableLayout.Name = "OrderRight2TableLayout";
            this.OrderRight2TableLayout.RowCount = 2;
            this.OrderRight2TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderRight2TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderRight2TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderRight2TableLayout.Size = new System.Drawing.Size(148, 87);
            this.OrderRight2TableLayout.TabIndex = 4;
            // 
            // PrintOrderFolderButton
            // 
            this.PrintOrderFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintOrderFolderButton.Location = new System.Drawing.Point(3, 3);
            this.PrintOrderFolderButton.Name = "PrintOrderFolderButton";
            this.PrintOrderFolderButton.Size = new System.Drawing.Size(142, 37);
            this.PrintOrderFolderButton.TabIndex = 15;
            this.PrintOrderFolderButton.Text = "Auftragsmappe";
            this.PrintOrderFolderButton.UseVisualStyleBackColor = true;
            this.PrintOrderFolderButton.Click += new System.EventHandler(this.PrintOrder);
            // 
            // PrintLaufzettelButton
            // 
            this.PrintLaufzettelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintLaufzettelButton.Location = new System.Drawing.Point(3, 46);
            this.PrintLaufzettelButton.Name = "PrintLaufzettelButton";
            this.PrintLaufzettelButton.Size = new System.Drawing.Size(142, 38);
            this.PrintLaufzettelButton.TabIndex = 16;
            this.PrintLaufzettelButton.Text = "Laufzettel";
            this.PrintLaufzettelButton.UseVisualStyleBackColor = true;
            this.PrintLaufzettelButton.Click += new System.EventHandler(this.PrintLaufzettelButton_Click);
            // 
            // OrderTabLeftTableLayout
            // 
            this.OrderTabLeftTableLayout.ColumnCount = 1;
            this.OrderTabLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderTabLeftTableLayout.Controls.Add(this.ActiveOrderGrpBox, 0, 1);
            this.OrderTabLeftTableLayout.Controls.Add(this.OrderTabLeftTopTableLayout, 0, 0);
            this.OrderTabLeftTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTabLeftTableLayout.Location = new System.Drawing.Point(3, 3);
            this.OrderTabLeftTableLayout.Name = "OrderTabLeftTableLayout";
            this.OrderTabLeftTableLayout.RowCount = 2;
            this.OrderTabLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.108202F));
            this.OrderTabLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.8918F));
            this.OrderTabLeftTableLayout.Size = new System.Drawing.Size(350, 679);
            this.OrderTabLeftTableLayout.TabIndex = 2;
            // 
            // ActiveOrderGrpBox
            // 
            this.ActiveOrderGrpBox.Controls.Add(this.SelectedOrderListBox);
            this.ActiveOrderGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveOrderGrpBox.Location = new System.Drawing.Point(3, 44);
            this.ActiveOrderGrpBox.Name = "ActiveOrderGrpBox";
            this.ActiveOrderGrpBox.Size = new System.Drawing.Size(344, 632);
            this.ActiveOrderGrpBox.TabIndex = 4;
            this.ActiveOrderGrpBox.TabStop = false;
            this.ActiveOrderGrpBox.Text = "Aufträge";
            // 
            // SelectedOrderListBox
            // 
            this.SelectedOrderListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedOrderListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedOrderListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedOrderListBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedOrderListBox.FormattingEnabled = true;
            this.SelectedOrderListBox.ItemHeight = 24;
            this.SelectedOrderListBox.Location = new System.Drawing.Point(3, 16);
            this.SelectedOrderListBox.Name = "SelectedOrderListBox";
            this.SelectedOrderListBox.Size = new System.Drawing.Size(338, 613);
            this.SelectedOrderListBox.TabIndex = 0;
            this.SelectedOrderListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedOrderListBox_SelectedIndexChanged);
            // 
            // OrderTabLeftTopTableLayout
            // 
            this.OrderTabLeftTopTableLayout.ColumnCount = 2;
            this.OrderTabLeftTopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02089F));
            this.OrderTabLeftTopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.97911F));
            this.OrderTabLeftTopTableLayout.Controls.Add(this.OrderSelectFilterInput, 1, 0);
            this.OrderTabLeftTopTableLayout.Controls.Add(this.OrderSelectFilterLabel, 0, 0);
            this.OrderTabLeftTopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTabLeftTopTableLayout.Location = new System.Drawing.Point(3, 3);
            this.OrderTabLeftTopTableLayout.Name = "OrderTabLeftTopTableLayout";
            this.OrderTabLeftTopTableLayout.RowCount = 1;
            this.OrderTabLeftTopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderTabLeftTopTableLayout.Size = new System.Drawing.Size(344, 35);
            this.OrderTabLeftTopTableLayout.TabIndex = 0;
            // 
            // OrderSelectFilterInput
            // 
            this.OrderSelectFilterInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OrderSelectFilterInput.Location = new System.Drawing.Point(85, 7);
            this.OrderSelectFilterInput.Name = "OrderSelectFilterInput";
            this.OrderSelectFilterInput.Size = new System.Drawing.Size(256, 20);
            this.OrderSelectFilterInput.TabIndex = 0;
            this.OrderSelectFilterInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OrderSelectFilterInput_KeyUp);
            // 
            // OrderSelectFilterLabel
            // 
            this.OrderSelectFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrderSelectFilterLabel.AutoSize = true;
            this.OrderSelectFilterLabel.Location = new System.Drawing.Point(34, 4);
            this.OrderSelectFilterLabel.Name = "OrderSelectFilterLabel";
            this.OrderSelectFilterLabel.Size = new System.Drawing.Size(45, 26);
            this.OrderSelectFilterLabel.TabIndex = 1;
            this.OrderSelectFilterLabel.Text = "Auftrag suchen:";
            // 
            // MainFrameMenu
            // 
            this.MainFrameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFolderMenuItem,
            this.benutzerToolStripMenuItem});
            this.MainFrameMenu.Location = new System.Drawing.Point(3, 3);
            this.MainFrameMenu.Name = "MainFrameMenu";
            this.MainFrameMenu.Size = new System.Drawing.Size(1348, 24);
            this.MainFrameMenu.TabIndex = 2;
            this.MainFrameMenu.Text = "menuStrip1";
            // 
            // NewFolderMenuItem
            // 
            this.NewFolderMenuItem.Name = "NewFolderMenuItem";
            this.NewFolderMenuItem.Size = new System.Drawing.Size(132, 20);
            this.NewFolderMenuItem.Text = "Neue Auftragsmappe";
            this.NewFolderMenuItem.Click += new System.EventHandler(this.NewFolderMenuItem_Click);
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuenBenutzerAnlegenToolStripMenuItem});
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            this.benutzerToolStripMenuItem.Visible = false;
            // 
            // neuenBenutzerAnlegenToolStripMenuItem
            // 
            this.neuenBenutzerAnlegenToolStripMenuItem.Name = "neuenBenutzerAnlegenToolStripMenuItem";
            this.neuenBenutzerAnlegenToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.neuenBenutzerAnlegenToolStripMenuItem.Text = "Neuen Benutzer Anlegen";
            this.neuenBenutzerAnlegenToolStripMenuItem.Click += new System.EventHandler(this.neuenBenutzerAnlegenToolStripMenuItem_Click);
            // 
            // MainFrameTabControl
            // 
            this.MainFrameTabControl.Controls.Add(this.OrderTab);
            this.MainFrameTabControl.Controls.Add(this.MachineTab);
            this.MainFrameTabControl.Controls.Add(this.FileArchivTab);
            this.MainFrameTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFrameTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainFrameTabControl.Name = "MainFrameTabControl";
            this.MainFrameTabControl.SelectedIndex = 0;
            this.MainFrameTabControl.Size = new System.Drawing.Size(1362, 741);
            this.MainFrameTabControl.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.MainFrameTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainFrameMenu;
            this.Name = "MainFrame";
            this.Text = "Auftragsmanager";
            this.FileArchivTab.ResumeLayout(false);
            this.ArchivMainTableLayout.ResumeLayout(false);
            this.FileSeachTableLayout.ResumeLayout(false);
            this.FileSeachTableLayout.PerformLayout();
            this.DirSearchTableLayout.ResumeLayout(false);
            this.DirSearchTableLayout.PerformLayout();
            this.FileDisplayTableLayout.ResumeLayout(false);
            this.filesFromOrderGrpbox.ResumeLayout(false);
            this.FileBtnTableLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.orderFileGrpBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.MachineTab.ResumeLayout(false);
            this.MachineTab.PerformLayout();
            this.MachineMenu.ResumeLayout(false);
            this.MachineMenu.PerformLayout();
            this.OrderTab.ResumeLayout(false);
            this.OrderTab.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.PreviewOrderGrpBox.ResumeLayout(false);
            this.OrderDisplayMainTableLayout.ResumeLayout(false);
            this.EDVGrpBox.ResumeLayout(false);
            this.EDVTableLayout.ResumeLayout(false);
            this.EDVTableLayout.PerformLayout();
            this.ProudctionTimeTableLayout.ResumeLayout(false);
            this.ProudctionTimeTableLayout.PerformLayout();
            this.ProductionGrpBox.ResumeLayout(false);
            this.ProduktionTableLayout.ResumeLayout(false);
            this.ProduktionTableLayout.PerformLayout();
            this.VerarbeitungTableLayout.ResumeLayout(false);
            this.VerarbeitungTableLayout.PerformLayout();
            this.InfoGrpBox.ResumeLayout(false);
            this.ZusatzTableLayout.ResumeLayout(false);
            this.ZusatzTableLayout.PerformLayout();
            this.AuftragsdatenGrpBox.ResumeLayout(false);
            this.CustomerTableLayout.ResumeLayout(false);
            this.CustomerTableLayout.PerformLayout();
            this.AufteilungTableLayout.ResumeLayout(false);
            this.AufteilungTableLayout.PerformLayout();
            this.ImportantInfoGrpBox.ResumeLayout(false);
            this.OrderLeftTableLayout.ResumeLayout(false);
            this.OrderLeftTableLayout.PerformLayout();
            this.TopRightTableLayout.ResumeLayout(false);
            this.FunctionGrpBox.ResumeLayout(false);
            this.TopRight3rdTableLayout.ResumeLayout(false);
            this.ImportantInfo2GrpBox.ResumeLayout(false);
            this.OrderRight1TableLayout.ResumeLayout(false);
            this.OrderRight1TableLayout.PerformLayout();
            this.PrintGrpBox.ResumeLayout(false);
            this.OrderRight2TableLayout.ResumeLayout(false);
            this.OrderTabLeftTableLayout.ResumeLayout(false);
            this.ActiveOrderGrpBox.ResumeLayout(false);
            this.OrderTabLeftTopTableLayout.ResumeLayout(false);
            this.OrderTabLeftTopTableLayout.PerformLayout();
            this.MainFrameMenu.ResumeLayout(false);
            this.MainFrameMenu.PerformLayout();
            this.MainFrameTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage FileArchivTab;
        private System.Windows.Forms.TableLayoutPanel ArchivMainTableLayout;
        private System.Windows.Forms.TableLayoutPanel FileSeachTableLayout;
        private System.Windows.Forms.Label FileSeachLabel;
        private System.Windows.Forms.TextBox FileSeachFilterInput;
        private System.Windows.Forms.TableLayoutPanel DirSearchTableLayout;
        private System.Windows.Forms.Label DirSearchLabel;
        private System.Windows.Forms.TextBox DirSearchFilterInput;
        private System.Windows.Forms.TableLayoutPanel FileDisplayTableLayout;
        private System.Windows.Forms.GroupBox filesFromOrderGrpbox;
        private System.Windows.Forms.ListBox MainFrameFileListBox;
        private System.Windows.Forms.TableLayoutPanel FileBtnTableLayout;
        private System.Windows.Forms.Button DownloadFileButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox orderFileGrpBox;
        private System.Windows.Forms.ListBox MainFrameDirListBox;
        private System.Windows.Forms.TabPage MachineTab;
        private Braincase.GanttChart.Chart MachineUsageChart;
        private System.Windows.Forms.MenuStrip MachineMenu;
        private System.Windows.Forms.ToolStripMenuItem NewMachineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMachineCreateSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMachineMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefectMachineSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMachineNameSubMenuItem;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox PreviewOrderGrpBox;
        private System.Windows.Forms.TableLayoutPanel OrderDisplayMainTableLayout;
        private System.Windows.Forms.GroupBox EDVGrpBox;
        private System.Windows.Forms.TableLayoutPanel EDVTableLayout;
        private System.Windows.Forms.Label Taetigkeit1Label;
        private System.Windows.Forms.Label ProduktionszeitLabel;
        private System.Windows.Forms.Label MaschineLabel;
        private System.Windows.Forms.Label Taetigkeit2Label;
        private System.Windows.Forms.Label Taetigkeit3Label;
        private System.Windows.Forms.Label Taetigkeit4Label;
        private System.Windows.Forms.Label Taetigkeit5Label;
        private System.Windows.Forms.Label Taetigkeit6Label;
        private System.Windows.Forms.Label OrderEDVJob1Input;
        private System.Windows.Forms.Label OrderEDVJob2Input;
        private System.Windows.Forms.Label OrderEDVJob3Input;
        private System.Windows.Forms.Label OrderEDVJob4Input;
        private System.Windows.Forms.Label OrderEDVJob5Input;
        private System.Windows.Forms.Label OrderEDVJob6Input;
        private System.Windows.Forms.Label MaschineSelectInput;
        private System.Windows.Forms.GroupBox ProductionGrpBox;
        private System.Windows.Forms.TableLayoutPanel ProduktionTableLayout;
        private System.Windows.Forms.Label OrderInsertKindInput;
        private System.Windows.Forms.Label OrderInsertInput;
        private System.Windows.Forms.Label OrderProJob6Input;
        private System.Windows.Forms.Label OrderProJob5Input;
        private System.Windows.Forms.Label OrderProJob4Input;
        private System.Windows.Forms.Label OrderProJob3Input;
        private System.Windows.Forms.Label OrderProJob2Input;
        private System.Windows.Forms.Label OrderProJob1Input;
        private System.Windows.Forms.Label Taetigkeit12Label;
        private System.Windows.Forms.Label Taetigkeit11Label;
        private System.Windows.Forms.Label Taetigkeit10Label;
        private System.Windows.Forms.Label Taetigkeit9Label;
        private System.Windows.Forms.Label Taetigkeit8Label;
        private System.Windows.Forms.Label Taetigkeit7Label;
        private System.Windows.Forms.TableLayoutPanel VerarbeitungTableLayout;
        private System.Windows.Forms.CheckBox folierenCBInput;
        private System.Windows.Forms.CheckBox inkenCBInput;
        private System.Windows.Forms.CheckBox kuvertierenCBInput;
        private System.Windows.Forms.Label VerarbeitungLabel;
        private System.Windows.Forms.Label BeilagenLabel;
        private System.Windows.Forms.Label BeilagenartLabel;
        private System.Windows.Forms.GroupBox InfoGrpBox;
        private System.Windows.Forms.TableLayoutPanel ZusatzTableLayout;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label Zusatz_InfosLabel;
        private System.Windows.Forms.Label RechnungLabel;
        private System.Windows.Forms.Label OrderInfoInput;
        private System.Windows.Forms.Label OrderBillInput;
        private System.Windows.Forms.Label OrderMaterialInput;
        private System.Windows.Forms.GroupBox AuftragsdatenGrpBox;
        private System.Windows.Forms.TableLayoutPanel CustomerTableLayout;
        private System.Windows.Forms.Label OrderRemainsInput;
        private System.Windows.Forms.Label KundeLabel;
        private System.Windows.Forms.TableLayoutPanel AufteilungTableLayout;
        private System.Windows.Forms.Label OrderForeignInput;
        private System.Windows.Forms.Label OrderInlandInput;
        private System.Windows.Forms.Label AuslandLabel;
        private System.Windows.Forms.Label InlandLabel;
        private System.Windows.Forms.Label ObjektLabel;
        private System.Windows.Forms.Label AnsprechpartnerLabel;
        private System.Windows.Forms.Label BearbeiterLabel;
        private System.Windows.Forms.Label GesamtmengeLabel;
        private System.Windows.Forms.Label AufteilungLabel;
        private System.Windows.Forms.Label ResteLabel;
        private System.Windows.Forms.Label OrderCustomerInput;
        private System.Windows.Forms.Label OrderObjectInput;
        private System.Windows.Forms.Label OrderConsultantInput;
        private System.Windows.Forms.Label OrderEditorInput;
        private System.Windows.Forms.Label OrderQuantityInput;
        private System.Windows.Forms.GroupBox ImportantInfoGrpBox;
        private System.Windows.Forms.TableLayoutPanel OrderLeftTableLayout;
        private System.Windows.Forms.Label trifft_einLabel;
        private System.Windows.Forms.Label OrderIncomeDateInput;
        private System.Windows.Forms.Label OrderEditionInput;
        private System.Windows.Forms.Label AuflageLabel;
        private System.Windows.Forms.Label OrderDeadlineInput;
        private System.Windows.Forms.Label PALLabel;
        private System.Windows.Forms.Label OrderIncomeTimeInput;
        private System.Windows.Forms.Label UhrzeitLabel;
        private System.Windows.Forms.TableLayoutPanel TopRightTableLayout;
        private System.Windows.Forms.GroupBox FunctionGrpBox;
        private System.Windows.Forms.TableLayoutPanel TopRight3rdTableLayout;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button StatusChangeButton;
        private System.Windows.Forms.GroupBox ImportantInfo2GrpBox;
        private System.Windows.Forms.TableLayoutPanel OrderRight1TableLayout;
        private System.Windows.Forms.Label AuftragsNrLabel;
        private System.Windows.Forms.Label OrderNumberInput;
        private System.Windows.Forms.Label AuftragLabel;
        private System.Windows.Forms.Label OrderNameInput;
        private System.Windows.Forms.GroupBox PrintGrpBox;
        private System.Windows.Forms.TableLayoutPanel OrderRight2TableLayout;
        private System.Windows.Forms.Button PrintOrderFolderButton;
        private System.Windows.Forms.Button PrintLaufzettelButton;
        private System.Windows.Forms.TableLayoutPanel OrderTabLeftTableLayout;
        private System.Windows.Forms.GroupBox ActiveOrderGrpBox;
        private System.Windows.Forms.TableLayoutPanel OrderTabLeftTopTableLayout;
        private System.Windows.Forms.TextBox OrderSelectFilterInput;
        private System.Windows.Forms.Label OrderSelectFilterLabel;
        private System.Windows.Forms.MenuStrip MainFrameMenu;
        private System.Windows.Forms.ToolStripMenuItem NewFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenBenutzerAnlegenToolStripMenuItem;
        private System.Windows.Forms.TabControl MainFrameTabControl;
        private System.Windows.Forms.TableLayoutPanel ProudctionTimeTableLayout;
        private System.Windows.Forms.Label StartLabelDisplay;
        private System.Windows.Forms.Label StartMachineUsagesLabel;
        private System.Windows.Forms.Label EndMachineUsagesLabel;
        private System.Windows.Forms.Label endLabelDisplay;
        private System.Windows.Forms.Label OrderMaxProTimeInput;
        private System.Windows.Forms.ListBox SelectedOrderListBox;
        private System.Windows.Forms.ToolStripMenuItem anzeigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maschinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeitraumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gesammtToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button refeshListButton;
        private System.Windows.Forms.Button DownloadDirButton;
    }
}

