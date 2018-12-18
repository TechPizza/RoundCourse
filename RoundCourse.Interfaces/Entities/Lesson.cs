using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces.Entities
{
    public class Lesson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LessonId { get; set; }
        [Required]
        public Course Course { get; set; }
        [Required]
        public Module Module { get; set; }
        [Required]
        public Resource Teacher { get; set; }
        [Required]
        public Resource BackupTeacher { get; set; }
        [Required]
        public DateTime ErogationDate { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Classroom { get; set; }
    }
}
