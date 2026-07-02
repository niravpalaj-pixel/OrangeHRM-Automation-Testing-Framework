using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace OrangeHRM_Automation_Testing_Framework
{
    public class DashboardPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        public bool IsDashboardDisplayed()
        {
            return wait.Until(d => d.Url.Contains("dashboard"));
        }
    }

}
