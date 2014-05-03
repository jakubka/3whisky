using System.Linq;

using Whisky.Db.Entities;

namespace Whisky.Db
{
    public interface IUnitOfWork
    {
        IQueryable<Order> Orders
        {
            get;
        }


        IQueryable<Product> Products
        {
            get;
        }


        void CreateOrder(Order order);
    }
}
