
namespace WaaSAlphaMark1
{
    partial class Main_Portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Portal));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnConfiguration = new FontAwesome.Sharp.IconButton();
            this.ibtnReports = new FontAwesome.Sharp.IconButton();
            this.ibtnData = new FontAwesome.Sharp.IconButton();
            this.ibtnWorkspace = new FontAwesome.Sharp.IconButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pboxMaximize = new System.Windows.Forms.PictureBox();
            this.pboxMinimize = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.ibtnHome = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 99);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(26, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(171, 99);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.pnlMenu.Controls.Add(this.ibtnConfiguration);
            this.pnlMenu.Controls.Add(this.ibtnReports);
            this.pnlMenu.Controls.Add(this.ibtnData);
            this.pnlMenu.Controls.Add(this.ibtnWorkspace);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 840);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // ibtnConfiguration
            // 
            this.ibtnConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnConfiguration.FlatAppearance.BorderSize = 0;
            this.ibtnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnConfiguration.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ibtnConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnConfiguration.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.ibtnConfiguration.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnConfiguration.IconSize = 40;
            this.ibtnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConfiguration.Location = new System.Drawing.Point(0, 279);
            this.ibtnConfiguration.Name = "ibtnConfiguration";
            this.ibtnConfiguration.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnConfiguration.Size = new System.Drawing.Size(220, 60);
            this.ibtnConfiguration.TabIndex = 6;
            this.ibtnConfiguration.Text = "Configuration";
            this.ibtnConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnConfiguration.UseVisualStyleBackColor = true;
            this.ibtnConfiguration.Click += new System.EventHandler(this.ibtnConfiguration_Click);
            // 
            // ibtnReports
            // 
            this.ibtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnReports.FlatAppearance.BorderSize = 0;
            this.ibtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReports.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ibtnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnReports.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.ibtnReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReports.IconSize = 40;
            this.ibtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReports.Location = new System.Drawing.Point(0, 219);
            this.ibtnReports.Name = "ibtnReports";
            this.ibtnReports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnReports.Size = new System.Drawing.Size(220, 60);
            this.ibtnReports.TabIndex = 5;
            this.ibtnReports.Text = "Reports";
            this.ibtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnReports.UseVisualStyleBackColor = true;
            this.ibtnReports.Click += new System.EventHandler(this.ibtnReports_Click);
            // 
            // ibtnData
            // 
            this.ibtnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnData.FlatAppearance.BorderSize = 0;
            this.ibtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnData.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ibtnData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnData.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.ibtnData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnData.IconSize = 40;
            this.ibtnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnData.Location = new System.Drawing.Point(0, 159);
            this.ibtnData.Name = "ibtnData";
            this.ibtnData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnData.Size = new System.Drawing.Size(220, 60);
            this.ibtnData.TabIndex = 3;
            this.ibtnData.Text = "Data";
            this.ibtnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnData.UseVisualStyleBackColor = true;
            this.ibtnData.Click += new System.EventHandler(this.ibtnData_Click);
            // 
            // ibtnWorkspace
            // 
            this.ibtnWorkspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnWorkspace.FlatAppearance.BorderSize = 0;
            this.ibtnWorkspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnWorkspace.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ibtnWorkspace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnWorkspace.IconChar = FontAwesome.Sharp.IconChar.SpaceShuttle;
            this.ibtnWorkspace.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtnWorkspace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnWorkspace.IconSize = 40;
            this.ibtnWorkspace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnWorkspace.Location = new System.Drawing.Point(0, 99);
            this.ibtnWorkspace.Name = "ibtnWorkspace";
            this.ibtnWorkspace.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnWorkspace.Size = new System.Drawing.Size(220, 60);
            this.ibtnWorkspace.TabIndex = 2;
            this.ibtnWorkspace.Text = "Workspace";
            this.ibtnWorkspace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnWorkspace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnWorkspace.UseVisualStyleBackColor = true;
            this.ibtnWorkspace.Click += new System.EventHandler(this.ibtnWorkspace_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(64)))));
            this.pnlTitleBar.Controls.Add(this.pboxMaximize);
            this.pnlTitleBar.Controls.Add(this.pboxMinimize);
            this.pnlTitleBar.Controls.Add(this.pboxClose);
            this.pnlTitleBar.Controls.Add(this.lblHome);
            this.pnlTitleBar.Controls.Add(this.ibtnHome);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1120, 90);
            this.pnlTitleBar.TabIndex = 2;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // pboxMaximize
            // 
            this.pboxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pboxMaximize.Image")));
            this.pboxMaximize.Location = new System.Drawing.Point(1073, 12);
            this.pboxMaximize.Name = "pboxMaximize";
            this.pboxMaximize.Size = new System.Drawing.Size(15, 15);
            this.pboxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMaximize.TabIndex = 11;
            this.pboxMaximize.TabStop = false;
            this.pboxMaximize.Click += new System.EventHandler(this.pboxMaximize_Click);
            // 
            // pboxMinimize
            // 
            this.pboxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pboxMinimize.Image")));
            this.pboxMinimize.Location = new System.Drawing.Point(1052, 12);
            this.pboxMinimize.Name = "pboxMinimize";
            this.pboxMinimize.Size = new System.Drawing.Size(15, 15);
            this.pboxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMinimize.TabIndex = 10;
            this.pboxMinimize.TabStop = false;
            this.pboxMinimize.Click += new System.EventHandler(this.pboxMinimize_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxClose.Image")));
            this.pboxClose.Location = new System.Drawing.Point(1094, 12);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(15, 15);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxClose.TabIndex = 9;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(33)))), ((int)(((byte)(12)))));
            this.lblHome.Location = new System.Drawing.Point(101, 37);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(51, 21);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // ibtnHome
            // 
            this.ibtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(64)))));
            this.ibtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(33)))), ((int)(((byte)(12)))));
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(33)))), ((int)(((byte)(12)))));
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 40;
            this.ibtnHome.Location = new System.Drawing.Point(55, 28);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Size = new System.Drawing.Size(40, 40);
            this.ibtnHome.TabIndex = 0;
            this.ibtnHome.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(179)))), ((int)(((byte)(64)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(220, 90);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(1120, 9);
            this.pnlShadow.TabIndex = 3;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 99);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1120, 741);
            this.pnlDesktop.TabIndex = 4;
            // 
            // Main_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 840);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(1356, 879);
            this.Name = "Main_Portal";
            this.Text = "Main_Portal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_Portal_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton ibtnWorkspace;
        private FontAwesome.Sharp.IconButton ibtnData;
        private FontAwesome.Sharp.IconButton ibtnConfiguration;
        private FontAwesome.Sharp.IconButton ibtnReports;
        private System.Windows.Forms.Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox ibtnHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox pboxMinimize;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxMaximize;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}