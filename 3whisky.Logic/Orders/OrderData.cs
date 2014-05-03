using Whisky.Db;
using Whisky.Db.Entities;

namespace Whisky.Logic.Orders
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


        public PaymentMethod PaymentMethod
        {
            get;
            set;
        }


        public ShipmentMethod ShipmentMethod
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
}