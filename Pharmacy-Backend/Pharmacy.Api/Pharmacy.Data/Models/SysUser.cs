using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class SysUser
    {
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogonTime { get; set; }
        public string LastIpLogon { get; set; }
        public bool? IsOnline { get; set; }
        public string SessionKey { get; set; }
        public DateTime? SessionExpire { get; set; }
        public int? Sid { get; set; }
        public int? RoleId { get; set; }
        public bool? IsLogin { get; set; }
        public byte[] Photo { get; set; }
        public bool Inactive { get; set; }
        public bool IsSystem { get; set; }
        public int EditVersion { get; set; }

        public SysRole Role { get; set; }
    }
}
