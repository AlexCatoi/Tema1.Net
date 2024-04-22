using Tema1.Database.Entities;
using Tema1.Database.Dtos.Common;
using Tema1.Database.Dtos.Request;
using Tema1.Database.Enums;

namespace Tema1.Database.QueryExtensions
{
    public static class OrdersQueryExtensions
    {
        public static IQueryable<Order> WhereStatus(this IQueryable<Order> query, GetOrderRequest payload)
        {
            if (payload.Status == null)
                return query;

            query = query.Where(e => e.Status == payload.Status);

            return query;
        }


        public static IQueryable<Order> WhereAssignedUserIds(this IQueryable<Order> query, GetOrderRequest payload)
        {
            if (payload.AssignedCustomerIds == null)
                return query;

            query = query.Where(e => payload.AssignedCustomerIds==e.CustomerId);

            return query;
        }
    }
}
