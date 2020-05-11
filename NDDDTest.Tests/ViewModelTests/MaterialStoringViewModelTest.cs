﻿using System;
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
                                    "AAAA",
                                    "05005050505044",
                                    "1775B2",
                                    1.5f,
                                    "EA",
                                    Convert.ToDateTime("2012/12/12 12:34:56")
                                    );

            var readBarcode = new Barcode("AAAA");
            var MaterialMock = new Mock<IMaterialRepository>();

            MaterialMock.Setup(x => x.GetMaterial(readBarcode)).Returns(entity);

            var viewModelMock = new Mock<MaterialStoringViewModel>(MaterialMock.Object);

            var viewModel = viewModelMock.Object;
            viewModel.BarcodeReadText = "";

            var ex = AssertEx.Throws<InputException>(() => viewModel.MaterialSearch());
            ex.Message.Is("材料バーコード空白エラー");
            viewModel.BarcodeReadText = "AAAA";

            ex = AssertEx.Throws<InputException>(() => viewModel.DeliveryRecordSave());
            ex.Message.Is("配送先バーコード空白エラー"); //材料データが見つかりません。

            viewModel.DeliveryRecordText = "BOX-1234";

            ex = AssertEx.Throws<InputException>(() => viewModel.DeliveryRecordSave());
            ex.Message.Is("材料データが見つかりません。"); 

            viewModel.MaterialSearch();
            viewModel.BarcodeReadText.Is("AAAA");
            viewModel.MaterialCodeText.Is("MC:[05005050505044]");
            viewModel.MaterialNameText.Is("名称:[1775B2]");

            MaterialMock.Setup(x => x.DeliveryRecordSave(It.IsAny<MaterialEntity>())).
                Callback<MaterialEntity>(saveValue =>
                {
                    saveValue.MaterialManagementCode.Value.Is("AAAA");
                });

            viewModel.DeliveryRecordSave();

            MaterialMock.VerifyAll();
        }
    }
}
