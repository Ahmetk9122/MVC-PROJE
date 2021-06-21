using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJE.Controllers
{
    public class WriterPanelMessageController : Controller
    {

        MessageManager cm = new MessageManager(new EFMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        // GET: WriterPanelMessage
        public ActionResult Inbox()
        {
            var messagelist = cm.GetListInbox();
            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var messagelist = cm.GetListSendbox();
            return View(messagelist);
        }
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }

    }
}