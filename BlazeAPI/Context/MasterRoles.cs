using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterRoles
    {
        public MasterRoles()
        {
            FunctionPrecedanceOrder = new HashSet<FunctionPrecedanceOrder>();
            ManageTab = new HashSet<ManageTab>();
            ModulePrecedanceOrder = new HashSet<ModulePrecedanceOrder>();
            ReportingPersonsRollId = new HashSet<ReportingPersonsRollId>();
            RoleFunctionPrivileges = new HashSet<RoleFunctionPrivileges>();
            RoleFunctions = new HashSet<RoleFunctions>();
            UserProjects = new HashSet<UserProjects>();
            UserRoleQuickAccessMenu = new HashSet<UserRoleQuickAccessMenu>();
            UserRoles = new HashSet<UserRoles>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<FunctionPrecedanceOrder> FunctionPrecedanceOrder { get; set; }
        public virtual ICollection<ManageTab> ManageTab { get; set; }
        public virtual ICollection<ModulePrecedanceOrder> ModulePrecedanceOrder { get; set; }
        public virtual ICollection<ReportingPersonsRollId> ReportingPersonsRollId { get; set; }
        public virtual ICollection<RoleFunctionPrivileges> RoleFunctionPrivileges { get; set; }
        public virtual ICollection<RoleFunctions> RoleFunctions { get; set; }
        public virtual ICollection<UserProjects> UserProjects { get; set; }
        public virtual ICollection<UserRoleQuickAccessMenu> UserRoleQuickAccessMenu { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
