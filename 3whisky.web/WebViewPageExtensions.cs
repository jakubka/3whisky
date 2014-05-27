using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Whisky.Db;
using Whisky.Logic.Orders;

using Ninject;
using System.Web.Mvc;

namespace Whisky.Web
{
    public static class ShipmentFeeRetriever
    {
        public static decimal GetShipmentFee(ShipmentMethod shipmentMethod)
        {
            var configuration = MainKernel.Kernel.Get<IFeeConfiguration>();

            return configuration.GetFeeForShipmentMethod(shipmentMethod);
        }
    }
}