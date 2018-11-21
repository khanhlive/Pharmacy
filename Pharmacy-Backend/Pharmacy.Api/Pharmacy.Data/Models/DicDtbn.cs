using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicDtbn
    {
        public byte Iddtbn { get; set; }
        public string TenDtbn { get; set; }
        public string MoTa { get; set; }
        public int Status { get; set; }
        public byte HinhThucThanhToan { get; set; }
    }
}
