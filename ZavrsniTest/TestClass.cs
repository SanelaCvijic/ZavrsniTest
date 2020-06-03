using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ZavrsniTest.PageObject;
using QaHomePage = ZavrsniTest.PageObject.HomePage;
using RegisterPage = ZavrsniTest.PageObject.RegisterPage;
using LOginPage = ZavrsniTest.PageObject.LoginPage;


namespace ZavrsniTest
{
    class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
          public void TestHomePage()
         {
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();
        }

        [Test]
        [Category ("Regitration")]

        public void TestRegistration()
        {
            RegisterPage reg;
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();
            
            reg = naslovna.ClickOnRegister();
            reg.FirstName.SendKeys("Mirko");
            reg.LastName.SendKeys("Mirkovic");
            reg.Email.SendKeys("MikiMi@nastpje.oorg");
            reg.UserName.SendKeys("MirkoMi");
            reg.password.SendKeys("JAkoDobraSifra123");
            reg.confirmPaswword.SendKeys("JAkoDobraSifra123");
            reg.RegisterButton.Click();
        }

        [Test]
        [Category("Login")]

        public void TestLogin()
        {
            LoginPage login;
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();

            login=naslovna.ClickOnLogin();
            login.UserName.SendKeys("MirkoMi");
            login.password.SendKeys("JAkoDobraSifra123");
            login.LoginButton.Click();
            
        }
      
        [Test]
        [Category("Order")]
        public void TestOrder()
        {
            OrderPage order;
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();

            order=naslovna.ClickOnOrderOne();
            order = naslovna.ClickOnSecondOrder();
            


        }

        [Test]
        [Category("Cart")]

        public void TestCartPage()
        {
            CartPage cart;
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();

            cart = naslovna.ClickOnShopingCart();
            

        }


        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }
    }
}
