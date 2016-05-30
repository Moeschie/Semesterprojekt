namespace View
{
    partial class MaschineFrame
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
            this.MachineControllTabControll = new System.Windows.Forms.TabControl();
            this.MachineMonitorTab = new System.Windows.Forms.TabPage();
            this.MaschineUsagesGrpBox = new System.Windows.Forms.GroupBox();
            this.MachineUsageChart = new Braincase.GanttChart.Chart();
            this.MachineControllTab = new System.Windows.Forms.TabPage();
            this.MaschineOptionGrpBox = new System.Windows.Forms.GroupBox();
            this.EditMachineCreateMachineGroupBox = new System.Windows.Forms.GroupBox();
            this.NewMachineSaveButton = new System.Windows.Forms.Button();
            this.NewMachineNameTextBox = new System.Windows.Forms.TextBox();
            this.NewMachineNameLabel = new System.Windows.Forms.Label();
            this.EditMachineGroupBox = new System.Windows.Forms.GroupBox();
            this.EditMachineSelectMachineDropDown = new System.Windows.Forms.ComboBox();
            this.EditMachineDefectEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EditMachineDefefctStartLabel = new System.Windows.Forms.Label();
            this.EditMachineDefefctEndLabel = new System.Windows.Forms.Label();
            this.EditMachineDefectStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EditMachineSaveChanegesButton = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.MachineControllTabControll.SuspendLayout();
            this.MachineMonitorTab.SuspendLayout();
            this.MaschineUsagesGrpBox.SuspendLayout();
            this.MachineControllTab.SuspendLayout();
            this.MaschineOptionGrpBox.SuspendLayout();
            this.EditMachineCreateMachineGroupBox.SuspendLayout();
            this.EditMachineGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MachineControllTabControll
            // 
            this.MachineControllTabControll.Controls.Add(this.MachineMonitorTab);
            this.MachineControllTabControll.Controls.Add(this.MachineControllTab);
            this.MachineControllTabControll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineControllTabControll.Location = new System.Drawing.Point(0, 0);
            this.MachineControllTabControll.Name = "MachineControllTabControll";
            this.MachineControllTabControll.SelectedIndex = 0;
            this.MachineControllTabControll.Size = new System.Drawing.Size(1144, 626);
            this.MachineControllTabControll.TabIndex = 0;
            // 
            // MachineMonitorTab
            // 
            this.MachineMonitorTab.Controls.Add(this.MaschineUsagesGrpBox);
            this.MachineMonitorTab.Location = new System.Drawing.Point(4, 22);
            this.MachineMonitorTab.Name = "MachineMonitorTab";
            this.MachineMonitorTab.Padding = new System.Windows.Forms.Padding(3);
            this.MachineMonitorTab.Size = new System.Drawing.Size(1136, 600);
            this.MachineMonitorTab.TabIndex = 0;
            this.MachineMonitorTab.Text = "Maschinen Monitor";
            this.MachineMonitorTab.UseVisualStyleBackColor = true;
            // 
            // MaschineUsagesGrpBox
            // 
            this.MaschineUsagesGrpBox.Controls.Add(this.MachineUsageChart);
            this.MaschineUsagesGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaschineUsagesGrpBox.Location = new System.Drawing.Point(3, 3);
            this.MaschineUsagesGrpBox.Name = "MaschineUsagesGrpBox";
            this.MaschineUsagesGrpBox.Size = new System.Drawing.Size(1130, 594);
            this.MaschineUsagesGrpBox.TabIndex = 3;
            this.MaschineUsagesGrpBox.TabStop = false;
            this.MaschineUsagesGrpBox.Text = "Maschinen Nutzung";
            // 
            // MachineUsageChart
            // 
            this.MachineUsageChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineUsageChart.FullDateStringFormat = null;
            this.MachineUsageChart.Location = new System.Drawing.Point(3, 16);
            this.MachineUsageChart.Margin = new System.Windows.Forms.Padding(0);
            this.MachineUsageChart.Name = "MachineUsageChart";
            this.MachineUsageChart.Size = new System.Drawing.Size(1124, 575);
            this.MachineUsageChart.TabIndex = 2;
            // 
            // MachineControllTab
            // 
            this.MachineControllTab.Controls.Add(this.MaschineOptionGrpBox);
            this.MachineControllTab.Location = new System.Drawing.Point(4, 22);
            this.MachineControllTab.Name = "MachineControllTab";
            this.MachineControllTab.Padding = new System.Windows.Forms.Padding(3);
            this.MachineControllTab.Size = new System.Drawing.Size(1136, 600);
            this.MachineControllTab.TabIndex = 1;
            this.MachineControllTab.Text = "Maschinenverwaltung";
            this.MachineControllTab.UseVisualStyleBackColor = true;
            // 
            // MaschineOptionGrpBox
            // 
            this.MaschineOptionGrpBox.Controls.Add(this.EditMachineCreateMachineGroupBox);
            this.MaschineOptionGrpBox.Controls.Add(this.EditMachineGroupBox);
            this.MaschineOptionGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaschineOptionGrpBox.Location = new System.Drawing.Point(3, 3);
            this.MaschineOptionGrpBox.Name = "MaschineOptionGrpBox";
            this.MaschineOptionGrpBox.Size = new System.Drawing.Size(1130, 594);
            this.MaschineOptionGrpBox.TabIndex = 4;
            this.MaschineOptionGrpBox.TabStop = false;
            this.MaschineOptionGrpBox.Text = "Maschinenverwaltung";
            // 
            // EditMachineCreateMachineGroupBox
            // 
            this.EditMachineCreateMachineGroupBox.Controls.Add(this.NewMachineSaveButton);
            this.EditMachineCreateMachineGroupBox.Controls.Add(this.NewMachineNameTextBox);
            this.EditMachineCreateMachineGroupBox.Controls.Add(this.NewMachineNameLabel);
            this.EditMachineCreateMachineGroupBox.Location = new System.Drawing.Point(533, 19);
            this.EditMachineCreateMachineGroupBox.Name = "EditMachineCreateMachineGroupBox";
            this.EditMachineCreateMachineGroupBox.Size = new System.Drawing.Size(521, 569);
            this.EditMachineCreateMachineGroupBox.TabIndex = 12;
            this.EditMachineCreateMachineGroupBox.TabStop = false;
            this.EditMachineCreateMachineGroupBox.Text = "Neue Maschine";
            // 
            // NewMachineSaveButton
            // 
            this.NewMachineSaveButton.Location = new System.Drawing.Point(76, 90);
            this.NewMachineSaveButton.Name = "NewMachineSaveButton";
            this.NewMachineSaveButton.Size = new System.Drawing.Size(75, 23);
            this.NewMachineSaveButton.TabIndex = 11;
            this.NewMachineSaveButton.Text = "Speichern";
            this.NewMachineSaveButton.UseVisualStyleBackColor = true;
            // 
            // NewMachineNameTextBox
            // 
            this.NewMachineNameTextBox.Location = new System.Drawing.Point(51, 57);
            this.NewMachineNameTextBox.Name = "NewMachineNameTextBox";
            this.NewMachineNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewMachineNameTextBox.TabIndex = 5;
            // 
            // NewMachineNameLabel
            // 
            this.NewMachineNameLabel.AutoSize = true;
            this.NewMachineNameLabel.Location = new System.Drawing.Point(48, 41);
            this.NewMachineNameLabel.Name = "NewMachineNameLabel";
            this.NewMachineNameLabel.Size = new System.Drawing.Size(35, 13);
            this.NewMachineNameLabel.TabIndex = 4;
            this.NewMachineNameLabel.Text = "Name";
            // 
            // EditMachineGroupBox
            // 
            this.EditMachineGroupBox.Controls.Add(this.EditMachineSelectMachineDropDown);
            this.EditMachineGroupBox.Controls.Add(this.EditMachineDefectEndDatePicker);
            this.EditMachineGroupBox.Controls.Add(this.EditMachineDefefctStartLabel);
            this.EditMachineGroupBox.Controls.Add(this.EditMachineDefefctEndLabel);
            this.EditMachineGroupBox.Controls.Add(this.EditMachineDefectStartDatePicker);
            this.EditMachineGroupBox.Controls.Add(this.EditMachineSaveChanegesButton);
            this.EditMachineGroupBox.Location = new System.Drawing.Point(6, 19);
            this.EditMachineGroupBox.Name = "EditMachineGroupBox";
            this.EditMachineGroupBox.Size = new System.Drawing.Size(521, 569);
            this.EditMachineGroupBox.TabIndex = 11;
            this.EditMachineGroupBox.TabStop = false;
            this.EditMachineGroupBox.Text = "Bearbeiten";
            // 
            // EditMachineSelectMachineDropDown
            // 
            this.EditMachineSelectMachineDropDown.DisplayMember = "Maschine 1";
            this.EditMachineSelectMachineDropDown.FormattingEnabled = true;
            this.EditMachineSelectMachineDropDown.Items.AddRange(new object[] {
            "Maschine 1",
            "Maschine 2",
            "Maschine 3",
            "Maschine 4",
            "Maschine 5",
            "Maschine 6",
            "Maschine 7"});
            this.EditMachineSelectMachineDropDown.Location = new System.Drawing.Point(41, 49);
            this.EditMachineSelectMachineDropDown.Name = "EditMachineSelectMachineDropDown";
            this.EditMachineSelectMachineDropDown.Size = new System.Drawing.Size(162, 21);
            this.EditMachineSelectMachineDropDown.TabIndex = 3;
            // 
            // EditMachineDefectEndDatePicker
            // 
            this.EditMachineDefectEndDatePicker.Location = new System.Drawing.Point(41, 132);
            this.EditMachineDefectEndDatePicker.Name = "EditMachineDefectEndDatePicker";
            this.EditMachineDefectEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EditMachineDefectEndDatePicker.TabIndex = 10;
            // 
            // EditMachineDefefctStartLabel
            // 
            this.EditMachineDefefctStartLabel.AutoSize = true;
            this.EditMachineDefefctStartLabel.Location = new System.Drawing.Point(38, 73);
            this.EditMachineDefefctStartLabel.Name = "EditMachineDefefctStartLabel";
            this.EditMachineDefefctStartLabel.Size = new System.Drawing.Size(61, 13);
            this.EditMachineDefefctStartLabel.TabIndex = 6;
            this.EditMachineDefefctStartLabel.Text = "Defekt seit:";
            // 
            // EditMachineDefefctEndLabel
            // 
            this.EditMachineDefefctEndLabel.AutoSize = true;
            this.EditMachineDefefctEndLabel.Location = new System.Drawing.Point(38, 116);
            this.EditMachineDefefctEndLabel.Name = "EditMachineDefefctEndLabel";
            this.EditMachineDefefctEndLabel.Size = new System.Drawing.Size(132, 13);
            this.EditMachineDefefctEndLabel.TabIndex = 9;
            this.EditMachineDefefctEndLabel.Text = "Voraussichtlich Defekt bis:";
            // 
            // EditMachineDefectStartDatePicker
            // 
            this.EditMachineDefectStartDatePicker.Location = new System.Drawing.Point(41, 89);
            this.EditMachineDefectStartDatePicker.Name = "EditMachineDefectStartDatePicker";
            this.EditMachineDefectStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EditMachineDefectStartDatePicker.TabIndex = 7;
            // 
            // EditMachineSaveChanegesButton
            // 
            this.EditMachineSaveChanegesButton.Location = new System.Drawing.Point(166, 158);
            this.EditMachineSaveChanegesButton.Name = "EditMachineSaveChanegesButton";
            this.EditMachineSaveChanegesButton.Size = new System.Drawing.Size(75, 23);
            this.EditMachineSaveChanegesButton.TabIndex = 8;
            this.EditMachineSaveChanegesButton.Text = "Speichern";
            this.EditMachineSaveChanegesButton.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // MaschineFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 626);
            this.Controls.Add(this.MachineControllTabControll);
            this.Name = "MaschineFrame";
            this.Text = "MaschineFrame";
            this.MachineControllTabControll.ResumeLayout(false);
            this.MachineMonitorTab.ResumeLayout(false);
            this.MaschineUsagesGrpBox.ResumeLayout(false);
            this.MachineControllTab.ResumeLayout(false);
            this.MaschineOptionGrpBox.ResumeLayout(false);
            this.EditMachineCreateMachineGroupBox.ResumeLayout(false);
            this.EditMachineCreateMachineGroupBox.PerformLayout();
            this.EditMachineGroupBox.ResumeLayout(false);
            this.EditMachineGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MachineControllTabControll;
        private System.Windows.Forms.TabPage MachineMonitorTab;
        private System.Windows.Forms.GroupBox MaschineUsagesGrpBox;
        private System.Windows.Forms.TabPage MachineControllTab;
        private System.Windows.Forms.GroupBox MaschineOptionGrpBox;
        private System.Windows.Forms.ComboBox EditMachineSelectMachineDropDown;
        private System.Windows.Forms.TextBox NewMachineNameTextBox;
        private System.Windows.Forms.Label NewMachineNameLabel;
        private System.Windows.Forms.DateTimePicker EditMachineDefectStartDatePicker;
        private System.Windows.Forms.Label EditMachineDefefctStartLabel;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button EditMachineSaveChanegesButton;
        private System.Windows.Forms.DateTimePicker EditMachineDefectEndDatePicker;
        private System.Windows.Forms.Label EditMachineDefefctEndLabel;
        private System.Windows.Forms.GroupBox EditMachineCreateMachineGroupBox;
        private System.Windows.Forms.Button NewMachineSaveButton;
        private System.Windows.Forms.GroupBox EditMachineGroupBox;
        private Braincase.GanttChart.Chart MachineUsageChart;
    }
}