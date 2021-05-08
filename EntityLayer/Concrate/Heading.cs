using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }

        //Burada bağlayacağımız property ismini ilişkilendireceğimiz tablonun anahtar sütunu ile aynı ismi veriyoruz
        public int CategoryID { get; set; }

        //virtual anahtar kelimesi bir sınıftan değer alınacağını belirtir yani kategori kısmından bir değer aldığımızı göstermiş oluyoruz.
        public virtual Category Category { get; set; }

        //Content kısmı ile heading kısmıonı bağlıyoruz 
        //Burada content head kısmını kullanacağı için  ICollection kısmı head Virual kısmı category olacak.
       //----------------------------------------------------------------------------------------------------

        //Writer ile başlık kısmını bağlama.
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


        public ICollection<Content> Contents { get; set; }

    }
}
