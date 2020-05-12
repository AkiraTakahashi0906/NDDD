using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDDD.Domain.ValueObjects;

namespace NDDD.Domain.Entities
{
    public sealed  class MaterialReceiptEntity
    {
        public MaterialReceiptEntity(MaterialManagementCode materialManagementCode,
                                                       DateTime materialReceiptDate,
                                                       string materialDeliveryPlace)
        {
            MaterialManagementCode = materialManagementCode;
            MaterialReceiptDate = materialReceiptDate;
            MaterialDeliveryPlace = new MaterialDeliveryPlace(materialDeliveryPlace);
        }

        public MaterialManagementCode MaterialManagementCode { get; }
        public DateTime MaterialReceiptDate { get; }
        public MaterialDeliveryPlace MaterialDeliveryPlace { get; }

    }
}
