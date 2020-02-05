using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class UserSkills
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Skills { get; set; }

        public virtual Users User { get; set; }
    }
}
