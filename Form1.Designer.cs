namespace QuanLySanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTensp = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblHinhanh = new System.Windows.Forms.Label();
            this.lblMotangan = new System.Windows.Forms.Label();
            this.lblLoaisp = new System.Windows.Forms.Label();
            this.comboBoxLoaisp = new System.Windows.Forms.ComboBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtHinhanh = new System.Windows.Forms.TextBox();
            this.txtMotangan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblMotachitiet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMotachitiet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP :";
            // 
            // lblTensp
            // 
            this.lblTensp.AutoSize = true;
            this.lblTensp.Location = new System.Drawing.Point(19, 102);
            this.lblTensp.Name = "lblTensp";
            this.lblTensp.Size = new System.Drawing.Size(69, 20);
            this.lblTensp.TabIndex = 1;
            this.lblTensp.Text = "Tên SP: ";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(19, 157);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(76, 20);
            this.lblDongia.TabIndex = 2;
            this.lblDongia.Text = "Đơn giá : ";
            // 
            // lblHinhanh
            // 
            this.lblHinhanh.AutoSize = true;
            this.lblHinhanh.Location = new System.Drawing.Point(19, 219);
            this.lblHinhanh.Name = "lblHinhanh";
            this.lblHinhanh.Size = new System.Drawing.Size(81, 20);
            this.lblHinhanh.TabIndex = 3;
            this.lblHinhanh.Text = "Hình ảnh :";
            // 
            // lblMotangan
            // 
            this.lblMotangan.AutoSize = true;
            this.lblMotangan.Location = new System.Drawing.Point(14, 269);
            this.lblMotangan.Name = "lblMotangan";
            this.lblMotangan.Size = new System.Drawing.Size(101, 20);
            this.lblMotangan.TabIndex = 4;
            this.lblMotangan.Text = "Mô tả ngắn : ";
            // 
            // lblLoaisp
            // 
            this.lblLoaisp.AutoSize = true;
            this.lblLoaisp.Location = new System.Drawing.Point(19, 404);
            this.lblLoaisp.Name = "lblLoaisp";
            this.lblLoaisp.Size = new System.Drawing.Size(72, 20);
            this.lblLoaisp.TabIndex = 5;
            this.lblLoaisp.Text = "Loại SP :";
            // 
            // comboBoxLoaisp
            // 
            this.comboBoxLoaisp.FormattingEnabled = true;
            this.comboBoxLoaisp.Items.AddRange(new object[] {
            "Đồ ăn",
            "Đồ điện tử",
            "Thuốc"});
            this.comboBoxLoaisp.Location = new System.Drawing.Point(131, 401);
            this.comboBoxLoaisp.Name = "comboBoxLoaisp";
            this.comboBoxLoaisp.Size = new System.Drawing.Size(281, 28);
            this.comboBoxLoaisp.TabIndex = 11;
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Location = new System.Drawing.Point(36, 29);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(83, 20);
            this.lblTimkiem.TabIndex = 0;
            this.lblTimkiem.Text = "Tìm kiếm : ";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(634, 18);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(108, 34);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(131, 47);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(281, 26);
            this.txtMasp.TabIndex = 12;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(131, 99);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(281, 26);
            this.txtTensp.TabIndex = 13;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(131, 154);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(281, 26);
            this.txtDongia.TabIndex = 14;
            // 
            // txtHinhanh
            // 
            this.txtHinhanh.Location = new System.Drawing.Point(131, 213);
            this.txtHinhanh.Name = "txtHinhanh";
            this.txtHinhanh.Size = new System.Drawing.Size(281, 26);
            this.txtHinhanh.TabIndex = 15;
            // 
            // txtMotangan
            // 
            this.txtMotangan.Location = new System.Drawing.Point(131, 269);
            this.txtMotangan.Name = "txtMotangan";
            this.txtMotangan.Size = new System.Drawing.Size(281, 26);
            this.txtMotangan.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(787, 499);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(124, 26);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(421, 26);
            this.txtTimkiem.TabIndex = 4;
            // 
            // lblMotachitiet
            // 
            this.lblMotachitiet.AutoSize = true;
            this.lblMotachitiet.Location = new System.Drawing.Point(14, 317);
            this.lblMotachitiet.Name = "lblMotachitiet";
            this.lblMotachitiet.Size = new System.Drawing.Size(111, 20);
            this.lblMotachitiet.TabIndex = 17;
            this.lblMotachitiet.Text = "Mô tả chi tiết : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMotachitiet);
            this.groupBox1.Controls.Add(this.txtMasp);
            this.groupBox1.Controls.Add(this.lblMotachitiet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMotangan);
            this.groupBox1.Controls.Add(this.lblTensp);
            this.groupBox1.Controls.Add(this.txtHinhanh);
            this.groupBox1.Controls.Add(this.lblDongia);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.lblHinhanh);
            this.groupBox1.Controls.Add(this.txtTensp);
            this.groupBox1.Controls.Add(this.lblMotangan);
            this.groupBox1.Controls.Add(this.lblLoaisp);
            this.groupBox1.Controls.Add(this.comboBoxLoaisp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 452);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // txtMotachitiet
            // 
            this.txtMotachitiet.Location = new System.Drawing.Point(131, 317);
            this.txtMotachitiet.Multiline = true;
            this.txtMotachitiet.Name = "txtMotachitiet";
            this.txtMotachitiet.Size = new System.Drawing.Size(281, 65);
            this.txtMotachitiet.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lblTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(456, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 561);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnLammoi);
            this.groupBox3.Location = new System.Drawing.Point(12, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(325, 40);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 34);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(211, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 34);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(13, 40);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(93, 34);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới ";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "frSanPham ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLoaisp;
        private System.Windows.Forms.Label lblMotangan;
        private System.Windows.Forms.Label lblHinhanh;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblTensp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoaisp;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.TextBox txtMotangan;
        private System.Windows.Forms.TextBox txtHinhanh;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMotachitiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.TextBox txtMotachitiet;
    }
}

