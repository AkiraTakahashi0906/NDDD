using NDDD.Domain;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.Fake;
using NDDD.Infrastructure.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure
{
    public static class Factories
    {
        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG//デバッグモードのみ通る
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif
            return new MeasureSqlserver();
        }

        public static IUserRepository CreateUser()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new UserFake();
            }
#endif
            return new UserFake();
            //return new UserSqlServer();
        }
    }
}
