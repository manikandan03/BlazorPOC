using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectStatus
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int StatusId { get; set; }
        public string StatusComments { get; set; }
        public DateTime CommentsCreated { get; set; }
        public int? CommnetedBy { get; set; }

        public virtual Projects Project { get; set; }
    }
}
