using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicCanbo
    {
        public string MaCanBo { get; set; }
        public string TenCanBo { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public string CapBac { get; set; }
        public string BangCap { get; set; }
        public int MaPhongBan { get; set; }
        public string MaDanToc { get; set; }
        public byte[] Image { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool KhoaChungTu { get; set; }

        public DicDantoc MaDanTocNavigation { get; set; }
        public DicPhongban MaPhongBanNavigation { get; set; }
    }
}
