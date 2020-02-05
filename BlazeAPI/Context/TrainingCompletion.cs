using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TrainingCompletion
    {
        public int CompletionId { get; set; }
        public int? TrainingId { get; set; }
        public string TrainingName { get; set; }
        public DateTime? Date { get; set; }
        public string Attendece { get; set; }
        public string Material { get; set; }
        public bool? IsActive { get; set; }
        public int? Count { get; set; }
    }
}
