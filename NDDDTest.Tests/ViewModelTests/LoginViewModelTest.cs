using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;

namespace NDDDTest.Tests.ViewModelTests
{
    [TestClass]
    public class LoginViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var usersMock = new Mock<IUserRepository2>();
            var users = new List<UserEntity2>();
            users.Add(new UserEntity2(1, "1", "1"));
            users.Add(new UserEntity2(1, "2", "2"));
            users.Add(new UserEntity2(1, "2", "2"));

            usersMock.Setup(x => x.GetUser()).Returns(users);

        }
    }
}
