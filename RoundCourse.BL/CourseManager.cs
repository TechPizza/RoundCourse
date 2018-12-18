using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundCourse.Common;
using RoundCourse.Interfaces.Entities;

namespace RoundCourse.BL
{
    public class CourseManager
    {
        /// <summary>
        /// Returns a list of all Courses
        /// </summary>
        /// <returns>A list of all Courses(Entities)</returns>
        public IEnumerable<Course> GetAllCourses()
        {
            DAL.CourseRepo repo = null;
            IEnumerable<Course> res = null;

            try
            {
                repo = new DAL.CourseRepo();
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
        /// Return a Course with a specific identifier
        /// </summary>
        /// <param name="id">the Course identifier</param>
        /// <returns>The course identified</returns>
        public Course GetCourseById(int id)
        {
            DAL.CourseRepo repo = null;
            Course res = null;

            try
            {
                repo = new DAL.CourseRepo();
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
        /// Create the given course on Registry
        /// </summary>
        /// <param name="newCourse">New Course to create</param>
        public void AddNewResource(Course newCourse)
        {
            DAL.CourseRepo repo = null;

            try
            {
                repo = new DAL.CourseRepo();
                repo.Add(newCourse);
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw;
            }
        }
    }
}
