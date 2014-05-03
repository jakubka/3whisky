using Whisky.Db;

namespace Whisky.Logic.Orders
{
    internal class TotalPriceCalculator : ITotalPriceCalculator
    {
        public decimal CalculateTotalPrice(decimal productsPrice, ShipmentMethod shipmentMethod, PaymentMethod paymentMethod)
        {
            decimal totalPrice = productsPrice;

            if (shipmentMethod == ShipmentMethod.CeskaPosta)
            {
                totalPrice += 90;
            }

            return totalPrice;
        }
    }
}