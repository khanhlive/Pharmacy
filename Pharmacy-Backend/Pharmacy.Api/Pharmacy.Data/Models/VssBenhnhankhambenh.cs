using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssBenhnhankhambenh
    {
        public int Id { get; set; }
        public int? BenhNhanMa { get; set; }
        public string ChanDoan { get; set; }
        public int? PhongBanMa { get; set; }
        public DateTime? NgayKham { get; set; }
        public int? PhuongAn { get; set; }
        public int? PhongBanDieuTriMa { get; set; }
        public string BenhKhac { get; set; }
        public string BuongDieuTri { get; set; }
        public string GiuongDieuTri { get; set; }
        public int ChuyenKhoaMa { get; set; }
        public string ChuyenKhoa { get; set; }
        public string IcdMa { get; set; }
        public string Icd2Ma { get; set; }
        public DateTime? NgayHen { get; set; }
        public DateTime? NgayNghi { get; set; }
        public string CanBoMa { get; set; }
        public string GhiChu { get; set; }
    }
}
