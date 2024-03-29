﻿
namespace WaaSAlphaMark1
{
    partial class DatasetView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adomdCommand1 = new Microsoft.AnalysisServices.AdomdClient.AdomdCommand();
            this.pnlTopOptions = new System.Windows.Forms.Panel();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblDSGoBack = new System.Windows.Forms.Label();
            this.lblDatasetName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMetadata = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.icbProcessDatasetFile = new FontAwesome.Sharp.IconButton();
            this.icbLoadData = new FontAwesome.Sharp.IconButton();
            this.ibtConnect = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.pnlTopOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
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
            this.pnlTopOptions.Controls.Add(this.lblSeparator);
            this.pnlTopOptions.Controls.Add(this.lblDSGoBack);
            this.pnlTopOptions.Controls.Add(this.lblDatasetName);
            this.pnlTopOptions.Controls.Add(this.label3);
            this.pnlTopOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlTopOptions.Name = "pnlTopOptions";
            this.pnlTopOptions.Size = new System.Drawing.Size(1120, 100);
            this.pnlTopOptions.TabIndex = 0;
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.lblSeparator.Location = new System.Drawing.Point(122, 33);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(19, 21);
            this.lblSeparator.TabIndex = 22;
            this.lblSeparator.Text = ">";
            // 
            // lblDSGoBack
            // 
            this.lblDSGoBack.AutoSize = true;
            this.lblDSGoBack.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblDSGoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.lblDSGoBack.Location = new System.Drawing.Point(49, 33);
            this.lblDSGoBack.Name = "lblDSGoBack";
            this.lblDSGoBack.Size = new System.Drawing.Size(67, 21);
            this.lblDSGoBack.TabIndex = 21;
            this.lblDSGoBack.Text = "Dataset";
            this.lblDSGoBack.Click += new System.EventHandler(this.lblDSGoBack_Click);
            // 
            // lblDatasetName
            // 
            this.lblDatasetName.AutoSize = true;
            this.lblDatasetName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblDatasetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.lblDatasetName.Location = new System.Drawing.Point(155, 33);
            this.lblDatasetName.Name = "lblDatasetName";
            this.lblDatasetName.Size = new System.Drawing.Size(70, 21);
            this.lblDatasetName.TabIndex = 20;
            this.lblDatasetName.Text = "DSDemo";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvMetadata);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.icbProcessDatasetFile);
            this.panel1.Controls.Add(this.icbLoadData);
            this.panel1.Controls.Add(this.ibtConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 640);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label11.Location = new System.Drawing.Point(855, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Agregation Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label10.Location = new System.Drawing.Point(77, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Column Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label9.Location = new System.Drawing.Point(440, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Column Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label8.Location = new System.Drawing.Point(661, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label7.Location = new System.Drawing.Point(231, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Column Name";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(950, 1);
            this.label6.TabIndex = 14;
            // 
            // dgvMetadata
            // 
            this.dgvMetadata.AllowUserToAddRows = false;
            this.dgvMetadata.AllowUserToDeleteRows = false;
            this.dgvMetadata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvMetadata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMetadata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMetadata.ColumnHeadersVisible = false;
            this.dgvMetadata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvMetadata.Location = new System.Drawing.Point(30, 398);
            this.dgvMetadata.Name = "dgvMetadata";
            this.dgvMetadata.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMetadata.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMetadata.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.dgvMetadata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMetadata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMetadata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetadata.Size = new System.Drawing.Size(950, 207);
            this.dgvMetadata.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(872, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.Location = new System.Drawing.Point(532, 18);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(122, 32);
            this.iconButton3.TabIndex = 11;
            this.iconButton3.Text = "View";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // icbProcessDatasetFile
            // 
            this.icbProcessDatasetFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbProcessDatasetFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbProcessDatasetFile.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.icbProcessDatasetFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbProcessDatasetFile.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.icbProcessDatasetFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbProcessDatasetFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbProcessDatasetFile.IconSize = 20;
            this.icbProcessDatasetFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbProcessDatasetFile.Location = new System.Drawing.Point(367, 18);
            this.icbProcessDatasetFile.Name = "icbProcessDatasetFile";
            this.icbProcessDatasetFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icbProcessDatasetFile.Size = new System.Drawing.Size(122, 32);
            this.icbProcessDatasetFile.TabIndex = 10;
            this.icbProcessDatasetFile.Text = "Process";
            this.icbProcessDatasetFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbProcessDatasetFile.UseVisualStyleBackColor = true;
            this.icbProcessDatasetFile.Click += new System.EventHandler(this.icbProcessDatasetFile_Click);
            // 
            // icbLoadData
            // 
            this.icbLoadData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbLoadData.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.icbLoadData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbLoadData.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.icbLoadData.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.icbLoadData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbLoadData.IconSize = 20;
            this.icbLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbLoadData.Location = new System.Drawing.Point(203, 18);
            this.icbLoadData.Name = "icbLoadData";
            this.icbLoadData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icbLoadData.Size = new System.Drawing.Size(122, 32);
            this.icbLoadData.TabIndex = 9;
            this.icbLoadData.Text = "Load Data";
            this.icbLoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbLoadData.UseVisualStyleBackColor = true;
            this.icbLoadData.Click += new System.EventHandler(this.icbLoadData_Click);
            // 
            // ibtConnect
            // 
            this.ibtConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtConnect.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.ibtConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtConnect.IconChar = FontAwesome.Sharp.IconChar.Plug;
            this.ibtConnect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtConnect.IconSize = 20;
            this.ibtConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtConnect.Location = new System.Drawing.Point(30, 18);
            this.ibtConnect.Name = "ibtConnect";
            this.ibtConnect.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtConnect.Size = new System.Drawing.Size(122, 32);
            this.ibtConnect.TabIndex = 5;
            this.ibtConnect.Text = "Connect";
            this.ibtConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtConnect.UseVisualStyleBackColor = true;
            this.ibtConnect.Click += new System.EventHandler(this.ibtConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(697, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(490, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date Loaded";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.lblFileName.Location = new System.Drawing.Point(156, 112);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 15);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "File Name";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(950, 1);
            this.label4.TabIndex = 4;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFiles.ColumnHeadersVisible = false;
            this.dgvFiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.dgvFiles.Location = new System.Drawing.Point(30, 136);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFiles.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.dgvFiles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(950, 191);
            this.dgvFiles.TabIndex = 2;
            this.dgvFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseClick);
            // 
            // DatasetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatasetView";
            this.Text = "Workspace";
            this.pnlTopOptions.ResumeLayout(false);
            this.pnlTopOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.AdomdClient.AdomdCommand adomdCommand1;
        private System.Windows.Forms.Panel pnlTopOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ibtConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileName;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton icbProcessDatasetFile;
        private FontAwesome.Sharp.IconButton icbLoadData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMetadata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDatasetName;
        private System.Windows.Forms.Label lblDSGoBack;
        private System.Windows.Forms.Label lblSeparator;
    }
}