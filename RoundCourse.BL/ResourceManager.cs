using RoundCourse.Common;
using RoundCourse.Interfaces;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.BL
{
    public class ResourceManager
    {
        /// <summary>
        /// Returns a list of all Resources
        /// </summary>
        /// <returns>A list of all Resources(Entities)</returns>
        public IEnumerable<Resource> GetAllResources()
        {
            DAL.ResourceRepo repo = null;
            IEnumerable<Resource> res = null;

            try
            {
                repo = new DAL.ResourceRepo();
                res = repo.GetAll();
                return res;
            }
            catch(Exception ex)
            {
                LogManager.Error(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Return a Resource with a specific identifier
        /// </summary>
        /// <param name="id">the Resource identifier</param>
        /// <returns>The resource identified</returns>
        public Resource GetResourceById(int id)
        {
            DAL.ResourceRepo repo = null;
            Resource res = null;

            try
            {
                repo = new DAL.ResourceRepo();
                res = repo.GetById(id);
                return res;
            }
            catch(Exception ex)
            {
                LogManager.Error(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Return a Resource with a specific username
        /// </summary>
        /// <param name="username">The resource username</param>
        /// <returns>The resource identified</returns>
        public Resource GetResourceByUser(string username)
        {
            DAL.ResourceRepo repo = null;
            Resource res = null;

            try
            {
                repo = new DAL.ResourceRepo();
                res = repo.GetByUser(username);
                return res;
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Create the given user on Registry
        /// </summary>
        /// <param name="newResource">New Resource to create</param>
        public void AddNewResource(Resource newResource)
        {
            DAL.ResourceRepo repo = null;

            try
            {
                repo = new DAL.ResourceRepo();
                repo.Add(newResource);
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw;
            }
        }
    }
}
