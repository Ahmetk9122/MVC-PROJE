﻿using BusinessLayer.Abstracy;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingMenager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingMenager()
        {
        }

        public HeadingMenager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
           return _headingDal.List();
        }

        public List<Heading> GetListByWriter()
        {

            return _headingDal.List(x => x.WriterID == 4);
        }

        public void HeadingAdd(Heading heading)
        {
                  _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
