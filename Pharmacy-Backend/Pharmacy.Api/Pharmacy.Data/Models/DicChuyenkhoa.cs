using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicChuyenkhoa
    {
        public DicChuyenkhoa()
        {
            DicPhongban = new HashSet<DicPhongban>();
        }

        public int MaChuyenKhoa { get; set; }
        public string TenChuyenKhoa { get; set; }
        public string TenChiTiet { get; set; }
        public string MaQuyetDinh { get; set; }
        public int Status { get; set; }

        public ICollection<DicPhongban> DicPhongban { get; set; }
    }
}
