﻿using System.ComponentModel.DataAnnotations;

using Whisky.Db;

namespace Whisky.Web.Models
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


        public int ProductId
        {
            get;
            set;
        }
    }
}