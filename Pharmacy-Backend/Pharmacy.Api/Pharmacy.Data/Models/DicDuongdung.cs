using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicDuongdung
    {
        public int Id { get; set; }
        public int? Stt { get; set; }
        public string MaDuongDung { get; set; }
        public string TenDuongDung { get; set; }
    }
}
