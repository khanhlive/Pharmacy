using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicTieunhomdichvu
    {
        public DicTieunhomdichvu()
        {
            DicDichvu = new HashSet<DicDichvu>();
        }

        public int MaTieuNhom { get; set; }
        public string TenTieuNhom { get; set; }
        public int? MaNhom { get; set; }
        public string TenRutGon { get; set; }
        public byte? Stt { get; set; }
        public int Status { get; set; }

        public DicNhomdichvu MaNhomNavigation { get; set; }
        public ICollection<DicDichvu> DicDichvu { get; set; }
    }
}
