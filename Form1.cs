using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        //private List<SanPham> danhSachSanPham = new List<SanPham>();
        //private int selectedRowIndex = -1;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        Ketnoi kn = new Ketnoi();

        public void getData()
        {
            string query = "select * from SanPham";
            DataSet ds = kn.Laydulieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void getLoaiSP()
        {
            string query = "select * from LoaiSanPham";
            DataSet ds = kn.Laydulieu(query);
            comboBoxLoaisp.Font = new Font("Segoe UI", 10);
            comboBoxLoaisp.DataSource = ds.Tables[0];
            comboBoxLoaisp.DisplayMember = "Tensp";
            comboBoxLoaisp.ValueMember = "MaLoaiSP";

        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {

            txtMasp.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtTimkiem.Text = "";
            txtDongia.Text = "";
            txtHinhanh.Text = "";
            txtMotangan.Text = "";
            txtMotachitiet.Text = "";
            //comboBoxLoaisp.SelectedIndex = -1;
            //selectedRowIndex = -1;
            getData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string query = string.Format(
                "insert into Sanpham VALUES('{0}', N'{1}', {2}, N'{3}', N'{4}', N'{5}', N'{6}')",
                txtMasp.Text,
                txtTensp.Text,
                txtDongia.Text,
                txtHinhanh.Text,
                txtMotangan.Text,
                txtMotachitiet.Text,
                comboBoxLoaisp.SelectedValue
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLoaiSP();
            getData();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
               "update Sanpham set Tensp = N'{1}', Dongia = {2}, Hinhanh = N'{3}', Motangan = N'{4}', Motachitiet = N'{5}', MaLoaiSP = '{6}' where MaSP = '{0}'",
                txtMasp.Text,
                txtTensp.Text,
                txtDongia.Text,
                txtHinhanh.Text,
                txtMotangan.Text,
                txtMotachitiet.Text,
                comboBoxLoaisp.SelectedValue
           );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from Sanpham where Masp = '{0}'",
                txtMasp.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMasp.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMasp.Text = dataGridView1.Rows[r].Cells["MaSP"].Value.ToString();
                txtTensp.Text = dataGridView1.Rows[r].Cells["TenSP"].Value.ToString();
                txtDongia.Text = dataGridView1.Rows[r].Cells["DonGia"].Value.ToString();
                txtHinhanh.Text = dataGridView1.Rows[r].Cells["HinhAnh"].Value.ToString();
                txtMotangan.Text = dataGridView1.Rows[r].Cells["MoTaNgan"].Value.ToString();
                txtMotachitiet.Text = dataGridView1.Rows[r].Cells["MoTaChiTiet"].Value.ToString();
                comboBoxLoaisp.SelectedValue = dataGridView1.Rows[r].Cells["MaLoaiSp"].Value.ToString();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select Sanpham.* from Sanpham inner join LoaiSanPham on Sanpham.MaloaiSP = LoaiSanPham.MaloaiSP where SanPham.Tensp like N'%{0}%'",
                txtTimkiem.Text
            );
            
            DataSet ds = kn.Laydulieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
