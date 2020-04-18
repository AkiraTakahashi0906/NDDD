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
        private string _readText;
        public string Value { get; } = string.Empty;
        public BarcodeType ValueType { get; } = 0;

        public BarcodeReader(string readtext)
        {
            _readText = readtext;
            ValueType = CheckValueType(_readText);
            Value = GetValue(_readText, ValueType);
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
