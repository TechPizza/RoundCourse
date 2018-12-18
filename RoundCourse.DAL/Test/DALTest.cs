using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RoundCourse.Interfaces.Entities;

namespace RoundCourse.DAL.Test
{
    [TestClass]
    public class DALTest
    {
        [TestMethod]
        public void ResourceTest()
        {
            using (DALManager dm = new DALManager())
            {
                var repo = dm.Resources;
                var set = repo.GetAll();
                Assert.IsTrue(set.Any());
            }
        }

        [TestMethod]
        public void AddResourceTest()
        {
            using (DALManager dm = new DALManager())
            {
                var repo = dm.Resources;
                Resource resource = new Resource
                { FirstName = "Test", LastName = "Reti", IsActive = true };
                repo.Add(resource);
            }
        }
    }
}
