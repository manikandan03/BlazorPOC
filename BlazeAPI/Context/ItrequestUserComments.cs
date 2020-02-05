using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ItrequestUserComments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItrequestId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Comments { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Itrequest Itrequest { get; set; }
        public virtual Users User { get; set; }
    }
}
