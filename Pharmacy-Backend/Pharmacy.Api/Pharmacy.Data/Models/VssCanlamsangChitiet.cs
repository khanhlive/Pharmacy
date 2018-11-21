using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssCanlamsangChitiet
    {
        public int Id { get; set; }
        public int? CanLamSangId { get; set; }
        public string DichvuChitietMa { get; set; }
        public string ChiDinh { get; set; }
        public int? Status { get; set; }
        public string CanBoMa { get; set; }
        public DateTime? Ngaythang { get; set; }
        public int? ChiDinhId { get; set; }
        public int? Sttht { get; set; }
        public string KetQua { get; set; }
        public double? SoPhieu { get; set; }
        public string KetquaXetNghiem { get; set; }
        public string DuongDan { get; set; }
        public string DuongDan2 { get; set; }
    }
}
