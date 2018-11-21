using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicXaphuong
    {
        public string MaXa { get; set; }
        public string TenXa { get; set; }
        public string Cap { get; set; }
        public string MaHuyen { get; set; }
        public string TinhMa { get; set; }
        public int Status { get; set; }

        public DicHuyen MaHuyenNavigation { get; set; }
    }
}
