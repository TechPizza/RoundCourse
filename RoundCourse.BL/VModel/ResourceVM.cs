using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoundCourse.BL.VModel
{
    public class ResourceVM
    {
        public int ResourceId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}