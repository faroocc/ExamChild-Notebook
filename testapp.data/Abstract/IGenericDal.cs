using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace testapp.data.Abstract
{
    public interface IGenericDal<T>
    {
         void Insert(T t);
         void Delete(T t);
         void Update(T t);
         List<T> GetList();
         T GetByID(int id);
         List<T> GetByFilter(Expression<Func<T,bool>> filter);
        
    }
}