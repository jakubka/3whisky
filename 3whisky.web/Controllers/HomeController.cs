using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ninject;
using _3whisky.db;

namespace _3whisky.web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Index/
        public ActionResult Index()
        {
            var unitOfWork = MainKernel.Kernel.Get<IUnitOfWork>();

            return View(unitOfWork.Products.Count());
        }


        public ActionResult Detail()
        {
            return View();
        }
	}
}