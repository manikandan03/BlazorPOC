using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class FeedbackComments
    {
        public int FeedbackCommentsId { get; set; }
        public int UserFeedbackId { get; set; }
        public int CommentedbyUserId { get; set; }
        public string Comments { get; set; }
        public DateTime CommentedDatetime { get; set; }

        public virtual Users CommentedbyUser { get; set; }
        public virtual UserFeedback UserFeedback { get; set; }
    }
}
