using System;

namespace Whisky.Logic.Orders
{
    internal class HardcodedShipmentDateCalculator : IShipmentDateCalculator
    {
        public DateTime CalculateShipmentDate(DateTime paymentReceived)
        {
            // doesn't take holidays into account
            return AddBusinessDays(paymentReceived, 3);
        }


        private DateTime AddBusinessDays(DateTime current, int days)
        {
            var sign = Math.Sign(days);
            var unsignedDays = Math.Abs(days);
            for (var i = 0; i < unsignedDays; i++)
            {
                do
                {
                    current = current.AddDays(sign);
                } while (current.DayOfWeek == DayOfWeek.Saturday ||
                         current.DayOfWeek == DayOfWeek.Sunday);
            }
            return current;
        }
    }
}