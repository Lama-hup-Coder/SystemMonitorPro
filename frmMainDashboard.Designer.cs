namespace SystemMonitorPro
{
    partial class frmMainDashboard
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.PnlMainWorkspace = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSeedDatabase = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMetrics = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.PnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlHeader.Controls.Add(this.label1);
            this.PnlHeader.Controls.Add(this.btnClose);
            this.PnlHeader.Controls.Add(this.btnMinimize);
            this.PnlHeader.Controls.Add(this.lblTitle);
            this.PnlHeader.Controls.Add(this.lblLogo);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(200, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1166, 60);
            this.PnlHeader.TabIndex = 12;
            this.PnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHeader_Paint);
            this.PnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1079, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(985, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 45);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(280, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "System Monitor";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Green;
            this.lblLogo.Location = new System.Drawing.Point(6, 11);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(214, 31);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "\"SYSTEM MONITOR";
            // 
            // PnlMainWorkspace
            // 
            this.PnlMainWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMainWorkspace.Location = new System.Drawing.Point(206, 66);
            this.PnlMainWorkspace.Name = "PnlMainWorkspace";
            this.PnlMainWorkspace.Padding = new System.Windows.Forms.Padding(20);
            this.PnlMainWorkspace.Size = new System.Drawing.Size(1366, 708);
            this.PnlMainWorkspace.TabIndex = 13;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(206, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1326, 696);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.pnlSidebar.Controls.Add(this.btnSeedDatabase);
            this.pnlSidebar.Controls.Add(this.pnlContainer);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnMetrics);
            this.pnlSidebar.Controls.Add(this.btnOverview);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 768);
            this.pnlSidebar.TabIndex = 14;
            // 
            // btnSeedDatabase
            // 
            this.btnSeedDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeedDatabase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeedDatabase.Image = global::SystemMonitorPro.Properties.Resources.Add_button_32;
            this.btnSeedDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeedDatabase.Location = new System.Drawing.Point(12, 688);
            this.btnSeedDatabase.Name = "btnSeedDatabase";
            this.btnSeedDatabase.Size = new System.Drawing.Size(166, 48);
            this.btnSeedDatabase.TabIndex = 4;
            this.btnSeedDatabase.Text = "Seed Database";
            this.btnSeedDatabase.UseVisualStyleBackColor = false;
            this.btnSeedDatabase.Click += new System.EventHandler(this.btnSeedDatabase_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(36, 258);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(133, 48);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnMetrics
            // 
            this.btnMetrics.Location = new System.Drawing.Point(36, 180);
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.Size = new System.Drawing.Size(133, 48);
            this.btnMetrics.TabIndex = 2;
            this.btnMetrics.Text = "Metrics";
            this.btnMetrics.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(36, 112);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(133, 48);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(36, 37);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // frmMainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.PnlMainWorkspace);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYSMON Pro - System Monitor";
            this.Load += new System.EventHandler(this.frmMainDashboard_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel PnlMainWorkspace;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnMetrics;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeedDatabase;
    }
}

