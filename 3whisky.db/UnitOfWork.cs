using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3whisky.db.Entities;
using _3whisky.configuration;

namespace _3whisky.db
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
