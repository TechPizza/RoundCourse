using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundCourse.DAL
{
    public abstract class RepoBase<T> : DbContext
        where T:class
    {
        private DbContext _context { get; set; }
        private DbSet<T> _dbSet { get; set; }

        protected DbContext Context
        {
            get
            {
                if(_context == null)
                {
                    _context = ((EFUnitOfWork)UnitOfWork.Current).Context;
                }
                return _context;
            }
        }

        protected DbSet<T> DbSet
        {
            get
            {
                if (_dbSet == null)
                    _dbSet = this.Context.Set<T>();
                return this._dbSet;
            }
        }

        public RepoBase()
        {
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            if (Context.Entry(entity).State == System.Data.Entity.EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
        }

        public virtual void Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException();
            DbSet.Add(entity);
        }
    }
}
