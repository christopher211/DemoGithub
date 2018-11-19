namespace QLCuaHangSuaGUI
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mniBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBC = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnDNDX = new System.Windows.Forms.Button();
            this.picHANV = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHANV)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBH,
            this.mniHD,
            this.mniQL,
            this.mniBC});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(160, 530);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mniBH
            // 
            this.mniBH.Image = global::QLCuaHangSuaGUI.Properties.Resources.BanHang;
            this.mniBH.Name = "mniBH";
            this.mniBH.Size = new System.Drawing.Size(147, 36);
            this.mniBH.Text = "Bán Hàng";
            this.mniBH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniBH.Click += new System.EventHandler(this.mniBH_Click);
            // 
            // mniHD
            // 
            this.mniHD.Image = global::QLCuaHangSuaGUI.Properties.Resources.HDBan;
            this.mniHD.Name = "mniHD";
            this.mniHD.Size = new System.Drawing.Size(147, 36);
            this.mniHD.Text = "Hóa Đơn";
            this.mniHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mniQL
            // 
            this.mniQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSua,
            this.mniLSua,
            this.mniNV});
            this.mniQL.Image = global::QLCuaHangSuaGUI.Properties.Resources.ArrangeIcons;
            this.mniQL.Name = "mniQL";
            this.mniQL.Size = new System.Drawing.Size(147, 36);
            this.mniQL.Text = "Quản Lý";
            this.mniQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mniSua
            // 
            this.mniSua.Image = global::QLCuaHangSuaGUI.Properties.Resources.s22;
            this.mniSua.Name = "mniSua";
            this.mniSua.Size = new System.Drawing.Size(209, 36);
            this.mniSua.Text = "Sữa";
            this.mniSua.Click += new System.EventHandler(this.mniSua_Click);
            // 
            // mniLSua
            // 
            this.mniLSua.Image = global::QLCuaHangSuaGUI.Properties.Resources.LoaiSua;
            this.mniLSua.Name = "mniLSua";
            this.mniLSua.Size = new System.Drawing.Size(209, 36);
            this.mniLSua.Text = "Loại Sữa";
            // 
            // mniNV
            // 
            this.mniNV.Image = global::QLCuaHangSuaGUI.Properties.Resources.Management;
            this.mniNV.Name = "mniNV";
            this.mniNV.Size = new System.Drawing.Size(209, 36);
            this.mniNV.Text = "Nhân Viên";
            // 
            // mniBC
            // 
            this.mniBC.Image = global::QLCuaHangSuaGUI.Properties.Resources.HDNhap;
            this.mniBC.Name = "mniBC";
            this.mniBC.Size = new System.Drawing.Size(147, 36);
            this.mniBC.Text = "Báo Cáo";
            this.mniBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Maroon;
            this.lblMaNV.Location = new System.Drawing.Point(13, 318);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(133, 30);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "1234567890";
            // 
            // btnDNDX
            // 
            this.btnDNDX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNDX.Image = global::QLCuaHangSuaGUI.Properties.Resources.DangNhap;
            this.btnDNDX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDNDX.Location = new System.Drawing.Point(0, 413);
            this.btnDNDX.Name = "btnDNDX";
            this.btnDNDX.Size = new System.Drawing.Size(160, 44);
            this.btnDNDX.TabIndex = 4;
            this.btnDNDX.Text = "ĐĂNG NHẬP";
            this.btnDNDX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDNDX.UseVisualStyleBackColor = true;
            this.btnDNDX.Click += new System.EventHandler(this.btnDNDX_Click);
            // 
            // picHANV
            // 
            this.picHANV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHANV.Location = new System.Drawing.Point(13, 171);
            this.picHANV.Name = "picHANV";
            this.picHANV.Size = new System.Drawing.Size(135, 140);
            this.picHANV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHANV.TabIndex = 2;
            this.picHANV.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 530);
            this.Controls.Add(this.btnDNDX);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.picHANV);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Phần mềm Quản lý Cửa hàng Sữa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHANV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mniBH;
        private System.Windows.Forms.ToolStripMenuItem mniHD;
        private System.Windows.Forms.ToolStripMenuItem mniQL;
        private System.Windows.Forms.ToolStripMenuItem mniSua;
        private System.Windows.Forms.ToolStripMenuItem mniLSua;
        private System.Windows.Forms.ToolStripMenuItem mniNV;
        private System.Windows.Forms.ToolStripMenuItem mniBC;
        private System.Windows.Forms.PictureBox picHANV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnDNDX;
    }
}

