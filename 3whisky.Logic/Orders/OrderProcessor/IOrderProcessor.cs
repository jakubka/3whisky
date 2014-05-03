using Whisky.Db.Entities;

namespace Whisky.Logic.Orders
{
    public interface IOrderProcessor
    {
        Order ProcessOrder(OrderData orderData);
    }
}