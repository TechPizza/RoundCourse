using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces
{
    public interface IDALManager: IDisposable
    {
        IResourceRepo Resources { get; }
        ICourseRepo Courses { get; }
        IModuleRepo Modules { get; }
        ILessonRepo Lessons { get; }
    }
}
