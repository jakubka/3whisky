using System;

namespace Whisky.Db.Entities
{
    public class Order
    {
        public int Id
        {
            get;
            set;
        }


        public string UniqueNumber
        {
            get;
            set;
        }


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


        public decimal TotalPrice
        {
            get;
            set;
        }


        public DateTime Created
        {
            get;
            set;
        }
    }
}
