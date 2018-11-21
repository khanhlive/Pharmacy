using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicPhongban
    {
        public DicPhongban()
        {
            DicCanbo = new HashSet<DicCanbo>();
        }

        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public int? NhomPhongBan { get; set; }
        public string ChuyenKhoa { get; set; }
        public int PhanLoaiId { get; set; }
        public int? QuanLy { get; set; }
        public string BuongGiuong { get; set; }
        public string MaQuyetDinh { get; set; }
        public string MaPhongBanCu { get; set; }
        public int MaChuyenKhoa { get; set; }
        public bool TuTruc { get; set; }
        public int TrongBenhVien { get; set; }
        public int PhuongPhapXuatDuoc { get; set; }
        public byte PhuongPhapHuHaoDongY { get; set; }
        public string DiaChi { get; set; }
        public string MaBenhVien { get; set; }
        public int? Status { get; set; }

        public DicBenhvien MaBenhVienNavigation { get; set; }
        public DicChuyenkhoa MaChuyenKhoaNavigation { get; set; }
        public DicPhanloaiphongban PhanLoai { get; set; }
        public ICollection<DicCanbo> DicCanbo { get; set; }
    }
}
