using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDDD.Domain.Modules.Barcode;
using static NDDD.Domain.Modules.Barcode.BarcodeReader;

namespace NDDDTest.Tests.classTests
{
    [TestClass]
    public class BarcodeReaderClassTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var scanText = "454564564";
            var reader = new BarcodeReader(scanText);

            reader.Value.Is("ErrorItem");
            reader.ValueType.Is(BarcodeType.ErrorItem);

            scanText = "1234567890";
            var reader2 = new BarcodeReader(scanText);

            reader2.Value.Is("ErrorItem");
            reader2.ValueType.Is(BarcodeType.MadeByCompanyItem);

        }
    }
}
