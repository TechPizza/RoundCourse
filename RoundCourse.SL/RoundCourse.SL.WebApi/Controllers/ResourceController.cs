using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Resources;
using System.Web.Http;
using RoundCourse.BL;
using RoundCourse.Interfaces.Entities;
using RoundCourse.BL.VModel;
using RoundCourse.BL.Mappers;

namespace RoundCourse.SL.WebApi.Controllers
{
    public class ResourceController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<ResourceVM> GetAll()
        {
            BL.ResourceManager mng = new BL.ResourceManager();
            List<Resource> lst = mng.GetAllResources().ToList();

            List<ResourceVM> res = ResourceMapper.MapListOfResource(lst).ToList();
            return res;
        }

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult GetResource(int id)
        {
            BL.ResourceManager mng = new BL.ResourceManager();
            Resource resource = mng.GetResourceById(id);

            if (resource == null)
                return NotFound();
            ResourceVM res = ResourceMapper.MapResource(resource);
            return Ok(res);
        }

        // POST api/<controller>
        public IHttpActionResult Post(ResourceVM item)
        {
            BL.ResourceManager mng = new BL.ResourceManager();
            Resource resource = ResourceMapper.MapResourceVM(item);

            mng.AddNewResource(resource);
            return Ok(item);
        }
    }
}