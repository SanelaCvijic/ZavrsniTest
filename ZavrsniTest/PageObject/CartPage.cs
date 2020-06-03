using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ZavrsniTest.PageObject
{
    class CartPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }


        public IWebElement ButtonCheckout
        {
            get
            {
                IWebElement element;
                try
                {  
                    wait.Until(EC.ElementIsVisible(By.XPath("//input[@type='submit']")));
                    element = this.driver.FindElement(By.XPath("//input[@type='submit']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public HomePage ClickOnCheckout()
        {
            this.ButtonCheckout?.Click();
            wait.Until(EC.ElementIsVisible(By.XPath("//div[contains(@class,'col-sm-12 text-center')]/h2")));
            return new HomePage(driver);

        }

    }
}
