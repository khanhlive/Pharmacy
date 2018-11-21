using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicDantoc
    {
        public DicDantoc()
        {
            DicCanbo = new HashSet<DicCanbo>();
        }

        public string MaDanToc { get; set; }
        public string TenDanToc { get; set; }
        public string MoTa { get; set; }
        public int Status { get; set; }

        public ICollection<DicCanbo> DicCanbo { get; set; }
    }
}
