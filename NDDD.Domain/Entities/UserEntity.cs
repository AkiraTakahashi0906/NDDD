using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DBの値を運ぶ形でEntityにする
namespace NDDD.Domain.Entities
{
    public sealed class UserEntity
    {
        //Newするときにコンストラクタで必ず値が入る。完全コンストラクタパターン
        public UserEntity(int userId,string userName, string userLoginPassword)
        {
            UserId = new UserId(userId);
            UserName =new UserName(userName);
            UserLoginPassword = new Password(userLoginPassword);
        }
        //ユーザーテーブルからとってこれるデータ
        public UserId UserId { get; }
        public UserName UserName { get; }
        public Password UserLoginPassword { get; }
    }
}
