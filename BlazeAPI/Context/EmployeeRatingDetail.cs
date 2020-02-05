using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class EmployeeRatingDetail
    {
        public int EmployeeRatingDetailId { get; set; }
        public int EmployeeRatingId { get; set; }
        public int RatingCriteriaId { get; set; }
        public string RatingValue { get; set; }
        public string RatingComments { get; set; }

        public virtual EmployeeRating EmployeeRating { get; set; }
        public virtual MasterRatingCriteria RatingCriteria { get; set; }
    }
}
