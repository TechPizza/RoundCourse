using RoundCourse.Interfaces;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.DAL
{
    public class LessonRepo : RepoBase<Lesson>, ILessonRepo
    {
        public Lesson GetById(int id)
        {
            return ((DALManager)Context).LessonCollection.Find(id);
        }
    }
}
