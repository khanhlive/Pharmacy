using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class SysSubsystem
    {
        public SysSubsystem()
        {
            SysRolePermissionMaping = new HashSet<SysRolePermissionMaping>();
        }

        public int SubSystemId { get; set; }
        public string SubSystemCode { get; set; }
        public string SubSystemName { get; set; }
        public string Description { get; set; }
        public string ParentId { get; set; }
        public int? SortOrder { get; set; }
        public int? SystemType { get; set; }
        public int EditVersion { get; set; }
        public int? GroupSystemId { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string ActionName { get; set; }
        public string Image { get; set; }

        public ICollection<SysRolePermissionMaping> SysRolePermissionMaping { get; set; }
    }
}
