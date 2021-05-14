
using BusinessLayer.Concrete;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.EntityFramework;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MVC_PROJE.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfContentDal());
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //var diyoruz çünkü tabloda alfabetik karakter sayı ve değişik karakterler işçerebilir oyüzden bunu kullanıyoruz.
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //  cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator();

            //Hata Mesajı validation kullanımı.
            ValidationResult results = categoryValidator.Validate(p);

            if (results.IsValid)
            {
                //cm EfCategoryDal a göre türetrmiş olduğumuz categorymanager sınıfındaki nesne.
                cm.CategoryAddBL(p);
                return RedirectToAction("GetCategoryList");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

    }
}