using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundCourse.BL.VModel;
using RoundCourse.Interfaces.Entities;

namespace RoundCourse.BL.Mappers
{
    public static class ResourceMapper
    {
        public static ResourceVM MapResource(Resource entity)
        {
            ResourceVM res = new ResourceVM
            {
                ResourceId = entity.ResourceId,
                Username = entity.Username,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
           
            return res;
        }

        public static IEnumerable<ResourceVM> MapListOfResource(IEnumerable<Resource> entities)
        {
            IEnumerable<ResourceVM> res = entities.Select(t => new ResourceVM()
            {
                ResourceId = t.ResourceId,
                Username = t.Username,
                FirstName = t.FirstName,
                LastName = t.LastName
            });

            return res;
        }

        public static Resource MapResourceVM(ResourceVM vm)
        {
            Resource res = new Resource
            {
                ResourceId = vm.ResourceId,
                Username = vm.Username,
                FirstName = vm.FirstName,
                LastName = vm.LastName
            };

            return res;
        }
    }
}
