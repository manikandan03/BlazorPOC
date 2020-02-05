using System;
using System.Collections.Generic;
using System.Text;

namespace BlazeShared
{
    public class ConferenceRoomModel
    {       
        public List<ConferenceDetail> ConferenceDetail { get; set; }       
        public ConferenceDetail CurrentConference { get; set; }        
        public int TotalNumberofFloors { get; set; }
    }

    public class ConferenceDetail
    {
        public int ConferenceID { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public string Duration { get; set; }
        public string ProjectName { get; set; }
        public string BookedBy { get; set; }
        public DateTime BookForm { get; set; }
        public DateTime BookTo{ get; set; }
        public int FloorID { get; set; }
        public DateTime BookedDate { get; set; }
        public int  UserId { get; set; }
        public int  IsBooked { get; set; }
        public int?  PurposeId { get; set; }
    }
}
