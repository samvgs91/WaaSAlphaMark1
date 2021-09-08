
namespace WaaSAlphaMark1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChoose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadMetadata = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnEliminarArchivo = new System.Windows.Forms.Button();
            this.btnModelCreateUpdate = new System.Windows.Forms.Button();
            this.btnModelProcess = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(370, 36);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(56, 20);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 286);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dgvFiles
            // 
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(513, 154);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.Size = new System.Drawing.Size(398, 286);
            this.dgvFiles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metadata:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Files Loaded:";
            // 
            // btnLoadMetadata
            // 
            this.btnLoadMetadata.Location = new System.Drawing.Point(441, 31);
            this.btnLoadMetadata.Name = "btnLoadMetadata";
            this.btnLoadMetadata.Size = new System.Drawing.Size(115, 30);
            this.btnLoadMetadata.TabIndex = 7;
            this.btnLoadMetadata.Text = "Cargar Metada";
            this.btnLoadMetadata.UseVisualStyleBackColor = true;
            this.btnLoadMetadata.Click += new System.EventHandler(this.btnLoadMetadata_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(102, 97);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(262, 20);
            this.txtTableName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Table Name:";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(928, 154);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(117, 48);
            this.btnLoadFile.TabIndex = 10;
            this.btnLoadFile.Text = "Cargar Archivo";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnEliminarArchivo
            // 
            this.btnEliminarArchivo.Location = new System.Drawing.Point(928, 208);
            this.btnEliminarArchivo.Name = "btnEliminarArchivo";
            this.btnEliminarArchivo.Size = new System.Drawing.Size(117, 48);
            this.btnEliminarArchivo.TabIndex = 11;
            this.btnEliminarArchivo.Text = "Eliminar Archivo";
            this.btnEliminarArchivo.UseVisualStyleBackColor = true;
            this.btnEliminarArchivo.Click += new System.EventHandler(this.btnEliminarArchivo_Click);
            // 
            // btnModelCreateUpdate
            // 
            this.btnModelCreateUpdate.Location = new System.Drawing.Point(928, 300);
            this.btnModelCreateUpdate.Name = "btnModelCreateUpdate";
            this.btnModelCreateUpdate.Size = new System.Drawing.Size(117, 48);
            this.btnModelCreateUpdate.TabIndex = 12;
            this.btnModelCreateUpdate.Text = "Generar Modelo";
            this.btnModelCreateUpdate.UseVisualStyleBackColor = true;
            this.btnModelCreateUpdate.Click += new System.EventHandler(this.btnModelCreateUpdate_Click);
            // 
            // btnModelProcess
            // 
            this.btnModelProcess.Location = new System.Drawing.Point(928, 354);
            this.btnModelProcess.Name = "btnModelProcess";
            this.btnModelProcess.Size = new System.Drawing.Size(117, 48);
            this.btnModelProcess.TabIndex = 13;
            this.btnModelProcess.Text = "Procesar Modelo";
            this.btnModelProcess.UseVisualStyleBackColor = true;
            this.btnModelProcess.Click += new System.EventHandler(this.btnModelProcess_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(102, 36);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(262, 20);
            this.txtFileName.TabIndex = 14;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(31, 39);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 15;
            this.lblFileName.Text = "File Name:";
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(102, 65);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(92, 21);
            this.cboSheet.TabIndex = 16;
            this.cboSheet.SelectionChangeCommitted += new System.EventHandler(this.cboSheet_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sheets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnModelProcess);
            this.Controls.Add(this.btnModelCreateUpdate);
            this.Controls.Add(this.btnEliminarArchivo);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnLoadMetadata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadMetadata;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnEliminarArchivo;
        private System.Windows.Forms.Button btnModelCreateUpdate;
        private System.Windows.Forms.Button btnModelProcess;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Label label4;
    }
}

