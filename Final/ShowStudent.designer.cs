﻿namespace Final
{
    partial class ShowStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudent));
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDanToc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbHocLuc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNghe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbCoQuan = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("San Francisco Text Med", 22F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(162)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(303, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 36);
            this.label8.TabIndex = 34;
            this.label8.Text = "CHI TIẾT SINH VIÊN";
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.DisplayMember = "Nam";
            this.cbbDanToc.Enabled = false;
            this.cbbDanToc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.Items.AddRange(new object[] {
            "--Chọn dân tộc--",
            "Kinh",
            "Khác"});
            this.cbbDanToc.Location = new System.Drawing.Point(182, 357);
            this.cbbDanToc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(212, 24);
            this.cbbDanToc.TabIndex = 38;
            this.cbbDanToc.ValueMember = "Nam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(95, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Dân tộc";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DisplayMember = "Nam";
            this.cbbGioiTinh.Enabled = false;
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "--Chọn giới tinh--",
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(182, 309);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(212, 24);
            this.cbbGioiTinh.TabIndex = 36;
            this.cbbGioiTinh.ValueMember = "Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(95, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(85, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(182, 189);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(212, 22);
            this.txtHoTen.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(82, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ngày sinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(182, 140);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(212, 22);
            this.txtMaSV.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(68, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Mã sinh viên";
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaysinh.Enabled = false;
            this.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaysinh.Location = new System.Drawing.Point(182, 246);
            this.dateNgaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(212, 22);
            this.dateNgaysinh.TabIndex = 53;
            // 
            // cbbHocLuc
            // 
            this.cbbHocLuc.Enabled = false;
            this.cbbHocLuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbHocLuc.FormattingEnabled = true;
            this.cbbHocLuc.Items.AddRange(new object[] {
            "--Chọn học lực--",
            "Trung bình",
            "Khá",
            "Giỏi",
            "Xuất sắc"});
            this.cbbHocLuc.Location = new System.Drawing.Point(564, 247);
            this.cbbHocLuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHocLuc.Name = "cbbHocLuc";
            this.cbbHocLuc.Size = new System.Drawing.Size(212, 24);
            this.cbbHocLuc.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(489, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 54;
            this.label14.Text = "Học lực";
            // 
            // cbbNganh
            // 
            this.cbbNganh.DisplayMember = "Nam";
            this.cbbNganh.Enabled = false;
            this.cbbNganh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(564, 305);
            this.cbbNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(212, 24);
            this.cbbNganh.TabIndex = 57;
            this.cbbNganh.ValueMember = "Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(494, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ngành";
            // 
            // cbbNghe
            // 
            this.cbbNghe.DisplayMember = "Nam";
            this.cbbNghe.Enabled = false;
            this.cbbNghe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbNghe.FormattingEnabled = true;
            this.cbbNghe.Location = new System.Drawing.Point(564, 361);
            this.cbbNghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNghe.Name = "cbbNghe";
            this.cbbNghe.Size = new System.Drawing.Size(212, 24);
            this.cbbNghe.TabIndex = 59;
            this.cbbNghe.ValueMember = "Nam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(482, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Việc làm";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DisplayMember = "Nam";
            this.cbbKhoa.Enabled = false;
            this.cbbKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(564, 196);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(212, 24);
            this.cbbKhoa.TabIndex = 61;
            this.cbbKhoa.ValueMember = "Nam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(503, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Khóa";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Location = new System.Drawing.Point(564, 140);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.ReadOnly = true;
            this.txtQueQuan.Size = new System.Drawing.Size(212, 22);
            this.txtQueQuan.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(476, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Quê quán";
            // 
            // cbbCoQuan
            // 
            this.cbbCoQuan.DisplayMember = "Nam";
            this.cbbCoQuan.Enabled = false;
            this.cbbCoQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbbCoQuan.FormattingEnabled = true;
            this.cbbCoQuan.Location = new System.Drawing.Point(182, 414);
            this.cbbCoQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCoQuan.Name = "cbbCoQuan";
            this.cbbCoQuan.Size = new System.Drawing.Size(212, 24);
            this.cbbCoQuan.TabIndex = 66;
            this.cbbCoQuan.ValueMember = "Nam";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(68, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 16);
            this.label15.TabIndex = 67;
            this.label15.Text = "Tên cơ quan";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(159)))));
            this.btnQuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai.Font = new System.Drawing.Font("San Francisco Text Med", 9.5F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Image = global::Final.Properties.Resources._return;
            this.btnQuayLai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuayLai.Location = new System.Drawing.Point(635, 481);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(141, 50);
            this.btnQuayLai.TabIndex = 63;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(248, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(380, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "                                                                                 " +
    "                                           ";
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 546);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbbCoQuan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbNghe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbNganh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbHocLuc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateNgaysinh);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbDanToc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ShowStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDanToc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.ComboBox cbbHocLuc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNghe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbCoQuan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}