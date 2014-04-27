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

            var products = unitOfWork.Products.Where(p => p.Enabled && p.Active).ToList();

            return View(products);
        }


        public ActionResult Detail(int id)
        {
            var unitOfWork = MainKernel.Kernel.Get<IUnitOfWork>();

            var product = unitOfWork.Products.SingleOrDefault(p => p.Enabled && p.Active && p.Id == id);

            if (product == null)
            {
                return Redirect("/404"); // TODO
            }

            return View(product);
        }
	}
}