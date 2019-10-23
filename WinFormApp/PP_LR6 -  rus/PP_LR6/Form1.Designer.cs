namespace PP_LR6
{
    partial class MainForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.DatGridDBTables = new System.Windows.Forms.DataGridView();
            this.ColTables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.tbInitCat = new System.Windows.Forms.TextBox();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.labDatSource = new System.Windows.Forms.Label();
            this.labInitCat = new System.Windows.Forms.Label();
            this.labSQLReq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(629, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(629, 179);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(95, 23);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // DatGridDBTables
            // 
            this.DatGridDBTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridDBTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridDBTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTables,
            this.ColFields});
            this.DatGridDBTables.Enabled = false;
            this.DatGridDBTables.Location = new System.Drawing.Point(12, 59);
            this.DatGridDBTables.Name = "DatGridDBTables";
            this.DatGridDBTables.ReadOnly = true;
            this.DatGridDBTables.Size = new System.Drawing.Size(712, 114);
            this.DatGridDBTables.TabIndex = 2;
            this.DatGridDBTables.MouseUp += new System.Windows.Forms.MouseEventHandler(this.datGridDBTables_MouseUp);
            // 
            // ColTables
            // 
            this.ColTables.HeaderText = "Table Name";
            this.ColTables.Name = "ColTables";
            this.ColTables.ReadOnly = true;
            this.ColTables.Width = 200;
            // 
            // ColFields
            // 
            this.ColFields.HeaderText = "Field Names in Table ";
            this.ColFields.Name = "ColFields";
            this.ColFields.ReadOnly = true;
            this.ColFields.Width = 450;
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Enabled = false;
            this.datGridSQLResult.Location = new System.Drawing.Point(12, 207);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.ReadOnly = true;
            this.datGridSQLResult.Size = new System.Drawing.Size(712, 117);
            this.datGridSQLResult.TabIndex = 3;
            // 
            // tbDatSource
            // 
            this.tbDatSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatSource.BackColor = System.Drawing.SystemColors.Info;
            this.tbDatSource.ForeColor = System.Drawing.Color.Green;
            this.tbDatSource.Location = new System.Drawing.Point(88, 6);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(636, 20);
            this.tbDatSource.TabIndex = 4;
            this.tbDatSource.Text = "(localdb)\\MSSQLLocalDB";
            // 
            // tbInitCat
            // 
            this.tbInitCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitCat.BackColor = System.Drawing.SystemColors.Info;
            this.tbInitCat.ForeColor = System.Drawing.Color.Green;
            this.tbInitCat.Location = new System.Drawing.Point(88, 32);
            this.tbInitCat.Name = "tbInitCat";
            this.tbInitCat.Size = new System.Drawing.Size(535, 20);
            this.tbInitCat.TabIndex = 5;
            this.tbInitCat.Text = "COMPSAL";
            // 
            // tbRequest
            // 
            this.tbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequest.BackColor = System.Drawing.SystemColors.Info;
            this.tbRequest.Enabled = false;
            this.tbRequest.ForeColor = System.Drawing.Color.Green;
            this.tbRequest.Location = new System.Drawing.Point(92, 181);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(531, 20);
            this.tbRequest.TabIndex = 6;
            this.tbRequest.Text = "SELECT * FROM Table";
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(12, 9);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(70, 13);
            this.labDatSource.TabIndex = 7;
            this.labDatSource.Text = "Data Source:";
            // 
            // labInitCat
            // 
            this.labInitCat.AutoSize = true;
            this.labInitCat.Location = new System.Drawing.Point(9, 35);
            this.labInitCat.Name = "labInitCat";
            this.labInitCat.Size = new System.Drawing.Size(73, 13);
            this.labInitCat.TabIndex = 7;
            this.labInitCat.Text = "Initial Catalog:";
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(12, 184);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(74, 13);
            this.labSQLReq.TabIndex = 7;
            this.labSQLReq.Text = "SQL Request:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 336);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.labInitCat);
            this.Controls.Add(this.labDatSource);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.tbInitCat);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.DatGridDBTables);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnConnect);
            this.MaximumSize = new System.Drawing.Size(753, 375);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "MainForm";
            this.Text = "Data Base Requests ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatGridDBTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView DatGridDBTables;
        private System.Windows.Forms.DataGridView datGridSQLResult;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.TextBox tbInitCat;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.Label labInitCat;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFields;
    }
}

