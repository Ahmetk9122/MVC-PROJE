using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracy
{
    public interface IimageFileService
    {
        List<imageFile> GetList();
    }
}
