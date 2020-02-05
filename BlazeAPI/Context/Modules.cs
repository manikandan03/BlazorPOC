using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Modules
    {
        public Modules()
        {
            FunctionModules = new HashSet<FunctionModules>();
            ModulePages = new HashSet<ModulePages>();
            ModulePrecedanceOrder = new HashSet<ModulePrecedanceOrder>();
            RoleFunctionPrivileges = new HashSet<RoleFunctionPrivileges>();
        }

        public byte PageModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public int? ParentModuleId { get; set; }
        public string InitialPage { get; set; }
        public int? ListPosition { get; set; }
        public bool? IsSelectable { get; set; }
        public string Style { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<FunctionModules> FunctionModules { get; set; }
        public virtual ICollection<ModulePages> ModulePages { get; set; }
        public virtual ICollection<ModulePrecedanceOrder> ModulePrecedanceOrder { get; set; }
        public virtual ICollection<RoleFunctionPrivileges> RoleFunctionPrivileges { get; set; }
    }
}
