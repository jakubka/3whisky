using System.Linq;

using Whisky.Db.Entities;

namespace Whisky.Db
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(IDbConfiguration configuration)
        {
            _context = new Context(configuration);
        }
                
        
        public IQueryable<Order> Orders
        {
            get
            {
                return _context.Orders;
            }
        }


        public IQueryable<Product> Products
        {
            get
            {
                return _context.Products;
            }
        }


        public void CreateOrder(Order order)
        {
            _context.Products.Attach(order.Product);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
