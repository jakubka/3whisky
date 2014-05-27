using System.Linq;
using System.Web.Mvc;

using Ninject;

using Whisky.Db;
using Whisky.Logic.Orders;
using Whisky.Web.Models;

namespace Whisky.Web.Controllers
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


        public ActionResult TermsAndConditions()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateOrder(CreateOrderModel createOrderModel)
        {
            var unitOfWork = MainKernel.Kernel.Get<IUnitOfWork>();
            var product = unitOfWork.Products.SingleOrDefault(p => p.Enabled && p.Active && p.Id == createOrderModel.ProductId);

            if (product != null && ModelState.IsValid)
            {
                var orderProcessor = MainKernel.Kernel.Get<IOrderProcessor>();

                var orderData = new OrderData()
                {
                    Email = createOrderModel.Email,
                    Name = createOrderModel.Name,
                    DeliveryAddress = createOrderModel.DeliveryAddress,
                    Note = createOrderModel.Note,
                    PaymentMethod = createOrderModel.PaymentMethod,
                    ShipmentMethod = createOrderModel.ShipmentMethod,
                    Product = product,
                };

                var createdOrder = orderProcessor.ProcessOrder(orderData);

                return RedirectToAction("OrderConfirmation", new { orderId = createdOrder.Id });
            }

            return RedirectToAction("Detail", new { id = createOrderModel.ProductId });
        }


        public ActionResult Contact()
        {
            return View("Contact");
        }
    }
}