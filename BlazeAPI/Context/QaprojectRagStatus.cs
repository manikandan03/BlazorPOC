using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class QaprojectRagStatus
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public int MemberTypeId { get; set; }
        public bool Isactive { get; set; }
        public int RagStatus { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? SprintId { get; set; }
        public string QaComments { get; set; }
        public int? ReviewWeekId { get; set; }

        public virtual MasterMemberTypes MemberType { get; set; }
        public virtual Projects Project { get; set; }
        public virtual MasterWeeks ReviewWeek { get; set; }
        public virtual Users User { get; set; }
    }
}
