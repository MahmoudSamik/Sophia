using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SophiaFioriAutomation;

namespace SophiaFioriTests
{
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void AdminUsersCanLogin()
        {
            LoginPage.GoTo();
         LoginPage.LoginAs("faisal@foothillsolutions.com").WithPassword("foobar").Login();
         Assert.IsTrue(MainPage.IsAt, "Failed to Login");


        }
    }
}
