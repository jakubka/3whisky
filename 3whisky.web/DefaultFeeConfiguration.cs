using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Whisky.Db;
using Whisky.Logic.Orders;

namespace Whisky.Web
{
    public class DefaultFeeConfiguration : IFeeConfiguration
    {
        public decimal GetFeeForShipmentMethod(ShipmentMethod shipmentMethod)
        {
            switch (shipmentMethod)
            {
                case ShipmentMethod.CeskaPosta:
                    return 90;
                case ShipmentMethod.Osobni:
                    return 0;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}