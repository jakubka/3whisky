using System;

namespace Whisky.Logic.Orders
{
    public interface IShipmentDateCalculator
    {
        DateTime CalculateShipmentDate(DateTime paymentReceived);
    }
}
