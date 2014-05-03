using System;

using Whisky.Db;
using Whisky.Db.Entities;
using Whisky.Logic.Emails;

namespace Whisky.Logic.Orders
{
    internal class OrderProcessor : IOrderProcessor
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailSender _emailSender;
        private readonly IEmailGenerator _emailGenerator;
        private readonly ITotalPriceCalculator _totalPriceCalculator;


        public OrderProcessor(IUnitOfWork unitOfWork, IEmailSender emailSender, IEmailGenerator emailGenerator, ITotalPriceCalculator totalPriceCalculator)
        {
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
            _emailGenerator = emailGenerator;
            _totalPriceCalculator = totalPriceCalculator;
        }

        public Order ProcessOrder(OrderData orderData)
        {
            decimal totalPrice = _totalPriceCalculator.CalculateTotalPrice(orderData.Product.Price, orderData.ShipmentMethod, orderData.PaymentMethod);
            
            DateTime now = DateTime.Now;
            string orderNumber = "" + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond;

            var order = new Order()
            {
                UniqueNumber = orderNumber,
                Name = orderData.Name,
                Email = orderData.Email,
                DeliveryAddress = orderData.DeliveryAddress,
                ShipmentMethod = orderData.ShipmentMethod,
                PaymentMethod = orderData.PaymentMethod,
                Note = orderData.Note,
                TotalPrice = totalPrice,
                Product = orderData.Product,
                Created = DateTime.Now,
            };

            _unitOfWork.CreateOrder(order);

            SendEmailToCustomer(order);
            SendEmailToAdmin(order);

            return order;
        }

        private void SendEmailToCustomer(Order order)
        {
            var email = _emailGenerator.GenerateCustomerOrderConfirmation(order);

            _emailSender.SendEmail(email);
        }

        private void SendEmailToAdmin(Order order)
        {
            var email = _emailGenerator.GenerateAdminOrderNotification(order);

            _emailSender.SendEmail(email);
        }
    }
}
