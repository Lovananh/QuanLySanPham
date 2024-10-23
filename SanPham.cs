using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    internal class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public string HinhAnh { get; set; }
        public string MoTaNgan { get; set; }
        public string MoTaChiTiet { get; set; }
        public string LoaiSP { get; set; }
        public SanPham(string maSP, string tenSP, decimal donGia, string hinhAnh, string moTaNgan, string moTaChiTiet, string loaiSP)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.DonGia = donGia;
            this.HinhAnh = hinhAnh;
            this.MoTaNgan = moTaNgan;
            this.MoTaChiTiet = moTaChiTiet;
            this.LoaiSP = loaiSP;
        }
    }
}
