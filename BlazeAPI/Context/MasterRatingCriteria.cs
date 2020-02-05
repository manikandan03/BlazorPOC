using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterRatingCriteria
    {
        public MasterRatingCriteria()
        {
            EmployeeRatingDetail = new HashSet<EmployeeRatingDetail>();
        }

        public int RatingCriteriaId { get; set; }
        public string RatingCriteria { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<EmployeeRatingDetail> EmployeeRatingDetail { get; set; }
    }
}
