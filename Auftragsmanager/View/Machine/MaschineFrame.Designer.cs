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
            this.MachineControllTab = new System.Windows.Forms.TabPage();
            this.MaschineOptionGrpBox = new System.Windows.Forms.GroupBox();
            this.MaschineUsagesGrpBox = new System.Windows.Forms.GroupBox();
            this.MachineUsageChart = new Braincase.GanttChart.Chart();
            this.MachineControllTabControll.SuspendLayout();
            this.MachineMonitorTab.SuspendLayout();
            this.MachineControllTab.SuspendLayout();
            this.MaschineUsagesGrpBox.SuspendLayout();
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
            this.MaschineOptionGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaschineOptionGrpBox.Location = new System.Drawing.Point(3, 3);
            this.MaschineOptionGrpBox.Name = "MaschineOptionGrpBox";
            this.MaschineOptionGrpBox.Size = new System.Drawing.Size(1130, 594);
            this.MaschineOptionGrpBox.TabIndex = 4;
            this.MaschineOptionGrpBox.TabStop = false;
            this.MaschineOptionGrpBox.Text = "Maschinenverwaltung";
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
            this.MachineUsageChart.TabIndex = 1;
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
            this.MachineControllTab.ResumeLayout(false);
            this.MaschineUsagesGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MachineControllTabControll;
        private System.Windows.Forms.TabPage MachineMonitorTab;
        private System.Windows.Forms.GroupBox MaschineUsagesGrpBox;
        private Braincase.GanttChart.Chart MachineUsageChart;
        private System.Windows.Forms.TabPage MachineControllTab;
        private System.Windows.Forms.GroupBox MaschineOptionGrpBox;
    }
}