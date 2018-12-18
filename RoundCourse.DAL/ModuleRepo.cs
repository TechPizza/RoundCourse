using RoundCourse.Interfaces;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.DAL
{
    public class ModuleRepo : RepoBase<Module>, IModuleRepo
    {
        public Module GetById(int id)
        {
            return ((DALManager)Context).ModuleCollection.Find(id);
        }
    }
}
