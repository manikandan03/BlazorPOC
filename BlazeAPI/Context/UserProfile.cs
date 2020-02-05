using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte[] Photo { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Users User { get; set; }
    }
}
