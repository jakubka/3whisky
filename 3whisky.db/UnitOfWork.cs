using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3whisky.db.Entities;

namespace _3whisky.db
{
    public class UnitOfWork
    {
        private readonly Context _context = new Context();
        
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
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
