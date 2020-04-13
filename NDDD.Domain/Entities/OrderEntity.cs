using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class OrderEntity
    {
        public OrderEntity(int v, DateTime dateTime)
        {
        }

        public List<OrderItemEntity> OrderItems { get; set; }
        public SqlDbType OrderDate { get; set; }
    }
}
