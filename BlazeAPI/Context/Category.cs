using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Category
    {
        public Category()
        {
            CheckList = new HashSet<CheckList>();
            CheckListMapping = new HashSet<CheckListMapping>();
            ProjectCategoryMapping = new HashSet<ProjectCategoryMapping>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<CheckList> CheckList { get; set; }
        public virtual ICollection<CheckListMapping> CheckListMapping { get; set; }
        public virtual ICollection<ProjectCategoryMapping> ProjectCategoryMapping { get; set; }
    }
}
