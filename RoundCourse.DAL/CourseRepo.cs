using RoundCourse.Interfaces;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.DAL
{
    public class CourseRepo : RepoBase<Course>, ICourseRepo
    {
        public Course GetById(int id)
        {
            return ((DALManager)Context).CourseCollection.Find(id);
        }

    }
}
