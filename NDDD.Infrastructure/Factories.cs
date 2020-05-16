using NDDD.Domain;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
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

        public static IMaterialReceiptRepository CreateMaterialReceipt()
        {
#if DEBUG//デバッグモードのみ通る
            if (Shared.IsFake)
            {
                return new MaterialReceiptFake();
            }
#endif
            //return new MaterialSqlServer();
            return new MaterialReceiptFake();
        }

        public static IMaterialRepository CreateMaterial()
        {
#if DEBUG//デバッグモードのみ通る
            if (Shared.IsFake)
            {
                return new MaterialFake();
            }
#endif
            return new MaterialSqlServer();
            //return new MaterialFake();
        }


        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG//デバッグモードのみ通る
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif
            //return new MeasureSqlserver();
            return new MeasureFake();
        }

        public static IUserRepository CreateUser()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new UserFake();
            }
#endif
            //return new UserFake();
            return new UserSqlServer();
        }

        public static IUserRepository2 CreateUser2()
        {
            return new UserSqlServer2();
        }
    }
}
