using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Functions
    {
        public Functions()
        {
            FunctionModules = new HashSet<FunctionModules>();
            FunctionPrecedanceOrder = new HashSet<FunctionPrecedanceOrder>();
            RoleFunctionPrivileges = new HashSet<RoleFunctionPrivileges>();
            RoleFunctions = new HashSet<RoleFunctions>();
        }

        public byte FunctionId { get; set; }
        public string FunctionName { get; set; }
        public string Style { get; set; }
        public string FunctionDescription { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<FunctionModules> FunctionModules { get; set; }
        public virtual ICollection<FunctionPrecedanceOrder> FunctionPrecedanceOrder { get; set; }
        public virtual ICollection<RoleFunctionPrivileges> RoleFunctionPrivileges { get; set; }
        public virtual ICollection<RoleFunctions> RoleFunctions { get; set; }
    }
}
