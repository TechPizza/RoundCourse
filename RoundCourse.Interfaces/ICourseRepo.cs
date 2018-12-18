using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces
{
    public interface ICourseRepo
    {
        IEnumerable<Course> GetAll();

        Course GetById(int id);

        void Add(Course newCourse);
    }
}
