using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicDichvu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public string HamLuong { get; set; }
        public string DonViTinh { get; set; }
        public double? DonGia { get; set; }
        public int? TrongDanhMuc { get; set; }
        public int? Loai { get; set; }
        public int? BaoHiemThanhToan { get; set; }
        public int? DichVuKyThuatCao { get; set; }
        public int? PhanLoaiDichVu { get; set; }
        public string TenHoatChat { get; set; }
        public string NuocSanXuat { get; set; }
        public string DuongDung { get; set; }
        public int? MaTieuNhomDichVu { get; set; }
        public string SoDangKy { get; set; }
        public string DangBaoChe { get; set; }
        public string NhaSanXuat { get; set; }
        public string QuyCachPhamChat { get; set; }
        public int? BaoHiemYte { get; set; }
        public string MaQuyetDinh { get; set; }
        public string TenRutGon { get; set; }
        public string TinhTrangNhap { get; set; }
        public string NguonGoc { get; set; }
        public string Ycsd { get; set; }
        public double? TyLeSoChePhucChe { get; set; }
        public double? TyLeBaoQuan { get; set; }
        public string BoPhanDung { get; set; }
        public bool? DongY { get; set; }
        public string PhuongPhap { get; set; }
        public string MaNhaCungCap { get; set; }
        public int? SoThuTu { get; set; }
        public double? DonGia2 { get; set; }
        public string SoThuTuQuyetDinh { get; set; }
        public int? SoLuongMin { get; set; }
        public string DonViNhap { get; set; }
        public int TyLeSuDung { get; set; }
        public string MaTam { get; set; }
        public string TieuChuan { get; set; }
        public string TuoiTho { get; set; }
        public int? MaNhom { get; set; }
        public string MaDuongDung { get; set; }
        public double? SoLuong { get; set; }
        public string SoQuyetDinh { get; set; }
        public DateTime? NgayQuyetDinh { get; set; }
        public int? MaCongTySanXuat { get; set; }
        public int? MaCongTyDangKy { get; set; }
        public string MaDichVuBackUp { get; set; }
        public string MaPhongBanSd { get; set; }
        public int? DinhMuc { get; set; }
        public string MaAtc { get; set; }
        public double? DongiaT7 { get; set; }
        public string MaHoatChat { get; set; }
        public double? DonGiaBhyt { get; set; }
        public string DanhSachDonGia { get; set; }
        public int? Status { get; set; }
        public double? GiaDichVuDot2 { get; set; }
        public double? GiaPhuThu { get; set; }
        public string DanhSachDoiTuongBenhNhan { get; set; }
        public double? DonGiaGioiHanTt04 { get; set; }
        public string GoiThau { get; set; }
        public string LoaiThau { get; set; }
        public string NhaThau { get; set; }
        public string LoaiThuoc { get; set; }
        public string NhomThau { get; set; }

        public DicNhacungcap MaNhaCungCapNavigation { get; set; }
        public DicTieunhomdichvu MaTieuNhomDichVuNavigation { get; set; }
    }
}
