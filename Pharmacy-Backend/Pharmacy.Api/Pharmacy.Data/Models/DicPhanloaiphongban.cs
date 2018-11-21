using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicPhanloaiphongban
    {
        public DicPhanloaiphongban()
        {
            DicPhongban = new HashSet<DicPhongban>();
        }

        public int Id { get; set; }
        public string PhanLoai { get; set; }
        public bool Status { get; set; }
        public string Ma { get; set; }

        public ICollection<DicPhongban> DicPhongban { get; set; }
    }
}
