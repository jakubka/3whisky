using Whisky.Db;

namespace Whisky.Logic.Orders
{
    public interface ITotalPriceCalculator
    {
        decimal CalculateTotalPrice(decimal productsPrice, ShipmentMethod shipmentMethod, PaymentMethod paymentMethod);
    }
}
