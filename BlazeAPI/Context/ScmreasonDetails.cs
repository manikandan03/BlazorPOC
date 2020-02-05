using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ScmreasonDetails
    {
        public long Scmid { get; set; }
        public int SourceCodeRepoId { get; set; }
        public int UserId { get; set; }
        public string Reason { get; set; }
        public DateTime Datetime { get; set; }
        public DateTime WeekDatetime { get; set; }

        public virtual SourceCodeRepoDetail SourceCodeRepo { get; set; }
        public virtual Users User { get; set; }
    }
}
