using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Dictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PreviousName { get; set; }
        public bool? IsActive { get; set; }
    }
}
