using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicChucvu
    {
        public int Id { get; set; }
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }
        public bool Status { get; set; }
    }
}
