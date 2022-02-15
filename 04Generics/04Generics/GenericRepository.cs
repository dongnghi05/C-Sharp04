using System;
using System.Collections.Generic;

namespace Generics
{
    public class GenericRepository : IRepository<Entity>
    {
        List<Entity> lst = new List<Entity>();
        public void Add(Entity item)
        {
            lst.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return lst;
        }

        public Entity GetById(int id)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if(lst[i].id == id)
                {
                    return lst[i];
                }
            }
            return null;
        }

        public void Remove(Entity item)
        {
            lst.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
