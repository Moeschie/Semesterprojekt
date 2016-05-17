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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MaschineUsagesGrpBox = new System.Windows.Forms.GroupBox();
            this.MachineUsageChart = new Braincase.GanttChart.Chart();
            this.MaschineOptionGrpBox = new System.Windows.Forms.GroupBox();
            this.MainTableLayout.SuspendLayout();
            this.MaschineUsagesGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MaschineUsagesGrpBox, 0, 1);
            this.MainTableLayout.Controls.Add(this.MaschineOptionGrpBox, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Size = new System.Drawing.Size(1144, 626);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MaschineUsagesGrpBox
            // 
            this.MaschineUsagesGrpBox.Controls.Add(this.MachineUsageChart);
            this.MaschineUsagesGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaschineUsagesGrpBox.Location = new System.Drawing.Point(3, 316);
            this.MaschineUsagesGrpBox.Name = "MaschineUsagesGrpBox";
            this.MaschineUsagesGrpBox.Size = new System.Drawing.Size(1138, 307);
            this.MaschineUsagesGrpBox.TabIndex = 2;
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
            this.MachineUsageChart.Size = new System.Drawing.Size(1132, 288);
            this.MachineUsageChart.TabIndex = 1;
            // 
            // MaschineOptionGrpBox
            // 
            this.MaschineOptionGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaschineOptionGrpBox.Location = new System.Drawing.Point(3, 3);
            this.MaschineOptionGrpBox.Name = "MaschineOptionGrpBox";
            this.MaschineOptionGrpBox.Size = new System.Drawing.Size(1138, 307);
            this.MaschineOptionGrpBox.TabIndex = 3;
            this.MaschineOptionGrpBox.TabStop = false;
            this.MaschineOptionGrpBox.Text = "Maschinenverwaltung";
            // 
            // MaschineFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 626);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "MaschineFrame";
            this.Text = "MaschineFrame";
            this.MainTableLayout.ResumeLayout(false);
            this.MaschineUsagesGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox MaschineUsagesGrpBox;
        private Braincase.GanttChart.Chart MachineUsageChart;
        private System.Windows.Forms.GroupBox MaschineOptionGrpBox;
    }
}