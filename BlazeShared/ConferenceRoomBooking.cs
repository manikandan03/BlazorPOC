using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BlazeShared
{
    public class ConferenceRoomBooking
    {
        [Required]
        public int Id { get; set; }

        public int FloorId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Description should not more than 250 Characters")]
        public string Description { get; set; }

        //[Required]
        public string DepartmentId { get; set; }

        [Required]
        public string ProjectId { get; set; }

        [Required]
        [DisplayName("Booked Date")]
        public DateTime BookedDate { get; set; }

        public bool IsActive { get; set; }

        public string Attendees { get; set; }
        public string UserName { get; set; }
        //[Required]
        public string EmpID { get; set; }   

        [Required]
        //[Range(0,9999,ErrorMessage = "Employee should not more than 4 digits")]
        [MaxLength(4, ErrorMessage = "Employee should not more than 4 digits")]
        public string EmployeeId { get; set; }

        [Required]
        public string PurposeID { get; set; }


    }
}
