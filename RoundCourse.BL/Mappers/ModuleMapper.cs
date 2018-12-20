using RoundCourse.BL.VModel;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.BL.Mappers
{
    public class ModuleMapper
    {
        public static ModuleVM MapResource(Module entity)
        {
            ModuleVM res = new ModuleVM
            {
                ModuleId = entity.ModuleId,
                Title = entity.Title,
                Credits = entity.Credits
            };

            return res;
        }

        public static IEnumerable<ModuleVM> MapListOfResource(IEnumerable<Module> entities)
        {
            IEnumerable<ModuleVM> res = entities.Select(t => new ModuleVM()
            {
                ModuleId = t.ModuleId,
                Title = t.Title,
                Credits = t.Credits
            });

            return res;
        }

        public static Module MapResourceVM(ModuleVM vm)
        {
            Module res = new Module
            {
                ModuleId = vm.ModuleId,
                Title = vm.Title,
                Credits = vm.Credits
            };

            return res;
        }
    }
}
