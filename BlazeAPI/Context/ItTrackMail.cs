using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ItTrackMail
    {
        public int ItrequestId { get; set; }
        public bool? IsIthead { get; set; }
        public bool? IsReportingMail { get; set; }
        public bool? IsReportingApproval { get; set; }
        public bool? IsEngineerTeam { get; set; }
        public bool? IsRequestClose { get; set; }
        public bool? IsRequestRejected { get; set; }
        public bool? IsMachineMovement { get; set; }
        public bool? IsGitaccess { get; set; }
        public bool? IsRequestRevoke { get; set; }
    }
}
