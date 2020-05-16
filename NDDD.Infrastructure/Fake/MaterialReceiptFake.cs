using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake
{
    class MaterialReceiptFake : IMaterialReceiptRepository
    {
        public void DeliveryRecordSave(MaterialReceiptEntity material)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<MaterialReceiptEntity> GetData()
        {
            var entities = new List<MaterialReceiptEntity>();

            entities.Add(new MaterialReceiptEntity(
                        new MaterialManagementCode("FAKEAAAA"),
                        Convert.ToDateTime("2012/12/12 12:34:56"),
                        "BOX-1234"
                        ));

            entities.Add(new MaterialReceiptEntity(
                        new MaterialManagementCode("FAKEBBBB"),
                        Convert.ToDateTime("2012/12/13 12:34:56"),
                        "BOX-4567"
                        ));

            entities.Add(new MaterialReceiptEntity(
                        new MaterialManagementCode("FAKECCCC"),
                        Convert.ToDateTime("2012/12/14 12:34:56"),
                        "BOX-5689"
                        ));

            return entities;
        }
    }
}
