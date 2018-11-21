using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssBenhnhan
    {
        public int Id { get; set; }
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public string SoTheBhyt { get; set; }
        public int? Tuoi { get; set; }
        public string GioiTinhMa { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public string NamSinh { get; set; }
        public DateTime? NgayThangNamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DoiTuong { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string MaCoSo { get; set; }
        public int? LaBenhNhanNoiTru { get; set; }
        public string TrieuChung { get; set; }
        public int? PhongBanMa { get; set; }
        public int? TuyenBenhVien { get; set; }
        public string ChanDoanNoiGioiThieu { get; set; }
        public int? CapCuu { get; set; }
        public int? NoiTinh { get; set; }
        public int? SoThuTu { get; set; }
        public int? TrangThaiBenhNhan { get; set; }
        public DateTime? HanBaoHiemTu { get; set; }
        public DateTime? HanBaoHiemDen { get; set; }
        public string BenhVienMa { get; set; }
        public string ChuyenKhoaMa { get; set; }
        public int? LaNgoaiGio { get; set; }
        public int? TuyenDuoi { get; set; }
        public int? SoKhamBenh { get; set; }
        public decimal? MucHuongBaoHiem { get; set; }
        public string KhuVuc { get; set; }
        public DateTime? NgayHanMuc { get; set; }
        public decimal? LuongCoSo { get; set; }
        public bool? LaUuTien { get; set; }
        public bool DieuTriNgoaiTru { get; set; }
        public string DoiTuongMa { get; set; }
        public int? PersonMa { get; set; }
        public bool NoThe { get; set; }
        public int DoiTuongBenhNhanMa { get; set; }
        public string MaLienKet { get; set; }
        public string MaKhamChuaBenh { get; set; }
        public bool Export { get; set; }
        public string CanBoMa { get; set; }
    }
}
