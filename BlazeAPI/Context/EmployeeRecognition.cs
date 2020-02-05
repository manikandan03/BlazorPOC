using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeRecognition
    {
        public int EmployeeRecognitionId { get; set; }
        public int UserId { get; set; }
        public int? ProjectId { get; set; }
        public int RecognitionId { get; set; }
        public int RecognisedByUserId { get; set; }
        public string Comments { get; set; }
        public DateTime? RecognisedDate { get; set; }

        public virtual Users RecognisedByUser { get; set; }
        public virtual MasterRecognition Recognition { get; set; }
        public virtual Users User { get; set; }
    }
}
