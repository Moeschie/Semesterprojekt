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
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FutureOrderGrpBox = new System.Windows.Forms.GroupBox();
            this.ActiveOrderGrpBox = new System.Windows.Forms.GroupBox();
            this.TestMaschineFrameBtn = new System.Windows.Forms.Button();
            this.TestLoginFrameBtn = new System.Windows.Forms.Button();
            this.TestOrderFrameBtn = new System.Windows.Forms.Button();
            this.MainTableLayout.SuspendLayout();
            this.ActiveOrderGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MainTableLayout.Controls.Add(this.FutureOrderGrpBox, 1, 0);
            this.MainTableLayout.Controls.Add(this.ActiveOrderGrpBox, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 1;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(1168, 611);
            this.MainTableLayout.TabIndex = 0;
            // 
            // FutureOrderGrpBox
            // 
            this.FutureOrderGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureOrderGrpBox.Location = new System.Drawing.Point(587, 3);
            this.FutureOrderGrpBox.Name = "FutureOrderGrpBox";
            this.FutureOrderGrpBox.Size = new System.Drawing.Size(578, 605);
            this.FutureOrderGrpBox.TabIndex = 1;
            this.FutureOrderGrpBox.TabStop = false;
            this.FutureOrderGrpBox.Text = "Aufträge in Bearbeitung";
            // 
            // ActiveOrderGrpBox
            // 
            this.ActiveOrderGrpBox.Controls.Add(this.TestMaschineFrameBtn);
            this.ActiveOrderGrpBox.Controls.Add(this.TestLoginFrameBtn);
            this.ActiveOrderGrpBox.Controls.Add(this.TestOrderFrameBtn);
            this.ActiveOrderGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveOrderGrpBox.Location = new System.Drawing.Point(3, 3);
            this.ActiveOrderGrpBox.Name = "ActiveOrderGrpBox";
            this.ActiveOrderGrpBox.Size = new System.Drawing.Size(578, 605);
            this.ActiveOrderGrpBox.TabIndex = 0;
            this.ActiveOrderGrpBox.TabStop = false;
            this.ActiveOrderGrpBox.Text = "Aktive Aufträge";
            // 
            // TestMaschineFrameBtn
            // 
            this.TestMaschineFrameBtn.Location = new System.Drawing.Point(9, 77);
            this.TestMaschineFrameBtn.Name = "TestMaschineFrameBtn";
            this.TestMaschineFrameBtn.Size = new System.Drawing.Size(111, 23);
            this.TestMaschineFrameBtn.TabIndex = 2;
            this.TestMaschineFrameBtn.Text = "MaschineFrame";
            this.TestMaschineFrameBtn.UseVisualStyleBackColor = true;
            this.TestMaschineFrameBtn.Click += new System.EventHandler(this.TestMaschineFrameBtn_Click);
            // 
            // TestLoginFrameBtn
            // 
            this.TestLoginFrameBtn.Location = new System.Drawing.Point(9, 48);
            this.TestLoginFrameBtn.Name = "TestLoginFrameBtn";
            this.TestLoginFrameBtn.Size = new System.Drawing.Size(111, 23);
            this.TestLoginFrameBtn.TabIndex = 1;
            this.TestLoginFrameBtn.Text = "LoginFrame";
            this.TestLoginFrameBtn.UseVisualStyleBackColor = true;
            this.TestLoginFrameBtn.Click += new System.EventHandler(this.TestLoginFrameBtn_Click);
            // 
            // TestOrderFrameBtn
            // 
            this.TestOrderFrameBtn.Location = new System.Drawing.Point(9, 19);
            this.TestOrderFrameBtn.Name = "TestOrderFrameBtn";
            this.TestOrderFrameBtn.Size = new System.Drawing.Size(111, 23);
            this.TestOrderFrameBtn.TabIndex = 0;
            this.TestOrderFrameBtn.Text = "OrderFrame";
            this.TestOrderFrameBtn.UseVisualStyleBackColor = true;
            this.TestOrderFrameBtn.Click += new System.EventHandler(this.TestOrderFrameBtn_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 611);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "MainFrame";
            this.Text = "Auftragsmanager";
            this.MainTableLayout.ResumeLayout(false);
            this.ActiveOrderGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox FutureOrderGrpBox;
        private System.Windows.Forms.GroupBox ActiveOrderGrpBox;
        private System.Windows.Forms.Button TestMaschineFrameBtn;
        private System.Windows.Forms.Button TestLoginFrameBtn;
        private System.Windows.Forms.Button TestOrderFrameBtn;
    }
}

