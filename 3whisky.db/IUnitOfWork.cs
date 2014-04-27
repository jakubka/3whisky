using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _3whisky.db.Entities;
using _3whisky.configuration;

namespace _3whisky.db
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
