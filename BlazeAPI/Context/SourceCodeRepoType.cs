using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SourceCodeRepoType
    {
        public SourceCodeRepoType()
        {
            SourceCodeRepoDetail = new HashSet<SourceCodeRepoDetail>();
        }

        public int SourceCodeRepoTypeId { get; set; }
        public string SourceCodeRepoName { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SourceCodeRepoDetail> SourceCodeRepoDetail { get; set; }
    }
}
