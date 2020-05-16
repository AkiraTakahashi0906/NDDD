using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using NDDD.WinForm.ViewModels;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class MaterialListViewModelTest
    {
        [TestMethod]
        public void マテリアルリスト_シナリオ()
        {
            var materialMock = new Mock<IMaterialReceiptRepository>();
            var entities = new List<MaterialReceiptEntity>();

            entities.Add( new MaterialReceiptEntity(
                        new MaterialManagementCode("AAAA"),
                        Convert.ToDateTime("2012/12/12 12:34:56"),
                        "BOX-1234"
                        ));

            entities.Add(new MaterialReceiptEntity(
                        new MaterialManagementCode("BBBB"),
                        Convert.ToDateTime("2012/12/13 12:34:56"),
                        "BOX-4567"
                        ));

            entities.Add(new MaterialReceiptEntity(
                        new MaterialManagementCode("CCCC"),
                        Convert.ToDateTime("2012/12/14 12:34:56"),
                        "BOX-5689"
                        ));

            materialMock.Setup(x => x.GetData()).Returns(entities);

            var viewModel = new MaterialListViewModel(materialMock.Object);
            viewModel.MaterialReceipts.Count.Is(3);

        }
    }
}
