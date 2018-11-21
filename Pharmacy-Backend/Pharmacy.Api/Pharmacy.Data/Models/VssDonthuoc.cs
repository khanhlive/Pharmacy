using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssDonthuoc
    {
        public int Id { get; set; }
        public int? Ma { get; set; }
        public int? PhongBanMa { get; set; }
        public int? BenhNhanMa { get; set; }
        public string CanBoMa { get; set; }
        public int? Status { get; set; }
        public string GhiChu { get; set; }
        public int? PhongBanXuatMa { get; set; }
        public int? PhanLoaiDichVu { get; set; }
        public DateTime? NgayKeDon { get; set; }
        public int? KieuDon { get; set; }
        public int? LoaiDuoc { get; set; }
        public int? SoPhieuLinh { get; set; }
        public int? SoVaoVien { get; set; }
    }
}
