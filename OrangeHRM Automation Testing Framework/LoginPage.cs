using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM_Automation_Testing_Framework
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        private IWebElement Username =>
            wait.Until(d => d.FindElement(By.Name("username")));

        private IWebElement Password =>
            wait.Until(d => d.FindElement(By.Name("password")));

        private IWebElement LoginButton =>
            wait.Until(d => d.FindElement(By.CssSelector("button[type='submit']")));

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}