using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterMemberTypes
    {
        public MasterMemberTypes()
        {
            QaprojectRagStatus = new HashSet<QaprojectRagStatus>();
            QareportQuestions = new HashSet<QareportQuestions>();
        }

        public int MemberTypeId { get; set; }
        public string MemberType { get; set; }

        public virtual ICollection<QaprojectRagStatus> QaprojectRagStatus { get; set; }
        public virtual ICollection<QareportQuestions> QareportQuestions { get; set; }
    }
}
