using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssNhapuoc
    {
        public int Id { get; set; }
        public int? Ma { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string SoChungTu { get; set; }
        public int? PhongBanMa { get; set; }
        public string TenNguoiCungCap { get; set; }
        public string NhaCungCapMa { get; set; }
        public string GhiChu { get; set; }
        public int? Status { get; set; }
        public int? PhanLoai { get; set; }
        public int? PhongBanNhapXuatMa { get; set; }
        public int? KieuDon { get; set; }
        public int? BenhNhanMa { get; set; }
        public string MaXp { get; set; }
        public int? XuatTd { get; set; }
        public string CanBoMa { get; set; }
        public int? SoPhieuLinh { get; set; }
        public string DiaChi { get; set; }
        public byte DoiTuongBenhNhanMa { get; set; }
        public int Mien { get; set; }
        public int TraDuocKieuDon { get; set; }
        public DateTime? NgayTt { get; set; }
        public DateTime? NgayNhapNvl { get; set; }
        public int? Idsxthuoc { get; set; }
        public int? TangGiaSx { get; set; }
        public string SoPhieu { get; set; }
        public int? LoaiTang { get; set; }
    }
}
