using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IUser
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
