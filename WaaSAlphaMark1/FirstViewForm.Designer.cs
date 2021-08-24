
namespace WaaSAlphaMark1
{
    partial class FirstViewForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.uSPWAASGETTABLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvWarehouseTableList = new System.Windows.Forms.DataGridView();
            this.btnDropTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uSPWAASGETTABLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseTableList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(518, 89);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(121, 53);
            this.btnCreateTable.TabIndex = 0;
            this.btnCreateTable.Text = "Crear Tabla";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // uSPWAASGETTABLESBindingSource
            // 
            this.uSPWAASGETTABLESBindingSource.DataMember = "USP_WAAS_GET_TABLES";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(518, 160);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 58);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conectar Tabla";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Warehouse Table List:";
            // 
            // dgvWarehouseTableList
            // 
            this.dgvWarehouseTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWarehouseTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseTableList.Location = new System.Drawing.Point(40, 89);
            this.dgvWarehouseTableList.Name = "dgvWarehouseTableList";
            this.dgvWarehouseTableList.Size = new System.Drawing.Size(453, 235);
            this.dgvWarehouseTableList.TabIndex = 11;
            this.dgvWarehouseTableList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouseTableList_CellContentDoubleClick);
            // 
            // btnDropTable
            // 
            this.btnDropTable.Location = new System.Drawing.Point(518, 235);
            this.btnDropTable.Name = "btnDropTable";
            this.btnDropTable.Size = new System.Drawing.Size(121, 53);
            this.btnDropTable.TabIndex = 12;
            this.btnDropTable.Text = "Eliminar Tabla";
            this.btnDropTable.UseVisualStyleBackColor = true;
            this.btnDropTable.Click += new System.EventHandler(this.btnDropTable_Click);
            // 
            // FirstViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDropTable);
            this.Controls.Add(this.dgvWarehouseTableList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCreateTable);
            this.Name = "FirstViewForm";
            this.Text = "FirstViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.uSPWAASGETTABLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseTableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource uSPWAASGETTABLESBindingSource;
        private System.Windows.Forms.DataGridView dgvWarehouseTableList;
        private System.Windows.Forms.Button btnDropTable;
    }
}