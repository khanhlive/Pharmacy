using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class DicBenhvien
    {
        public DicBenhvien()
        {
            DicPhongban = new HashSet<DicPhongban>();
        }

        public int Id { get; set; }
        public string MaBenhVien { get; set; }
        public string MaTinh { get; set; }
        public string MaHuyen { get; set; }
        public string MaChuQuan { get; set; }
        public string TenBenhVien { get; set; }
        public string TuyenBenhVien { get; set; }
        public int HangBenhVien { get; set; }
        public string DiaChi { get; set; }
        public int Status { get; set; }
        public bool? Connect { get; set; }

        public DicHuyen MaHuyenNavigation { get; set; }
        public DicTinh MaTinhNavigation { get; set; }
        public ICollection<DicPhongban> DicPhongban { get; set; }
    }
}
