using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        /*
        Creat
        Read
        Update
        Delete
        */
        //Type Name();

        List<Category> List();
        void Insert(Category p);
        void Update(Category p);
        void Delete(Category p);
    }
}
