using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake
{
    class MaterialDeliveryFake : IMaterialReceiptRepository
    {
        public void DeliveryRecordSave(MaterialReceiptEntity material)
        {
            throw new NotImplementedException();
        }
    }
}
