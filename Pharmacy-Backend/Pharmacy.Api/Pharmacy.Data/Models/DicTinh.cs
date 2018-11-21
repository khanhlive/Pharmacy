using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicTinh
    {
        public DicTinh()
        {
            DicBenhvien = new HashSet<DicBenhvien>();
            DicHuyen = new HashSet<DicHuyen>();
        }

        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
        public string Cap { get; set; }
        public int Status { get; set; }

        public ICollection<DicBenhvien> DicBenhvien { get; set; }
        public ICollection<DicHuyen> DicHuyen { get; set; }
    }
}
