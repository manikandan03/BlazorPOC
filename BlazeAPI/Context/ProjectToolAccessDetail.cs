using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectToolAccessDetail
    {
        public int ProjectToolAccessDetailId { get; set; }
        public int ProjectToolDetailId { get; set; }
        public int UserId { get; set; }
        public DateTime Createddate { get; set; }
        public bool IsActive { get; set; }

        public virtual ProjectToolDetail ProjectToolDetail { get; set; }
        public virtual Users User { get; set; }
    }
}
