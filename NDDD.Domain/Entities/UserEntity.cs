using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class UserEntity
    {
        public UserEntity()
        {

        }
        //ユーザーテーブルからとってこれるデータ
        public int UserId { get; }
        public string UserName { get; }
        public int UserLoginPassword { get; }
    }
}
