using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterBackendServiceType
    {
        public MasterBackendServiceType()
        {
            BackEndServiceLog = new HashSet<BackEndServiceLog>();
        }

        public int BackendServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string Purpose { get; set; }
        public bool IsActive { get; set; }
        public int NextExecutionDays { get; set; }
        public string Actionvia { get; set; }

        public virtual ICollection<BackEndServiceLog> BackEndServiceLog { get; set; }
    }
}
