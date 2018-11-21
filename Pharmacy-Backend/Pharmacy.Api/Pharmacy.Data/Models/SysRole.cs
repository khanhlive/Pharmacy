using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class SysRole
    {
        public SysRole()
        {
            SysRolePermissionMaping = new HashSet<SysRolePermissionMaping>();
            SysUser = new HashSet<SysUser>();
        }

        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
        public int EditVersion { get; set; }

        public ICollection<SysRolePermissionMaping> SysRolePermissionMaping { get; set; }
        public ICollection<SysUser> SysUser { get; set; }
    }
}
