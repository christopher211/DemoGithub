namespace QLCuaHangSuaGUI
{
    partial class frmSua
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
            this.dgvSua = new System.Windows.Forms.DataGridView();
            this.colMaSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chkKinhdoanh = new System.Windows.Forms.CheckBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pboHAnh = new System.Windows.Forms.PictureBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.cboLoaiSua = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSua = new System.Windows.Forms.TextBox();
            this.txtMaSua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSua)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSua
            // 
            this.dgvSua.AllowUserToAddRows = false;
            this.dgvSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSua,
            this.colTenSua,
            this.colGiaBan,
            this.colLoai,
            this.colNSX,
            this.colMoTa,
            this.colTrangThai});
            this.dgvSua.Location = new System.Drawing.Point(16, 267);
            this.dgvSua.MultiSelect = false;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.RowHeadersVisible = false;
            this.dgvSua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSua.Size = new System.Drawing.Size(727, 225);
            this.dgvSua.TabIndex = 18;
            this.dgvSua.SelectionChanged += new System.EventHandler(this.dgvSua_SelectionChanged);
            // 
            // colMaSua
            // 
            this.colMaSua.DataPropertyName = "MaSua";
            this.colMaSua.HeaderText = "Mã Sữa";
            this.colMaSua.Name = "colMaSua";
            this.colMaSua.ReadOnly = true;
            // 
            // colTenSua
            // 
            this.colTenSua.DataPropertyName = "TenSua";
            this.colTenSua.HeaderText = "Nhãn Hiệu";
            this.colTenSua.Name = "colTenSua";
            this.colTenSua.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGiaBan.HeaderText = "Giá Bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "MaLoai";
            this.colLoai.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLoai.HeaderText = "Loại Sữa";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            this.colLoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNSX
            // 
            this.colNSX.DataPropertyName = "NhaSanXuat";
            this.colNSX.HeaderText = "Nhà Sản Xuất";
            this.colNSX.Name = "colNSX";
            this.colNSX.ReadOnly = true;
            this.colNSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNSX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMoTa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FalseValue = "0";
            this.colTrangThai.HeaderText = "Đang kinh doanh";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTrangThai.TrueValue = "1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(270, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM SỮA";
            // 
            // chkKinhdoanh
            // 
            this.chkKinhdoanh.AutoSize = true;
            this.chkKinhdoanh.Location = new System.Drawing.Point(67, 132);
            this.chkKinhdoanh.Margin = new System.Windows.Forms.Padding(2);
            this.chkKinhdoanh.Name = "chkKinhdoanh";
            this.chkKinhdoanh.Size = new System.Drawing.Size(108, 17);
            this.chkKinhdoanh.TabIndex = 35;
            this.chkKinhdoanh.Text = "Đang kinh doanh";
            this.chkKinhdoanh.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = global::QLCuaHangSuaGUI.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(604, 151);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 41);
            this.btnLamMoi.TabIndex = 34;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkKinhdoanh);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pboHAnh);
            this.groupBox1.Controls.Add(this.rtbMoTa);
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.cboLoaiSua);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenSua);
            this.groupBox1.Controls.Add(this.txtMaSua);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLCuaHangSuaGUI.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(496, 151);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLCuaHangSuaGUI.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(388, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nhà SX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại Sữa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá Bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên SP:";
            // 
            // pboHAnh
            // 
            this.pboHAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboHAnh.Location = new System.Drawing.Point(580, 14);
            this.pboHAnh.Name = "pboHAnh";
            this.pboHAnh.Size = new System.Drawing.Size(100, 102);
            this.pboHAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHAnh.TabIndex = 24;
            this.pboHAnh.TabStop = false;
            this.pboHAnh.Click += new System.EventHandler(this.pboHAnh_Click);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(372, 96);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(184, 39);
            this.rtbMoTa.TabIndex = 23;
            this.rtbMoTa.Text = "";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(67, 96);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(141, 20);
            this.txtNSX.TabIndex = 22;
            // 
            // cboLoaiSua
            // 
            this.cboLoaiSua.FormattingEnabled = true;
            this.cboLoaiSua.Location = new System.Drawing.Point(372, 56);
            this.cboLoaiSua.Name = "cboLoaiSua";
            this.cboLoaiSua.Size = new System.Drawing.Size(184, 21);
            this.cboLoaiSua.TabIndex = 21;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(67, 57);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(141, 20);
            this.txtGia.TabIndex = 20;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTenSua
            // 
            this.txtTenSua.Location = new System.Drawing.Point(372, 19);
            this.txtTenSua.Name = "txtTenSua";
            this.txtTenSua.Size = new System.Drawing.Size(184, 20);
            this.txtTenSua.TabIndex = 19;
            // 
            // txtMaSua
            // 
            this.txtMaSua.Location = new System.Drawing.Point(67, 22);
            this.txtMaSua.Name = "txtMaSua";
            this.txtMaSua.ReadOnly = true;
            this.txtMaSua.Size = new System.Drawing.Size(141, 20);
            this.txtMaSua.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã SP:";
            // 
            // frmSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 504);
            this.Controls.Add(this.dgvSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSua";
            this.Text = "frmSua";
            this.Load += new System.EventHandler(this.frmSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkKinhdoanh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboHAnh;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.ComboBox cboLoaiSua;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSua;
        private System.Windows.Forms.TextBox txtMaSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
    }
}