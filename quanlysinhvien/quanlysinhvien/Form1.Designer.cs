namespace quanlysinhvien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.gthongtin = new System.Windows.Forms.GroupBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gtimkiem = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dagisSinhvien = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pboxHinh = new System.Windows.Forms.PictureBox();
            this.btnHinh = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gthongtin.SuspendLayout();
            this.gtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagisSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gthongtin
            // 
            this.gthongtin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gthongtin.Controls.Add(this.cmbLop);
            this.gthongtin.Controls.Add(this.txtDiachi);
            this.gthongtin.Controls.Add(this.radioNu);
            this.gthongtin.Controls.Add(this.radioNam);
            this.gthongtin.Controls.Add(this.label7);
            this.gthongtin.Controls.Add(this.label6);
            this.gthongtin.Controls.Add(this.label5);
            this.gthongtin.Controls.Add(this.dtNgaysinh);
            this.gthongtin.Controls.Add(this.txtHoten);
            this.gthongtin.Controls.Add(this.txtMasv);
            this.gthongtin.Controls.Add(this.label4);
            this.gthongtin.Controls.Add(this.label3);
            this.gthongtin.Controls.Add(this.label2);
            this.gthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gthongtin.Location = new System.Drawing.Point(21, 56);
            this.gthongtin.Name = "gthongtin";
            this.gthongtin.Size = new System.Drawing.Size(466, 142);
            this.gthongtin.TabIndex = 1;
            this.gthongtin.TabStop = false;
            this.gthongtin.Text = "Thông tin sinh viên";
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(283, 48);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 14;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(283, 80);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(124, 38);
            this.txtDiachi.TabIndex = 13;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(353, 22);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 11;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(283, 22);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 10;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            this.radioNam.CheckedChanged += new System.EventHandler(this.radioNam_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới tính:";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaysinh.Location = new System.Drawing.Point(76, 80);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(124, 20);
            this.dtNgaysinh.TabIndex = 6;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(76, 49);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(124, 20);
            this.txtHoten.TabIndex = 5;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(76, 23);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(124, 20);
            this.txtMasv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sv:";
            // 
            // gtimkiem
            // 
            this.gtimkiem.Controls.Add(this.btnTimkiem);
            this.gtimkiem.Controls.Add(this.txtTimkiem);
            this.gtimkiem.Location = new System.Drawing.Point(22, 206);
            this.gtimkiem.Name = "gtimkiem";
            this.gtimkiem.Size = new System.Drawing.Size(464, 45);
            this.gtimkiem.TabIndex = 2;
            this.gtimkiem.TabStop = false;
            this.gtimkiem.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(345, 17);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(149, 19);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(167, 20);
            this.txtTimkiem.TabIndex = 13;
            this.txtTimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimkiem_KeyPress);
            this.txtTimkiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTimkiem_MouseDown);
            // 
            // dagisSinhvien
            // 
            this.dagisSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagisSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.MaLop,
            this.DiaChi});
            this.dagisSinhvien.Location = new System.Drawing.Point(22, 267);
            this.dagisSinhvien.Name = "dagisSinhvien";
            this.dagisSinhvien.Size = new System.Drawing.Size(645, 124);
            this.dagisSinhvien.TabIndex = 3;
            this.dagisSinhvien.SelectionChanged += new System.EventHandler(this.dagisSinhvien_SelectionChanged);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MãSV";
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "TenSV";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Lớp";
            this.MaLop.Name = "MaLop";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // pboxHinh
            // 
            this.pboxHinh.Image = ((System.Drawing.Image)(resources.GetObject("pboxHinh.Image")));
            this.pboxHinh.Location = new System.Drawing.Point(583, 56);
            this.pboxHinh.Name = "pboxHinh";
            this.pboxHinh.Size = new System.Drawing.Size(338, 142);
            this.pboxHinh.TabIndex = 4;
            this.pboxHinh.TabStop = false;
            // 
            // btnHinh
            // 
            this.btnHinh.Location = new System.Drawing.Point(724, 228);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.Size = new System.Drawing.Size(75, 23);
            this.btnHinh.TabIndex = 5;
            this.btnHinh.Text = "Chọn hình";
            this.btnHinh.UseVisualStyleBackColor = true;
            this.btnHinh.Click += new System.EventHandler(this.btnHinh_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(724, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 41);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(724, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 37);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(724, 357);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 34);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(813, 267);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 41);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(813, 314);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(52, 37);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(813, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 34);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 443);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHinh);
            this.Controls.Add(this.pboxHinh);
            this.Controls.Add(this.dagisSinhvien);
            this.Controls.Add(this.gtimkiem);
            this.Controls.Add(this.gthongtin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quan ly sinh vien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gthongtin.ResumeLayout(false);
            this.gthongtin.PerformLayout();
            this.gtimkiem.ResumeLayout(false);
            this.gtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dagisSinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gthongtin;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gtimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dagisSinhvien;
        private System.Windows.Forms.PictureBox pboxHinh;
        private System.Windows.Forms.Button btnHinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}

