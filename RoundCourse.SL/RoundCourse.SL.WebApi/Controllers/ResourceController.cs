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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}