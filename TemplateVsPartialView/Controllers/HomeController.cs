using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateVsPartialView.Controllers
{
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var parentModel = new Parent();
            parentModel.ParentName = "My Parent Name";
            parentModel.SingleChild = new Child {ChildName = "The Child Name"};

            return View(parentModel);
        }

    }
}