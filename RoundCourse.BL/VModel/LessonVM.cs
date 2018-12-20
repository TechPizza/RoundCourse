using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoundCourse.BL.VModel
{
    public class LessonVM
    {
        public int LessonId { get; set; }
        public CourseVM Course { get; set; }
        public ModuleVM Module { get; set; }
        public ResourceVM Teacher { get; set; }
        public ResourceVM BackupTeacher { get; set; }
        public DateTime ErogationDate { get; set; }
        public string Description { get; set; }
        public string Classroom { get; set; }
    }
}