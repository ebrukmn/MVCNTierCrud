using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.RepositoryInterface
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetByID(int id);
        List<T> SelectAll();
        bool Any(Expression<Func<T, bool>> exp);
    }
}
