using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.Interfaces
{
    public interface IResourceRepo
    {
        IEnumerable<Resource> GetAll();

        Resource GetByUser(string username);

        Resource GetById(int id);

        void Add(Resource newResource);
    }
}
