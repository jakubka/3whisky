using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3whisky.db.Entities
{
    public class Order
    {
        public int Id
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


        public decimal TotalPrice
        {
            get;
            set;
        }
    }
}
