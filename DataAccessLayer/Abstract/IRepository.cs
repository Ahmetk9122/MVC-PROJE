using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD
        /*
        Creat
        Read
        Update
        Delete
        */
        //Type Name();

        List<T> List();
        void Insert(T p);

        //Komple getirir
        T Get(Expression<Func<T, bool>> filter);
        void Update(T p);
        void Delete(T p);

        //Şartlı listeleme yapacak olan kısım 
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
