using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssNhapduocchitiet
    {
        public int Id { get; set; }
        public int? NhapDuocId { get; set; }
        public int? DichVuMa { get; set; }
        public string SoLo { get; set; }
        public DateTime? HanDung { get; set; }
        public string DonVi { get; set; }
        public double DonGiaChiTiet { get; set; }
        public double DonGia { get; set; }
        public int Vat { get; set; }
        public double SoLuongNhap { get; set; }
        public double ThanhTienNhap { get; set; }
        public double SoLuongXuat { get; set; }
        public double ThanhTienXuat { get; set; }
        public double SoLuongKiemKe { get; set; }
        public double ThanhTienKiemKe { get; set; }
        public double SoLuongSuDung { get; set; }
        public double ThanhTienSuDung { get; set; }
        public string NhaCungCapMa { get; set; }
        public string SoDangKy { get; set; }
        public double DonGiaDongY { get; set; }
        public double SoLuongDongY { get; set; }
        public double ThanhTienDongY { get; set; }
        public int? BenhNhanMa { get; set; }
        public byte DoiTuongBenhNhanMa { get; set; }
        public double DonGiaXuat { get; set; }
        public string GhiChu { get; set; }
        public int TrongBaoHiem { get; set; }
    }
}
