using RoundCourse.Common;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.BL
{
    public class LessonManager
    {
        /// <summary>
        /// Returns a list of all Lessons
        /// </summary>
        /// <returns>A list of all Lesson(Entities)</returns>
        public IEnumerable<Lesson> GetAllLesson()
        {
            DAL.LessonRepo repo = null;
            IEnumerable<Lesson> res = null;

            try
            {
                repo = new DAL.LessonRepo();
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
        /// Return a Lesson with a specific identifier
        /// </summary>
        /// <param name="id">the Lesson identifier</param>
        /// <returns>The lesson identified</returns>
        public Lesson GetModuleById(int id)
        {
            DAL.LessonRepo repo = null;
            Lesson res = null;

            try
            {
                repo = new DAL.LessonRepo();
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
        /// Create the given lesson on Registry
        /// </summary>
        /// <param name="newLesson">New Lesson to create</param>
        public void AddNewLesson(Lesson newLesson)
        {
            DAL.LessonRepo repo = null;

            try
            {
                repo = new DAL.LessonRepo();
                repo.Add(newLesson);
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Delete a lesson from registry
        /// </summary>
        /// <param name="lesson">the lesson to delete</param>
        public void DeleteLesson(Lesson lesson)
        {
            DAL.LessonRepo repo = null;

            try
            {
                repo = new DAL.LessonRepo();
                repo.Delete(lesson);
            }
            catch (Exception ex)
            {
                LogManager.Error(ex.Message);
                throw;
            }
        }
    }
}
