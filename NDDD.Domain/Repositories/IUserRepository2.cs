﻿using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Repositories
{
    public interface IUserRepository2
    {
        IReadOnlyList<UserEntity2> GetUser();
    }
}
