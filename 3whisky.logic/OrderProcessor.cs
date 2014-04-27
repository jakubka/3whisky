using _3whisky.db;
using _3whisky.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3whisky.logic
{
    public class OrderData
    {
        public string Email
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string DeliveryAddress
        {
            get;
            set;
        }


        public string Note
        {
            get;
            set;
        }


        public string PaymentMethod
        {
            get;
            set;
        }


        public string ShipmentMethod
        {
            get;
            set;
        }


        public Product Product
        {
            get;
            set;
        }
    }

    public interface IOrderProcessor
    {
        Order ProcessOrder(OrderData orderData);
    }

    internal class OrderProcessor : IOrderProcessor
    {
        private IUnitOfWork _unitOfWork;
        private IEmailSender _emailSender;

        public OrderProcessor(IUnitOfWork unitOfWork, IEmailSender emailSender)
        {
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
        }

        public Order ProcessOrder(OrderData orderData)
        {
            decimal totalPrice = orderData.Product.Price;

            if (orderData.ShipmentMethod == "ceskaposta")
            {
                totalPrice += 90;
            }

            var order = new Order()
            {
                Name = orderData.Name,
                Email = orderData.Email,
                DeliveryAddress = orderData.DeliveryAddress,
                ShipmentMethod = orderData.ShipmentMethod,
                PaymentMethod = orderData.PaymentMethod,
                Note = orderData.Note,
                TotalPrice = totalPrice,
                Product = orderData.Product,
            };

            _unitOfWork.CreateOrder(order);

            SendEmailToCustomer(order);
            SendEmailToAdmin(order);

            return order;
        }

        private void SendEmailToCustomer(Order order)
        {
            _emailSender.SendEmail(order.Email, "Potvrzeni objednavy na eshopu 3whisky", "Objednal jste " + order.Product.Name + " za " + order.TotalPrice + " Kc");
        }

        private void SendEmailToAdmin(Order order)
        {
            string text = @"<h1>Nova objednavka cislo " + order.Id + "</h1>"
                + "Zakaznik: " + order.Name + ", " + order.Email + "<br />"
                + "Produkt: " + order.Product.Name + " za " + order.TotalPrice + "<br />"
                + "Detaily: " + order.ShipmentMethod + ", " + order.PaymentMethod + ", " + order.DeliveryAddress + ", " + order.Note;

            var recipients = new List<string>()
            {
                "jakub.kadlubiec@gmail.com",
                "janv@kentico.com",
                "romanm@kentico.com",
            };

            _emailSender.SendEmail(recipients, "Nova objednavka!!!!!!", text);
        }
    }
}
