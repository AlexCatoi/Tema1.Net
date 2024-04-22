using Tema1.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Enums;

namespace Tema1.Database.Entities
{
    public class Order :BaseEntity

    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatuses Status { get; set; }

        public Customer Customer { get; set; }
    }
}
