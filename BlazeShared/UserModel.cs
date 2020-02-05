using System;
using System.ComponentModel.DataAnnotations;

namespace BlazeShared
{
    public class UserModel
    { 
        public int UserId { get; set; }
        public string EmpId { get; set; }
        [Required(ErrorMessage ="Please enter username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
