using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingPermission
    {
        public int TrainingId { get; set; }
        public int? PermissionId { get; set; }
        public int? UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
