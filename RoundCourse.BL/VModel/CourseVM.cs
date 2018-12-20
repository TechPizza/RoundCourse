using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoundCourse.BL.VModel
{
    public class CourseVM
    {
        public int CourseId { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ResourceVM Coordinator { get; set; }
    }
}