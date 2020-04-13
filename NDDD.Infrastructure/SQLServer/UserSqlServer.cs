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
    //internalにしてファクトリークラスからしかNEWできないようにする。
    internal sealed class UserSqlServer : IUserRepository
    {
        public UserEntity GetUserData(int userId)
        {

            string sql = @"
select UserID,
    UserName,
from UserTable
where UserID = @UserID
order by UserID
LIMIT 1
";
            UserEntity user = null;
            SqlServerHelper.Query(
                sql,
                new List<SqlParameter> { new SqlParameter("@UserID", userId) }.ToArray(),
                                    reader =>
                                    {
                                    user = new UserEntity(Convert.ToInt32(reader["UserID"]),
                                                            Convert.ToString(reader["UserName"]),
                                                            Convert.ToString(reader["Password"]));
                                    });
            return user;
        }
    }
}
