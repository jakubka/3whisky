using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whisky.Db;

namespace Whisky.Logic.Orders
{
    public interface IFeeConfiguration
    {
        decimal GetFeeForShipmentMethod(ShipmentMethod shipmentMethod);
    }
}
