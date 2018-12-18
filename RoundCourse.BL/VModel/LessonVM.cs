using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoundCourse.BL.VModel
{
    public class LessonVM
    {
        public int LessonId { get; set; }
        public string Course { get; set; }
        public string Module { get; set; }
        public string Teacher { get; set; }
        public string BackupTeacher { get; set; }
        public DateTime ErogationDate { get; set; }
        public string Description { get; set; }
        public string Classroom { get; set; }
    }
}