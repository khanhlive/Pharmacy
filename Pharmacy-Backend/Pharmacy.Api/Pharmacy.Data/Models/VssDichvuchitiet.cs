using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class VssDichvuchitiet
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public int? DichVuMa { get; set; }
        public string Ten { get; set; }
        public string TriSoBinhThuong { get; set; }
        public int? Stt { get; set; }
        public int? Status { get; set; }
        public string DonVi { get; set; }
        public string TriSoBinhThuongNu { get; set; }
        public string TriSoNamTu { get; set; }
        public string TriSoNamDen { get; set; }
        public string TriSoNuTu { get; set; }
        public string TriSoNuDen { get; set; }
        public string TenMay { get; set; }
        public string TriSoBinhThuongNam { get; set; }
        public string KetQua { get; set; }
        public byte? SoThuTuF { get; set; }
        public byte SthuTuR { get; set; }
    }
}
