using NDDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Entities
{
    public sealed class MaterialEntity
    {
        public MaterialEntity(string barcodeReadText,
                                      string materialCode,
                                      string materialName,
                                      float materialQuantity,
                                      string materialUnit,
                                      DateTime materialExpirationDate)
        {
            BarcodeReadText = new Barcode(barcodeReadText);
            MaterialCode = new MaterialCode(materialCode);
            MaterialName = new MaterialName(materialName);
            MaterialQuantity = new MaterialQuantity(materialQuantity);
            MaterialUnit = new MaterialUnit(materialUnit);
            MaterialExpirationDate = new MaterialExpirationDate(materialExpirationDate);//SL
        }

        public Barcode BarcodeReadText { get; }
        public MaterialCode MaterialCode { get; }
        public MaterialName MaterialName { get; }
        public MaterialQuantity MaterialQuantity { get; }
        public MaterialUnit MaterialUnit { get; }
        public MaterialExpirationDate MaterialExpirationDate { get; }

    }
}
