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
        private List<SanPham> danhSachSanPham = new List<SanPham>();
        private int selectedRowIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtDongia.Clear();
            txtHinhanh.Clear();
            txtMotangan.Clear();
            txtMotachitiet.Clear();
            comboBoxLoaisp.SelectedIndex = -1;
            selectedRowIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMasp.Text;
                string tenSP = txtTensp.Text;
                decimal donGia;
                if (!decimal.TryParse(txtDongia.Text, out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ.");
                    return;
                }
                string hinhAnh = txtHinhanh.Text;
                string moTaNgan = txtMotangan.Text;
                string moTaChiTiet = txtMotachitiet.Text;
                var loaiSP = comboBoxLoaisp.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(loaiSP))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                    return;
                }

                // Sử dụng constructor của SanPham để tạo đối tượng
                SanPham sanPham = new SanPham(maSP, tenSP, donGia, hinhAnh, moTaNgan, moTaChiTiet, loaiSP);

                // Thêm sản phẩm vào danh sách
                danhSachSanPham.Add(sanPham);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView1.DataSource = danhSachSanPham; // Cập nhật nguồn dữ liệu

                // Xóa các TextBox và ComboBox
                txtMasp.Clear();
                txtTensp.Clear();
                txtDongia.Clear();
                txtHinhanh.Clear();
                txtMotangan.Clear();
                txtMotachitiet.Clear();
                comboBoxLoaisp.SelectedIndex = -1;

                //MessageBox.Show(danhSachSanPham.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = laySanPham().Tables[0];
            dataGridView1.DataSource = danhSachSanPham;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    if (selectedRowIndex >= 0 && selectedRowIndex < danhSachSanPham.Count)
                    {
                        // Cập nhật thông tin sản phẩm
                        var sanPham = danhSachSanPham[selectedRowIndex];
                        sanPham.MaSP = txtMasp.Text;
                        sanPham.TenSP = txtTensp.Text;
                        sanPham.DonGia = decimal.Parse(txtDongia.Text);
                        sanPham.HinhAnh = txtHinhanh.Text;
                        sanPham.MoTaNgan = txtMotangan.Text;
                        sanPham.MoTaChiTiet = txtMotachitiet.Text;
                        sanPham.LoaiSP = comboBoxLoaisp.SelectedItem?.ToString();

                        // Cập nhật lại DataGridView
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = danhSachSanPham;

                        // Xóa các trường nhập liệu
                        txtMasp.Clear();
                        txtTensp.Clear();
                        txtDongia.Clear();
                        txtHinhanh.Clear();
                        txtMotangan.Clear();
                        txtMotachitiet.Clear();
                        comboBoxLoaisp.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Chỉ mục hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng: Vui lòng nhập đúng kiểu dữ liệu cho đơn giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < danhSachSanPham.Count)
            {
                // Xóa sản phẩm đã chọn
                danhSachSanPham.RemoveAt(selectedRowIndex);

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null; // Đặt lại nguồn dữ liệu để làm mới
                dataGridView1.DataSource = danhSachSanPham;

                // Xóa các TextBox sau khi xóa


                txtMasp.Clear();
                txtTensp.Clear();
                txtDongia.Clear();
                txtHinhanh.Clear();
                txtMotangan.Clear();
                txtMotachitiet.Clear();
                comboBoxLoaisp.SelectedIndex = -1;
                selectedRowIndex = -1; // Reset chỉ số sau khi xóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < danhSachSanPham.Count)
            {
                // Lấy chỉ số hàng đã chọn
                selectedRowIndex = e.RowIndex;

                // Hiển thị thông tin sản phẩm lên các TextBox
                var sanPham = danhSachSanPham[selectedRowIndex];
                txtMasp.Text = sanPham.MaSP;
                txtTensp.Text = sanPham.TenSP;
                txtDongia.Text = sanPham.DonGia.ToString();
                txtHinhanh.Text = sanPham.HinhAnh;
                txtMotangan.Text = sanPham.MoTaNgan;
                txtMotachitiet.Text = sanPham.MoTaChiTiet;
                comboBoxLoaisp.SelectedItem = sanPham.LoaiSP;
            }
        }
    }
}
