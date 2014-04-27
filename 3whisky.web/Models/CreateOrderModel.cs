using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3whisky.web.Models
{
    public class CreateOrderModel
    {
        [Required]
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }

        [Required]
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


        [DataType(DataType.MultilineText)]
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


        public int ProductId
        {
            get;
            set;
        }
    }
}