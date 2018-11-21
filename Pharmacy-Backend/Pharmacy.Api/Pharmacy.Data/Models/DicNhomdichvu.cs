using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicNhomdichvu
    {
        public DicNhomdichvu()
        {
            DicTieunhomdichvu = new HashSet<DicTieunhomdichvu>();
        }

        public int MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string TenNhomChiTiet { get; set; }
        public int? Bhyt { get; set; }
        public int? Stt { get; set; }
        public int Status { get; set; }

        public ICollection<DicTieunhomdichvu> DicTieunhomdichvu { get; set; }
    }
}
