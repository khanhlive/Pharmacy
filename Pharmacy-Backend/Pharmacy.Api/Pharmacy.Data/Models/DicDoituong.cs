using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicDoituong
    {
        public string MaDoiTuong { get; set; }
        public string TenDoiTuong { get; set; }
        public string NhomDoiTuong { get; set; }
        public int? VanChuyen { get; set; }
        public int? MaMuc { get; set; }
        public int? MucCu { get; set; }
        public int? Status { get; set; }
    }
}
