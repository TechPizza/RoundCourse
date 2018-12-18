using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundCourse.BL.VModel;
using RoundCourse.Interfaces.Entities;

namespace RoundCourse.BL.Mappers
{
    public class ResourceMapper
    {
        public static ResourceVM MapResource(Resource entity)
        {
            ResourceVM res = new ResourceVM();

            res.ResourceId = entity.ResourceId;
            res.Username = entity.Username;
            res.FirstName = entity.FirstName;
            res.LastName = entity.LastName;
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
    }
}
