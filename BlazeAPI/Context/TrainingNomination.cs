using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingNomination
    {
        public int NominationId { get; set; }
        public int? TrainingId { get; set; }
        public int? TechnologyId { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string ProjectWon { get; set; }
        public string Project { get; set; }
        public string SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Purpose { get; set; }
        public bool? IsActive { get; set; }
        public int Score { get; set; }
        public bool NominationFlag { get; set; }
        public int? UserId { get; set; }
        public bool? CompletionFlag { get; set; }
        public string Reason { get; set; }
    }
}
