using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SourceRepoBranchDetail
    {
        public int SourceRepoBranchDetail1 { get; set; }
        public int SourceRepoId { get; set; }
        public string BranchName { get; set; }
        public DateTime? BranchCreatedDateTime { get; set; }
        public bool? ActiveBranch { get; set; }
        public DateTime? LastCommittedDate { get; set; }

        public virtual SourceCodeRepoDetail SourceRepo { get; set; }
    }
}
