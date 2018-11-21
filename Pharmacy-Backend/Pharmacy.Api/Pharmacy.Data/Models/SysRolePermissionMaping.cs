using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class SysRolePermissionMaping
    {
        public int Id { get; set; }
        public int SubSystemId { get; set; }
        public int? RoleId { get; set; }
        public int AllowAll { get; set; }
        public int AllowView { get; set; }
        public int AllowAdd { get; set; }
        public int AllowEdit { get; set; }
        public int AllowDelete { get; set; }
        public int AllowApproval { get; set; }
        public int AllowDisapproval { get; set; }
        public int AllowPrint { get; set; }
        public int AllowImportExcel { get; set; }
        public int AllowExportExcel { get; set; }
        public int AllowViewSubRef { get; set; }
        public int AllowAddSubRef { get; set; }
        public int InActive { get; set; }

        public SysRole Role { get; set; }
        public SysSubsystem SubSystem { get; set; }
    }
}
