using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace OrangeHRM_Automation_Testing_Framework
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("Admin", "admin123");

            DashboardPage dashboardPage = new DashboardPage(driver);

            Assert.That(dashboardPage.IsDashboardDisplayed(), Is.True);
        }
    }


}
