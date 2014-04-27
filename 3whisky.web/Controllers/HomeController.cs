using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ninject;
using _3whisky.db;
using _3whisky.web.Models;
using _3whisky.db.Entities;

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

        public ActionResult OrderConfirmation(int orderId)
        {
            var unitOfWork = MainKernel.Kernel.Get<IUnitOfWork>();
            var order = unitOfWork.Orders.SingleOrDefault(o => o.Id == orderId);
            
            return View(order);
        }

        [HttpPost]
        public ActionResult CreateOrder(CreateOrderModel createOrderModel)
        {
            var unitOfWork = MainKernel.Kernel.Get<IUnitOfWork>();
            var product = unitOfWork.Products.SingleOrDefault(p => p.Enabled && p.Active && p.Id == createOrderModel.ProductId);

            if (product != null && ModelState.IsValid)
            {
                var order = new Order()
                {
                    Name = createOrderModel.Name,
                    Email = createOrderModel.Email,
                    DeliveryAddress = createOrderModel.DeliveryAddress,
                    ShipmentMethod = createOrderModel.ShipmentMethod,
                    PaymentMethod = createOrderModel.PaymentMethod,
                    Note = createOrderModel.Note,
                    TotalPrice = product.Price,
                    Product = product,
                };

                unitOfWork.CreateOrder(order);

                return RedirectToAction("OrderConfirmation", new { orderId = order.Id });
            }

            return RedirectToAction("Detail", new { id = createOrderModel.ProductId });
        }
	}
}