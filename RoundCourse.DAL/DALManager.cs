using RoundCourse.Interfaces;
using RoundCourse.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.DAL
{
    public class DALManager : DbContext, IDALManager
    {
        private IResourceRepo resourceRepo;
        private ICourseRepo courseRepo;
        private IModuleRepo moduleRepo;
        private ILessonRepo lessonRepo;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>().HasRequired(c => c.Module)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Lesson>().HasRequired(c => c.Course)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Lesson>().HasRequired(c => c.Teacher)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Lesson>().HasRequired(c => c.BackupTeacher)
                .WithMany()
                .WillCascadeOnDelete(false);
        }

        public DALManager() : base("name=RoundCourseConnectionString")
        {
            Database.SetInitializer<DALManager>(new CreateDatabaseIfNotExists<DALManager>());
        }

        public virtual DbSet<Course> CourseCollection { get; set; }
        public virtual DbSet<Lesson> LessonCollection { get; set; }
        public virtual DbSet<Module> ModuleCollection { get; set; }
        public virtual DbSet<Resource> ResourceCollection { get; set; }

        public IResourceRepo Resources
        {
            get
            {
                if (resourceRepo == null)
                    resourceRepo = new ResourceRepo();
                return resourceRepo;
            }
        }

        public ICourseRepo Courses
        {
            get
            {
                if (courseRepo == null)
                    courseRepo = new CourseRepo();
                return courseRepo;
            }
        }

        public IModuleRepo Modules
        {
            get
            {
                if (moduleRepo == null)
                    moduleRepo = new ModuleRepo();
                return moduleRepo;
            }
        }

        public ILessonRepo Lessons
        {
            get
            {
                if (lessonRepo == null)
                    lessonRepo = new LessonRepo();
                return lessonRepo;
            }
        }
    }
}
