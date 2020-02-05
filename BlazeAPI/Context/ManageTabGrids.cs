using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ManageTabGrids
    {
        public int ManageGridId { get; set; }
        public int? GridId { get; set; }
        public int? UserId { get; set; }
        public byte? RoleId { get; set; }
        public bool? IsActive { get; set; }
        public bool? UserSelected { get; set; }
    }
}
