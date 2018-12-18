using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces
{
    public interface ILessonRepo
    {
        IEnumerable<Lesson> GetAll();

        Lesson GetById(int id);

        void Add(Lesson newLesson);

        void Delete(Lesson lesson);
    }
}
