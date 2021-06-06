using BusinessLayer.Abstracy;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ImageFileManager : IimageFileService
    {
        IimageFileDal _imagefileDal;

        public ImageFileManager(IimageFileDal imagefileDal)
        {
            _imagefileDal = imagefileDal;
        }

        public List<imageFile> GetList()
        {
           return  _imagefileDal.List();
        }
    }
}
