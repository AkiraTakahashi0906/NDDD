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
    internal sealed class UserSqlServer2 : IUserRepository2
    {
        public IReadOnlyList<UserEntity2> GetUser()
        {

            string sql = @"
select Top 2 UserID,
    UserName,
    Password
from UserTable
order by UserID
";

            //where UserID = @UserID
            var userList = new List<UserEntity2>();
            SqlServerHelper.Query(
                sql,
                null,//new List<SqlParameter> { new SqlParameter("@UserID", "userId") }.ToArray(),
                                    reader =>
                                    {
                                        //while (reader.Read() == true)
                                        //{
                                            userList.Add(new UserEntity2(Convert.ToInt32(reader["UserID"]),
                                            Convert.ToString(reader["UserName"]),
                                            Convert.ToString(reader["Password"])));
                                        //}

                                    });
            return userList.AsReadOnly();
        }

    }
}
