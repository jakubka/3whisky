using Whisky.Db;

namespace Whisky.Logic.Orders
{
    internal class TotalPriceCalculator : ITotalPriceCalculator
    {
        private IFeeConfiguration _feeConfiguration;

        public TotalPriceCalculator(IFeeConfiguration feeConfiguration)
        {
            _feeConfiguration = feeConfiguration;
        }

        public decimal CalculateTotalPrice(decimal productsPrice, ShipmentMethod shipmentMethod, PaymentMethod paymentMethod)
        {
            return productsPrice + _feeConfiguration.GetFeeForShipmentMethod(shipmentMethod);
        }
    }
}