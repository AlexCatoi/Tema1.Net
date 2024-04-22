
using Tema1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Context;
using Tema1.Database.Dtos.Request;
using Tema1.Database.QueryExtensions;
using Microsoft.EntityFrameworkCore;
namespace Tema1.Database.Repositories
{
    public class OrdersRepository : BaseRepository
    {
        public OrdersRepository(Tema1DBContext temaDbContext) : base(temaDbContext)
        {
        }

        public void Add(Order order)
        {
            labProjectDbContext.Orders.Add(order);
            labProjectDbContext.SaveChanges();
        }
        private IQueryable<Order> GetOrdersQuery(GetOrderRequest payload)
        {
            var query = labProjectDbContext.Orders

                .Where(e => e.DateDeleted == null)
                .WhereStatus(payload);

            return query;

        }
        public List<Order> GetOrders(GetOrderRequest payload)
        {
            var results = GetOrdersQuery(payload)
                .AsNoTracking()
                .ToList();

            return results;
        }
        public int CountOrders(GetOrderRequest payload)
        {
            var count = GetOrdersQuery(payload)
                .Count();

            return count;
        }
    }
}
