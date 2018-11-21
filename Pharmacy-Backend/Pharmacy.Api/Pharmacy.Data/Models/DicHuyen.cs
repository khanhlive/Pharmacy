using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicHuyen
    {
        public DicHuyen()
        {
            DicBenhvien = new HashSet<DicBenhvien>();
            DicXaphuong = new HashSet<DicXaphuong>();
        }

        public string MaHuyen { get; set; }
        public string TenHuyen { get; set; }
        public string Cap { get; set; }
        public string MaTinh { get; set; }
        public int Status { get; set; }

        public DicTinh MaTinhNavigation { get; set; }
        public ICollection<DicBenhvien> DicBenhvien { get; set; }
        public ICollection<DicXaphuong> DicXaphuong { get; set; }
    }
}
