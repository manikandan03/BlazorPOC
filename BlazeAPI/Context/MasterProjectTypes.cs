using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterProjectTypes
    {
        public MasterProjectTypes()
        {
            Projects = new HashSet<Projects>();
            QareportQuestions = new HashSet<QareportQuestions>();
        }

        public int ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<QareportQuestions> QareportQuestions { get; set; }
    }
}
