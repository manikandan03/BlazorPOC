using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class DeliveryManagers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmpId { get; set; }
        public bool? IsActive { get; set; }
    }
}
