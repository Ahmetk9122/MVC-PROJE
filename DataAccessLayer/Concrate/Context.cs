using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class Context : DbContext
    {

        //Context Sınıfındaki About-Category vb gibi sınıfları çağırmak için entityLayer kısmını referans olarak gösterdik
        //Context Sınıfının amacı buraya yazılan Dbset türündeki propertyleri SQL e tablo olarak yansıtır
        //About bu proje içindeki sınıfın ismi 's' takısı almış olan Abouts ise SQL deki tablonun ismi.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Contact>   Contacts { get; set; }
        public DbSet<Content>   Contents  { get; set; }
        public DbSet<Heading>   Headings  { get; set; }
        public DbSet<Writer>    Writers  { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
