using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDDD.WinForm.ViewModels;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class UserViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var vm = new UserViewModel();
            //ユーザーID
            //ユーザー名
            //パスワード
            vm.Search();
            vm.UserIdText.Is("1");
            vm.UserNameText.Is("高橋彬");
            vm.UserLoginPasswordText.Is("043527");

        }
    }
}
