using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1.Database.Dtos.Common;

namespace Tema1.Database.Dtos.Response
{
    public class GetOrderResponse
    {
        public List<ShortOrderDto> Orders { get; set; }
        public int Count { get; set; }
    }
}
