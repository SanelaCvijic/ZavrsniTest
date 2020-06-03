using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ZavrsniTest.PageObject
{
    class OrderPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public OrderPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public IWebElement ContinueShopping
        {
            get
            {
                IWebElement element;
                try
                {  //"a[text()='Continue shopping']"
                    wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/']")));
                    element = this.driver.FindElement(By.XPath("//a[@href='/']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public HomePage ClickOnContinueShopping()
        {
            this.ContinueShopping?.Click();
            wait.Until(EC.ElementIsVisible(By.XPath("//div[contains(@class,'col-sm-12 text-center')]/h2")));
            return new HomePage(driver);

        }

    }
}
