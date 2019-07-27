using Project.BLL.RepositoryPattern.RepositoryInterface;
using Project.DAL.Context;
using Project.DAL.SingletonPattern;
using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.RepositoryBase
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext db;
        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public void Delete(T item)
        {
            db.Set<T>().Remove(item);
            Save();
        }

        public T GetByID(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> SelectAll()
        {
            return db.Set<T>().ToList();
        }

        public void Update(T item)
        {
            T tobeUpdated = GetByID(item.ID);
            db.Entry(tobeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }
    }
}
