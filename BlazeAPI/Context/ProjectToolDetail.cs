using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ProjectToolDetail
    {
        public ProjectToolDetail()
        {
            ProjectToolAccessDetail = new HashSet<ProjectToolAccessDetail>();
        }

        public int ProjectToolDetailId { get; set; }
        public int ProjectToolId { get; set; }
        public bool IsActive { get; set; }
        public string ToolUrl { get; set; }
        public string ToolProjectName { get; set; }
        public int ProjectId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual MasterProjectTools ProjectTool { get; set; }
        public virtual ICollection<ProjectToolAccessDetail> ProjectToolAccessDetail { get; set; }
    }
}
