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
    public class ResourceRepo : RepoBase<Resource>, IResourceRepo
    {
        public override void Add(Resource newResource)
        {
            if (newResource == null)
                throw new ArgumentNullException();
            if(newResource.Username == null)
            {
                StringBuilder user;
                //Calcolo username
                if (newResource.LastName.Length >= 5)
                    user = new StringBuilder(newResource.LastName.Substring(0, 5) + newResource.FirstName.Substring(0, 2));
                else
                    user = new StringBuilder(newResource.LastName.Substring(0, newResource.LastName.Length) + newResource.FirstName.Substring(0, 2));
                newResource.Username = user.ToString();
                //Aggiungo la risorsa con il progressivo giusto
                for (int i = 1; ; i++) 
                {
                    var resource = ((DALManager)Context).Resources.GetByUser(user.ToString() + i.ToString());
                    if(resource == null)
                    {
                        user.Append(i.ToString());
                        newResource.Username = user.ToString();
                        ((DALManager)Context).ResourceCollection.Add(newResource);
                        ((DALManager)Context).SaveChanges();
                        return;
                    }
                }
            }
        }

        public Resource GetById(int id)
        {
            return ((DALManager)Context).ResourceCollection.Find(id);
        }

        public Resource GetByUser(string username)
        {
            return ((DALManager)Context).ResourceCollection.Where(t => t.Username == username).FirstOrDefault();
        }
    }
}
