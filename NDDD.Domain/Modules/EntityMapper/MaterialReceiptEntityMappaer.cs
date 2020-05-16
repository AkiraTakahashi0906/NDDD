using NDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Modules.EntityMapper
{
    public static class MaterialReceiptEntityMappaer
    {
        public  static MaterialReceiptEntity Mapping(MaterialEntity materialEntity, MaterialReceiptEntity materialReceiptEntity)
        {
            return new MaterialReceiptEntity(materialEntity.MaterialManagementCode,
                                                            materialReceiptEntity.MaterialReceiptDate,
                                                            Convert.ToString(materialReceiptEntity.MaterialDeliveryPlace.Value));
        }
    }
}
