using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class UserEntity2
    {
        public UserEntity2(int userId, string userName, string userLoginPassword)
        {
            UserId = userId;
            UserName = userName;
            UserLoginPassword = userLoginPassword;
        }
        //ユーザーテーブルからとってこれるデータ
        public int UserId { get; }
        public string UserName { get; }
        public string UserLoginPassword { get; }
    }
}
