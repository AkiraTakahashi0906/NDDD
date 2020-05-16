using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Exceptios;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.WinForm.ViewModels;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class MaterialStoringViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var entity = new MaterialEntity(
                                    "AAAA2",
                                    "05005050505044",
                                    "1775B2",
                                    1.5f,
                                    "EA",
                                    Convert.ToDateTime("2012/12/12 12:34:56")
                                    );

            var readBarcode = new Barcode("AAAA");
            var MaterialMock = new Mock<IMaterialRepository>();
            var MaterialReceiptMock = new Mock<IMaterialReceiptRepository>();

            MaterialMock.Setup(x => x.GetMaterial(readBarcode)).Returns(entity);

            var viewModelMock = new Mock<MaterialStoringViewModel>(MaterialMock.Object, MaterialReceiptMock.Object);

            var viewModel = viewModelMock.Object;
            viewModel.BarcodeReadText = "";

            var ex = AssertEx.Throws<InputException>(() => viewModel.MaterialSearch());
            ex.Message.Is("材料バーコード空白エラー");
            viewModel.BarcodeReadText = "AAAA";

            ex = AssertEx.Throws<InputException>(() => viewModel.DeliveryRecordSave());
            ex.Message.Is("配送先バーコード空白エラー"); //材料データが見つかりません。

            viewModel.DeliveryRecordText = "BOX-12345";

            ex = AssertEx.Throws<InputException>(() => viewModel.DeliveryRecordSave());
            ex.Message.Is("材料データが見つかりません。"); 

            viewModel.MaterialSearch();
            viewModel.BarcodeReadText.Is("AAAA");
            viewModel.MaterialCodeText.Is("MC:[05005050505044]");
            viewModel.MaterialNameText.Is("名称:[1775B2]");

            MaterialReceiptMock.Setup(x => x.DeliveryRecordSave(It.IsAny<MaterialReceiptEntity>())).
                Callback<MaterialReceiptEntity>(saveValue =>
                {
                    saveValue.MaterialManagementCode.Value.Is("AAAA2");
                    //saveValue.MaterialReceiptDate.Is(Convert.ToDateTime("2018/01/01 12:34:56"));
                    saveValue.MaterialDeliveryPlace.Value.Is("BOX-12345");
                });

            viewModel.DeliveryRecordSave();

            MaterialMock.VerifyAll();
        }
    }
}
