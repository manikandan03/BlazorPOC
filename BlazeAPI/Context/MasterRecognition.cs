using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterRecognition
    {
        public MasterRecognition()
        {
            EmployeeRecognition = new HashSet<EmployeeRecognition>();
        }

        public int RecognitionId { get; set; }
        public string Recognition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<EmployeeRecognition> EmployeeRecognition { get; set; }
    }
}
