using System;
using System.ComponentModel.DataAnnotations;

namespace Blaze.Shared
{
    public class UserModel
    {
        [Required(ErrorMessage ="Please enter username") ]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string password { get; set; }
    }
}
