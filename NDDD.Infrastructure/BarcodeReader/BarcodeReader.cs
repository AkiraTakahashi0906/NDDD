using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Modules.Barcode
{
    public sealed class BarcodeReader
    {
        public enum BarcodeType
        {
            ErrorItem,
            MadeByCompanyItem,
            ProvidedByCompanyItem,
            ProvidedBySelfDefenseForceItem
        }
        public string Value { get; } = string.Empty;
        public string ReadText { get; } = string.Empty;
        public BarcodeType ValueType { get; } = BarcodeType.ErrorItem;

        public BarcodeReader(string readtext)
        {
            ReadText = readtext;
            ValueType = CheckValueType(ReadText);
            Value = GetValue(ReadText, ValueType);
        }

        private BarcodeType CheckValueType(string readText)
        {
            switch (readText.Length)
            {
                case 0:
                    return BarcodeType.ErrorItem;

                case 10:
                    return BarcodeType.MadeByCompanyItem;

                case 11:
                    return BarcodeType.MadeByCompanyItem;

                case 12:
                    return BarcodeType.MadeByCompanyItem;

                default:
                    return BarcodeType.ErrorItem;
            }
        }

        private string GetValue(string readText, BarcodeType valueType)
        {
            switch (valueType)
            {
                case BarcodeType.ErrorItem:
                    return "ErrorItem";

                case BarcodeType.MadeByCompanyItem:
                    return "ErrorItem";

                case BarcodeType.ProvidedByCompanyItem:
                    return "ErrorItem";

                case BarcodeType.ProvidedBySelfDefenseForceItem:
                    return "ErrorItem";

                default:
                    return "ErrorItem";
            }

        }

    }
}
