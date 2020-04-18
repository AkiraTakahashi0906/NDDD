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
        }
    }
}
