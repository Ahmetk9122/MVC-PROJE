﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracy
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter(int id);
        void HeadingAdd(Heading heading);
        Heading GetByID(int id);

        void HeadingDelete(Heading heading);

        void HeadingUpdate(Heading heading);
    }
}
