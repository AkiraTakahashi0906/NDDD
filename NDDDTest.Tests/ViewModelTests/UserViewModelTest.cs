using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.WinForm.ViewModels;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class UserViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var entity = new UserEntity(
                1,
                "高橋彬",
                "043527"
                );

            var UserMock = new Mock<IUserRepository>();
            UserMock.Setup(x => x.GetUserData(1)).Returns(entity);

            var vm = new UserLoginViewModel(UserMock.Object);
            //ユーザーID
            //ユーザー名
            //パスワード
            vm.Search();
            vm.UserIdText.Is("0001");
            vm.UserNameText.Is("高橋彬");
            vm.UserLoginPasswordText.Is("043527");

        }
    }
}
