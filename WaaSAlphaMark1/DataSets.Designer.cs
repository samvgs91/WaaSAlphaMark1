
namespace WaaSAlphaMark1
{
    partial class DataSets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adomdCommand1 = new Microsoft.AnalysisServices.AdomdClient.AdomdCommand();
            this.pnlTopOptions = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFiles = new System.Windows.Forms.TextBox();
            this.pboxSearchIcon = new System.Windows.Forms.PictureBox();
            this.pboxSearchBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ibtNewFile = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.dgvDatasets = new System.Windows.Forms.DataGridView();
            this.pnlTopOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatasets)).BeginInit();
            this.SuspendLayout();
            // 
            // adomdCommand1
            // 
            this.adomdCommand1.ActivityID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.adomdCommand1.CommandStream = null;
            this.adomdCommand1.CommandText = null;
            this.adomdCommand1.CommandTimeout = 0;
            this.adomdCommand1.CommandType = System.Data.CommandType.Text;
            this.adomdCommand1.Connection = null;
            // 
            // pnlTopOptions
            // 
            this.pnlTopOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.pnlTopOptions.Controls.Add(this.label3);
            this.pnlTopOptions.Controls.Add(this.txtSearchFiles);
            this.pnlTopOptions.Controls.Add(this.pboxSearchIcon);
            this.pnlTopOptions.Controls.Add(this.pboxSearchBox);
            this.pnlTopOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlTopOptions.Name = "pnlTopOptions";
            this.pnlTopOptions.Size = new System.Drawing.Size(1120, 100);
            this.pnlTopOptions.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1120, 1);
            this.label3.TabIndex = 3;
            // 
            // txtSearchFiles
            // 
            this.txtSearchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtSearchFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchFiles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearchFiles.Location = new System.Drawing.Point(64, 41);
            this.txtSearchFiles.Name = "txtSearchFiles";
            this.txtSearchFiles.Size = new System.Drawing.Size(247, 16);
            this.txtSearchFiles.TabIndex = 0;
            this.txtSearchFiles.Text = "Search in Workspace";
            this.txtSearchFiles.Enter += new System.EventHandler(this.txtSearchFiles_Enter);
            this.txtSearchFiles.Leave += new System.EventHandler(this.txtSearchFiles_Leave);
            // 
            // pboxSearchIcon
            // 
            this.pboxSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.pboxSearchIcon.Image = global::WaaSAlphaMark1.Properties.Resources._1814075_find_magnifier_magnifying_glass_search_icon;
            this.pboxSearchIcon.Location = new System.Drawing.Point(30, 34);
            this.pboxSearchIcon.Name = "pboxSearchIcon";
            this.pboxSearchIcon.Size = new System.Drawing.Size(28, 27);
            this.pboxSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSearchIcon.TabIndex = 1;
            this.pboxSearchIcon.TabStop = false;
            // 
            // pboxSearchBox
            // 
            this.pboxSearchBox.Image = global::WaaSAlphaMark1.Properties.Resources.SearchBar;
            this.pboxSearchBox.Location = new System.Drawing.Point(25, 30);
            this.pboxSearchBox.Name = "pboxSearchBox";
            this.pboxSearchBox.Size = new System.Drawing.Size(300, 35);
            this.pboxSearchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSearchBox.TabIndex = 0;
            this.pboxSearchBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ibtNewFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.dgvDatasets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 640);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1120, 1);
            this.label4.TabIndex = 4;
            // 
            // ibtNewFile
            // 
            this.ibtNewFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtNewFile.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ibtNewFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtNewFile.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtNewFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtNewFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtNewFile.IconSize = 30;
            this.ibtNewFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtNewFile.Location = new System.Drawing.Point(21, 9);
            this.ibtNewFile.Name = "ibtNewFile";
            this.ibtNewFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtNewFile.Size = new System.Drawing.Size(120, 49);
            this.ibtNewFile.TabIndex = 1;
            this.ibtNewFile.Text = "New";
            this.ibtNewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtNewFile.UseVisualStyleBackColor = true;
            this.ibtNewFile.Click += new System.EventHandler(this.ibtNewFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(815, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(468, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last modified";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.lblFileName.Location = new System.Drawing.Point(47, 76);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 21);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Name";
            // 
            // dgvDatasets
            // 
            this.dgvDatasets.AllowUserToAddRows = false;
            this.dgvDatasets.AllowUserToDeleteRows = false;
            this.dgvDatasets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvDatasets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatasets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatasets.ColumnHeadersVisible = false;
            this.dgvDatasets.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvDatasets.Location = new System.Drawing.Point(0, 110);
            this.dgvDatasets.Name = "dgvDatasets";
            this.dgvDatasets.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatasets.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatasets.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.dgvDatasets.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatasets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatasets.Size = new System.Drawing.Size(1120, 440);
            this.dgvDatasets.TabIndex = 2;
            // 
            // DataSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataSets";
            this.Text = "Workspace";
            this.pnlTopOptions.ResumeLayout(false);
            this.pnlTopOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatasets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.AdomdClient.AdomdCommand adomdCommand1;
        private System.Windows.Forms.Panel pnlTopOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxSearchBox;
        private System.Windows.Forms.PictureBox pboxSearchIcon;
        private System.Windows.Forms.TextBox txtSearchFiles;
        private System.Windows.Forms.DataGridView dgvDatasets;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton ibtNewFile;
        private System.Windows.Forms.Label label4;
    }
}