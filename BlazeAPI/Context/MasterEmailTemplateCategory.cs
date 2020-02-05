using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterEmailTemplateCategory
    {
        public int EmailTemplateCategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }
    }
}
