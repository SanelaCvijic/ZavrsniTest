using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ZavrsniTest.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private IWebElement GetElement(By by)
        {
            IWebElement element;
            try
            {
                element = this.driver.FindElement(by);
            }
            catch (Exception)
            {
                element = null;
            }

            return element;

        }

        public IWebElement UserName
        {
            get
            {
                return this.GetElement(By.Name("username"));
            }
        }

        public IWebElement password
        {
            get
            {
                return this.GetElement(By.Name("password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return this.GetElement(By.Name("login"));
            }
        }

       


    }
}
