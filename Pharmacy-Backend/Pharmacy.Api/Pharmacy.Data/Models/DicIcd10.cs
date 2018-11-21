using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicIcd10
    {
        public int Id { get; set; }
        public string MaIcd { get; set; }
        public string TenIcd { get; set; }
        public int Status { get; set; }
        public string MaChuongBenh { get; set; }
        public string TenChuongBenh { get; set; }
        public string TenWhoe { get; set; }
        public string TenWho { get; set; }
        public int? Idcb { get; set; }
        public int? IdMbicd { get; set; }
        public string TenIcdYhct { get; set; }
        public string MaIcd10 { get; set; }
    }
}
