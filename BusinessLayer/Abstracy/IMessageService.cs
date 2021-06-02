using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracy
{
    public interface IMessageService
    {
        List<Message> GetList();
        void MessageAdd(Message message);
        Message GetByID(int id);

        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}
