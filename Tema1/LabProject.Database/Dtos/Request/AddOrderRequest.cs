using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Entities;
using Tema1.Database.Enums;

namespace Tema1.Database.Dtos.Request
{
    public class AddOrderRequest
    {
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatuses Status { get; set; }
    }
}
