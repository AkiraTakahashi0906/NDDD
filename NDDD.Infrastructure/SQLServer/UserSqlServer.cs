using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.SQLServer
{
    //internalにしてファクトリークラスからしかNEWできないようにする。
    internal sealed class UserSqlServer : IUserRepository
    {
        public UserEntity GetUserData()
        {
            throw new NotImplementedException();
        }
    }
}
