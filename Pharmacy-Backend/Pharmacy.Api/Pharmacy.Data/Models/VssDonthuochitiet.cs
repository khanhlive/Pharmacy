using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssDonthuochitiet
    {
        public int Id { get; set; }
        public int? DonThuocId { get; set; }
        public int? DichVuMa { get; set; }
        public string DonVi { get; set; }
        public double DonGia { get; set; }
        public string SoLo { get; set; }
        public double SoLuong { get; set; }
        public double ThanhTien { get; set; }
        public double TienBenhNhan { get; set; }
        public double TienBaoHiem { get; set; }
        public double TienChenhLenh { get; set; }
        public int TrongBaoHiem { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string DuongDung { get; set; }
        public string MoiLan { get; set; }
        public string DonViUong { get; set; }
        public string SoLan { get; set; }
        public string LieuLuong { get; set; }
        public string NhaCungCapMa { get; set; }
        public int SoPhieuLinh { get; set; }
        public int? Status { get; set; }
        public int? ChiDinhId { get; set; }
        public string CanBoMa { get; set; }
        public string DanhSachCanBoThucHien { get; set; }
        public int? PhongBanMa { get; set; }
        public int BenhNhanKhamBenhId { get; set; }
        public byte Loai { get; set; }
        public int ThanhToan { get; set; }
        public int MienGiam { get; set; }
        public string GhiChu { get; set; }
        public int PhongBanTongKetMa { get; set; }
        public int? PhongBanXuatMa { get; set; }
        public double TyLeThanhToan { get; set; }
        public int XaHoiHoa { get; set; }
        public double SoLuongChiTiet { get; set; }
        public int? DonThuocChiTietAttachId { get; set; }
        public DateTime? HanDung { get; set; }
        public int LoaiDichVu { get; set; }
    }
}
