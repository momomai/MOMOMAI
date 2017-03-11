namespace TEST
{
    partial class StockIn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_notation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_quan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.dtp_trans = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productcode = new System.Windows.Forms.TextBox();
            this.tNCTDataSet = new TEST.TNCTDataSet();
            this.sTOCKINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOCK_INTableAdapter = new TEST.TNCTDataSetTableAdapters.STOCK_INTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNCTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(423, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 431);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ลำดับ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "วันที่";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "รายการสินค้า";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "รหัส";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ปริมาณสุทธิ(ถัง)";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "จำนวน(ถัง)";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "หมายเหตุ";
            this.Column7.Name = "Column7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.txt_notation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_quan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_descrip);
            this.groupBox1.Controls.Add(this.dtp_trans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_productcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 431);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มข้อมูลสินค้าเข้า";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(209, 219);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(132, 26);
            this.txt_amount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "จำนวน (ถัง) :";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(204, 366);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(78, 32);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "ลบ";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_notation
            // 
            this.txt_notation.Location = new System.Drawing.Point(24, 281);
            this.txt_notation.Multiline = true;
            this.txt_notation.Name = "txt_notation";
            this.txt_notation.Size = new System.Drawing.Size(314, 66);
            this.txt_notation.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "หมายเหตุ :";
            // 
            // txt_quan
            // 
            this.txt_quan.Location = new System.Drawing.Point(24, 219);
            this.txt_quan.Name = "txt_quan";
            this.txt_quan.Size = new System.Drawing.Size(141, 26);
            this.txt_quan.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ปริมาณสุทธิ (ถัง) :";
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(24, 118);
            this.txt_descrip.Multiline = true;
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(317, 68);
            this.txt_descrip.TabIndex = 2;
            // 
            // dtp_trans
            // 
            this.dtp_trans.CustomFormat = "dd-MM-yyyy";
            this.dtp_trans.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_trans.Location = new System.Drawing.Point(155, 61);
            this.dtp_trans.Name = "dtp_trans";
            this.dtp_trans.Size = new System.Drawing.Size(185, 26);
            this.dtp_trans.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "รายการ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "วันที่ :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(78, 366);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(76, 32);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "เพิ่ม";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "รหัสสินค้า :";
            // 
            // txt_productcode
            // 
            this.txt_productcode.Location = new System.Drawing.Point(23, 61);
            this.txt_productcode.Name = "txt_productcode";
            this.txt_productcode.Size = new System.Drawing.Size(121, 26);
            this.txt_productcode.TabIndex = 0;
            // 
            // tNCTDataSet
            // 
            this.tNCTDataSet.DataSetName = "TNCTDataSet";
            this.tNCTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKINBindingSource
            // 
            this.sTOCKINBindingSource.DataMember = "STOCK IN";
            this.sTOCKINBindingSource.DataSource = this.tNCTDataSet;
            // 
            // sTOCK_INTableAdapter
            // 
            this.sTOCK_INTableAdapter.ClearBeforeFill = true;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockIn";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNCTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKINBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productcode;
        private System.Windows.Forms.TextBox txt_quan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.DateTimePicker dtp_trans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_notation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private TNCTDataSet tNCTDataSet;
        private System.Windows.Forms.BindingSource sTOCKINBindingSource;
        private TNCTDataSetTableAdapters.STOCK_INTableAdapter sTOCK_INTableAdapter;
    }
}