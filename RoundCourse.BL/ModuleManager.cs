using RoundCourse.Common;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.BL
{
    public class ModuleManager
    {
        /// <summary>
        /// Returns a list of all Modules
        /// </summary>
        /// <returns>A list of all Modules(Entities)</returns>
        public IEnumerable<Module> GetAllModules()
        {
            DAL.ModuleRepo repo = null;
            IEnumerable<Module> res = null;

            try
            {
                repo = new DAL.ModuleRepo();
                res = repo.GetAll();
                return res;
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Return a Module with a specific identifier
        /// </summary>
        /// <param name="id">the Module identifier</param>
        /// <returns>The module identified</returns>
        public Module GetModuleById(int id)
        {
            DAL.ModuleRepo repo = null;
            Module res = null;

            try
            {
                repo = new DAL.ModuleRepo();
                res = repo.GetById(id);
                return res;
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw ex;
            }
        }

        
        /// <summary>
        /// Create the given module on Registry
        /// </summary>
        /// <param name="newModule">New Module to create</param>
        public void AddNewModule(Module newModule)
        {
            DAL.ModuleRepo repo = null;

            try
            {
                repo = new DAL.ModuleRepo();
                repo.Add(newModule);
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw;
            }
        }
    }
}
