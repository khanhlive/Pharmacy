using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssPerson
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string SoTheBhyt { get; set; }
        public string DoiTuongMa { get; set; }
        public string TenBenhNhan { get; set; }
        public string GioiTinhMa { get; set; }
        public string DiaChi { get; set; }
        public DateTime? HanBaoHiemTu { get; set; }
        public DateTime? HanBaoHiemDen { get; set; }
        public DateTime? NgayCap { get; set; }
        public int? Status { get; set; }
        public string MaCoSo { get; set; }
        public string TinhMa { get; set; }
        public string HuyenMa { get; set; }
        public string XaMa { get; set; }
        public string NoiSinh { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public string NamSinh { get; set; }
        public DateTime? NgayThangNamSinh { get; set; }
        public DateTime? NgayHanMuc { get; set; }
        public string KhuVuc { get; set; }
    }
}
