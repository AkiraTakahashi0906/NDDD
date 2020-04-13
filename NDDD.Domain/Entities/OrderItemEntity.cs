using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class OrderItemEntity
    {
        public OrderItemEntity(int v1, int v2, int v3, string v4, int v5)
        {
        }

        public object OrderItemId { get; set; }
        public object ProductId { get; set; }
    }
}
