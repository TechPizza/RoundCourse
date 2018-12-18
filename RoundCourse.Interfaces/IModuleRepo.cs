using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces
{
    public interface IModuleRepo
    {
        IEnumerable<Module> GetAll();

        Module GetById(int id);

        void Add(Module module);
    }
}
