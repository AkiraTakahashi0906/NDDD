using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake
{
    public class UserFake : IUserRepository
    {
        public UserEntity GetUserData()
        {
            return  new UserEntity(
                        1,
                        "高橋彬",
                        "043527"
                        );
        }
    }
}
