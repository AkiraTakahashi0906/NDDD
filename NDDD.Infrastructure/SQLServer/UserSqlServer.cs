using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.SQLServer
{
    //internalにしてファクトリークラスからしかNEWできないようにする。
//    internal sealed class UserSqlServer : IUserRepository
//    {
//        public UserEntity GetUserData(int userId)
//        {

//            string sql = @"
//select UserID,
//    UserName,
//    PassWord
//from UserTable
//where UserID = @UserID
//order by UserID
//LIMIT 1
//";
//            return SqlServerHelper.Query();

//        }
//    }
}
