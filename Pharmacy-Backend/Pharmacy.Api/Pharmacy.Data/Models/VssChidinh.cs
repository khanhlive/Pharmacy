using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssChidinh
    {
        public int Id { get; set; }
        public int? Ma { get; set; }
        public int? CanLamSangId { get; set; }
        public int? DichVuMa { get; set; }
        public int? Status { get; set; }
        public string ChiDinh { get; set; }
        public string KetLuan { get; set; }
        public string LoiDan { get; set; }
        public int? SoPhieu { get; set; }
        public int? TamThu { get; set; }
        public int? TrongBaoHiem { get; set; }
        public string MauLanMtruongXn { get; set; }
        public double DonGia { get; set; }
        public int XaHoiHoa { get; set; }
        public string GhiChu { get; set; }
        public string DanhsachCanBoThuchien { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public string CanBoThucHienMa { get; set; }
        public string MoTa { get; set; }
        public int? NgoaiGioHanhChinh { get; set; }
        public int LoaiDichVu { get; set; }
        public int? Icd9 { get; set; }
        public string MaMay { get; set; }
    }
}
