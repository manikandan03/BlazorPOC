using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class GitAccessDetail
    {
        public int GitAccessDetailId { get; set; }
        public int UserId { get; set; }
        public int SourceCodeRepoId { get; set; }
        public DateTime Createddate { get; set; }
        public bool IsActive { get; set; }

        public virtual SourceCodeRepoDetail SourceCodeRepo { get; set; }
        public virtual Users User { get; set; }
    }
}
