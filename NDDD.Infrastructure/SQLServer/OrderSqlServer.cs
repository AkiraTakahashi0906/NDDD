using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.SQLServer
{
    internal sealed class OrderSqlServer : IOderRepository
    {
        public OrderEntity GetData(int orderId)
        {
            string sql = @"
select A.OrderId,
       A.OrderDate,
   B.OrderItemId,
   B.ProductId,
   isnull(C.ProductName,'') ProductName,
   isnull(C.Price,0) Price
from Orders A
inner join OrderItems B
on A.OrderId = B.OrderId
left outer join Products C
on B.ProductId = C.ProductId
where A.OrderId = @OrderId";

            OrderEntity order = null;
            SqlServerHelper.Query(
                    sql,
                    new List<SqlParameter> { new SqlParameter("@OrderId", orderId) }.ToArray(),
                    reader =>
                    {
                        if (order == null)
                        {
                            order = new OrderEntity(Convert.ToInt32(reader["OrderId"]),
                                                    Convert.ToDateTime(reader["OrderDate"]));
                        }
                        order.OrderItems.Add(new OrderItemEntity(
                            Convert.ToInt32(reader["OrderId"]),
                            Convert.ToInt32(reader["OrderItemId"]),
                            Convert.ToInt32(reader["ProductId"]),
                            Convert.ToString(reader["ProductName"]),
                            Convert.ToInt32(reader["Price"])));
                    });
            return order;
        }

        public int Save(OrderEntity entity)
        {
            string sql = @"
insert into Orders
(OrderDate)
values
(@OrderDate)";

            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@OrderDate", entity.OrderDate));
            SqlServerHelper.Execute(sql, parameters.ToArray());

            int lastId = -1;
            SqlServerHelper.Query("SELECT IDENT_CURRENT('Orders') AS LASTID",
                null,
                reader =>
                {
                    lastId = Convert.ToInt32(reader["LASTID"]);
                });

            foreach (var orderItem in entity.OrderItems)
            {
                sql = @"
insert into OrderItems
(OrderId,OrderItemId,ProductId)
values
(@OrderId,@OrderItemId,@ProductId)";

                parameters.Clear();
                parameters.Add(new SqlParameter("@OrderId", lastId));
                //parameters.Add(new SqlParameter("@OrderItemId", orderItem.OrderItemId.Value));
                //parameters.Add(new SqlParameter("@ProductId", orderItem.ProductId.Value));
                SqlServerHelper.Execute(sql, parameters.ToArray());

            }
            return lastId;
        }
    }
}


