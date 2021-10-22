
namespace WaaSAlphaMark1
{
    partial class DatasetViewNew
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchFiles = new System.Windows.Forms.TextBox();
            this.pboxSearchBox = new System.Windows.Forms.PictureBox();
            this.ibtCancel = new FontAwesome.Sharp.IconButton();
            this.ibtCreateDataset = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtChoooseFile = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMetadata = new System.Windows.Forms.DataGridView();
            this.pnlTopOptions.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadata)).BeginInit();
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
            this.pnlTopOptions.Controls.Add(this.panel2);
            this.pnlTopOptions.Controls.Add(this.label3);
            this.pnlTopOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlTopOptions.Name = "pnlTopOptions";
            this.pnlTopOptions.Size = new System.Drawing.Size(1120, 100);
            this.pnlTopOptions.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtSearchFiles);
            this.panel2.Controls.Add(this.pboxSearchBox);
            this.panel2.Controls.Add(this.ibtCancel);
            this.panel2.Controls.Add(this.ibtCreateDataset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 100);
            this.panel2.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Enabled = false;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1120, 1);
            this.label12.TabIndex = 3;
            // 
            // txtSearchFiles
            // 
            this.txtSearchFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtSearchFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchFiles.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearchFiles.Location = new System.Drawing.Point(33, 39);
            this.txtSearchFiles.Name = "txtSearchFiles";
            this.txtSearchFiles.Size = new System.Drawing.Size(283, 16);
            this.txtSearchFiles.TabIndex = 0;
            this.txtSearchFiles.Text = "Name of Dataset";
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
            // ibtCancel
            // 
            this.ibtCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtCancel.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.ibtCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCancel.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ibtCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtCancel.IconSize = 20;
            this.ibtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtCancel.Location = new System.Drawing.Point(475, 31);
            this.ibtCancel.Name = "ibtCancel";
            this.ibtCancel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtCancel.Size = new System.Drawing.Size(122, 32);
            this.ibtCancel.TabIndex = 9;
            this.ibtCancel.Text = "Cancel";
            this.ibtCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtCancel.UseVisualStyleBackColor = true;
            // 
            // ibtCreateDataset
            // 
            this.ibtCreateDataset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCreateDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtCreateDataset.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.ibtCreateDataset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCreateDataset.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtCreateDataset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtCreateDataset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtCreateDataset.IconSize = 20;
            this.ibtCreateDataset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtCreateDataset.Location = new System.Drawing.Point(347, 31);
            this.ibtCreateDataset.Name = "ibtCreateDataset";
            this.ibtCreateDataset.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtCreateDataset.Size = new System.Drawing.Size(122, 32);
            this.ibtCreateDataset.TabIndex = 5;
            this.ibtCreateDataset.Text = "Create";
            this.ibtCreateDataset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtCreateDataset.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.ibtChoooseFile);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgvMetadata);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 640);
            this.panel1.TabIndex = 1;
            // 
            // ibtChoooseFile
            // 
            this.ibtChoooseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtChoooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtChoooseFile.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.ibtChoooseFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtChoooseFile.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.ibtChoooseFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.ibtChoooseFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtChoooseFile.IconSize = 20;
            this.ibtChoooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtChoooseFile.Location = new System.Drawing.Point(52, 29);
            this.ibtChoooseFile.Name = "ibtChoooseFile";
            this.ibtChoooseFile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtChoooseFile.Size = new System.Drawing.Size(122, 32);
            this.ibtChoooseFile.TabIndex = 20;
            this.ibtChoooseFile.Text = "Load Data";
            this.ibtChoooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtChoooseFile.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Demi", 8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(76)))), ((int)(((byte)(99)))));
            this.label11.Location = new System.Drawing.Point(855, 77);
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
            this.label10.Location = new System.Drawing.Point(77, 77);
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
            this.label9.Location = new System.Drawing.Point(440, 77);
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
            this.label8.Location = new System.Drawing.Point(661, 77);
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
            this.label7.Location = new System.Drawing.Point(231, 77);
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
            this.label6.Location = new System.Drawing.Point(30, 96);
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
            this.dgvMetadata.Location = new System.Drawing.Point(30, 100);
            this.dgvMetadata.Name = "dgvMetadata";
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
            this.dgvMetadata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetadata.Size = new System.Drawing.Size(950, 207);
            this.dgvMetadata.TabIndex = 13;
            this.dgvMetadata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetadata_CellClick);
            // 
            // DatasetViewNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatasetViewNew";
            this.Text = "Workspace";
            this.pnlTopOptions.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSearchBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.AdomdClient.AdomdCommand adomdCommand1;
        private System.Windows.Forms.Panel pnlTopOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton ibtCreateDataset;
        private FontAwesome.Sharp.IconButton ibtCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMetadata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchFiles;
        private System.Windows.Forms.PictureBox pboxSearchBox;
        private FontAwesome.Sharp.IconButton ibtChoooseFile;
    }
}