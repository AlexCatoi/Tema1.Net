using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Enums;

namespace Tema1.Database.Dtos.Request
{
    public class GetOrderRequest
    {
        public int? AssignedCustomerIds { get; set; }
        public OrderStatuses? Status { get; set; }
    }
}
