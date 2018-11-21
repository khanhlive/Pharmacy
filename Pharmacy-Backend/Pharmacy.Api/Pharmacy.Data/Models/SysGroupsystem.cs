using System;
using System.Collections.Generic;

namespace Pharmacy.Data.Models
{
    public partial class SysGroupsystem
    {
        public int SystemId { get; set; }
        public string SystemCode { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public int? SystemType { get; set; }
        public int EditVersion { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
    }
}
