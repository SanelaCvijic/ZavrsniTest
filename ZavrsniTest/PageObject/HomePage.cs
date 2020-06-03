using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace ZavrsniTest.PageObject
{
    class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void GoToPage()
        {
            this.driver.Navigate().GoToUrl("http://shop.qa.rs/");
        }

        public IWebElement Register
        {
            get
            {
                IWebElement element;
                try
                {
                    wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/register']")));
                    element = this.driver.FindElement(By.XPath("//a[@href='/register']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public RegisterPage ClickOnRegister()
        {
            this.Register?.Click();
            wait.Until(EC.ElementIsVisible(By.Name("ime")));
            return new RegisterPage(driver);

        }

        public IWebElement Login
        {
            get
            {
                IWebElement element;
                try
                {
                    wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/login']")));
                    element = this.driver.FindElement(By.XPath("//a[@href='/login']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public LoginPage ClickOnLogin()
        {
            this.Login?.Click();
            wait.Until(EC.ElementIsVisible(By.Name("username")));
            return new LoginPage(driver);

        }

        public IWebElement OrderOne
        {
            get
            {
                IWebElement element;
                try
                {
                    wait.Until(EC.ElementIsVisible(By.XPath("//div[@class='panel panel-default']//input[@type='submit']")));
                    element = this.driver.FindElement(By.XPath("//div[@class='panel panel-default']//input[@type='submit']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public OrderPage ClickOnOrderOne()
        {
            this.OrderOne?.Click();
            wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/']")));
             return new OrderPage(driver);

        }

        public IWebElement SecondOrder
        {
            get
            {
                IWebElement element;
                try
                {
                    wait.Until(EC.ElementIsVisible(By.XPath("//div[@class='panel panel-info']//input[@type='submit']")));
                    element = this.driver.FindElement(By.XPath("//div[@class='panel panel-info']//input[@type='submit']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public OrderPage ClickOnSecondOrder()
        {
            this.SecondOrder?.Click();
            wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/']")));
            return new OrderPage(driver);

        }

        public IWebElement ShopingCart
        {
            get
            {
                IWebElement element;
                try
                {
                    wait.Until(EC.ElementIsVisible(By.XPath("//a[@href='/cart']")));
                    element = this.driver.FindElement(By.XPath("//a[@href='/cart']"));
                }
                catch (Exception)
                {
                    element = null;
                }

                return element;
            }
        }

        public CartPage ClickOnShopingCart()
        {
            this.ShopingCart?.Click();
            wait.Until(EC.ElementIsVisible(By.XPath("td[text()]")));
            return new CartPage(driver);

        }

    }
}
