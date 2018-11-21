using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicNhacungcap
    {
        public DicNhacungcap()
        {
            DicDichvu = new HashSet<DicDichvu>();
        }

        public int Id { get; set; }
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string NguoiDaiDien { get; set; }
        public int? Status { get; set; }

        public ICollection<DicDichvu> DicDichvu { get; set; }
    }
}
