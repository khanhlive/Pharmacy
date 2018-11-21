using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssCanlamsang
    {
        public int Id { get; set; }
        public int? Ma { get; set; }
        public int? BenhNhanMa { get; set; }
        public string CanBoMa { get; set; }
        public int? PhongBanMa { get; set; }
        public int? PhongBanThucHienMa { get; set; }
        public DateTime? NgayThang { get; set; }
        public string CanBoThucHienMa { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public string DanhsachCanboThuchien { get; set; }
        public byte Status { get; set; }
        public int? Stt { get; set; }
        public string BenhPham { get; set; }
        public string TrangThaiBenhPham { get; set; }
        public DateTime? ThoiGianLayMau { get; set; }
        public DateTime? ThoiGianNhanMau { get; set; }
        public string GhiChu { get; set; }
        public DateTime? NgayNhanKetQua { get; set; }
        public bool CapCuu { get; set; }
        public int? Idbb { get; set; }
        public string ChanDoan { get; set; }
        public string IcdMa { get; set; }
        public bool? TrangThaiBenhNhan { get; set; }
    }
}
