using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    [TestFixture]
    public class JD_PowerTestcases
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        [Test]
        public void JDpower_InputFordMustang2012ExpectedJdLinkFordMustang2012()
        {

            driver.Navigate().GoToUrl("http://localhost/php/crud_app1/index.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Shruti");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("258 Sunview Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2269788995");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("shrutirupani89@gmail.com");
            driver.FindElement(By.Id("vehicle_make")).Click();
            driver.FindElement(By.Id("vehicle_make")).Clear();
            driver.FindElement(By.Id("vehicle_make")).SendKeys("Ford");
            driver.FindElement(By.Id("vehicle_model")).Click();
            driver.FindElement(By.Id("vehicle_model")).Clear();
            driver.FindElement(By.Id("vehicle_model")).SendKeys("Mustang");
            driver.FindElement(By.Id("vehicle_year")).Click();
            driver.FindElement(By.Id("vehicle_year")).Clear();
            driver.FindElement(By.Id("vehicle_year")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[8]/following::input[2]")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("alertDisplay")).Displayed);
        }

        [Test]
        public void JDpower_Inputharshabc2012Expected404NotFound()
        {
            driver.Navigate().GoToUrl("http://localhost/php/crud_app1/");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Harsh");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("258 Sunview Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");
            driver.FindElement(By.Id("vehicle_make")).Click();
            driver.FindElement(By.Id("vehicle_make")).Clear();
            driver.FindElement(By.Id("vehicle_make")).SendKeys("harsh");
            driver.FindElement(By.Id("vehicle_model")).Click();
            driver.FindElement(By.Id("vehicle_model")).Clear();
            driver.FindElement(By.Id("vehicle_model")).SendKeys("abc");
            driver.FindElement(By.Id("vehicle_year")).Click();
            driver.FindElement(By.Id("vehicle_year")).Clear();
            driver.FindElement(By.Id("vehicle_year")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[8]/following::input[2]")).Click();
            driver.FindElement(By.Id("jd_link")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//h1")).Displayed);
        }

        [Test]
        public void JDpower_Input2269788995ExpectedPhoneFormat()
        {
            driver.Navigate().GoToUrl("http://localhost/php/crud_app1/index.php");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Shruti");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("258 Sunview Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("2269788995");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("shrutirupani89@gmail.com");
            driver.FindElement(By.Id("vehicle_make")).Click();
            driver.FindElement(By.Id("vehicle_make")).Clear();
            driver.FindElement(By.Id("vehicle_make")).SendKeys("Ford");
            driver.FindElement(By.Id("vehicle_model")).Click();
            driver.FindElement(By.Id("vehicle_model")).Clear();
            driver.FindElement(By.Id("vehicle_model")).SendKeys("Mustang");
            driver.FindElement(By.Id("vehicle_year")).Click();
            driver.FindElement(By.Id("vehicle_year")).Clear();
            driver.FindElement(By.Id("vehicle_year")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[8]/following::input[2]")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("alertDisplay")).Displayed);
        }

        [Test]
        public void JDpower_InputabExpectedEmailFormat()
        {
            driver.Navigate().GoToUrl("http://localhost/php/crud_app1/");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("Nitin");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("258 Sunview Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("226-978-8995");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("ab");
            driver.FindElement(By.Id("vehicle_make")).Click();
            driver.FindElement(By.Id("vehicle_make")).Clear();
            driver.FindElement(By.Id("vehicle_make")).SendKeys("Ford");
            driver.FindElement(By.Id("vehicle_model")).Click();
            driver.FindElement(By.Id("vehicle_model")).Clear();
            driver.FindElement(By.Id("vehicle_model")).SendKeys("Mustang");
            driver.FindElement(By.Id("vehicle_year")).Click();
            driver.FindElement(By.Id("vehicle_year")).Clear();
            driver.FindElement(By.Id("vehicle_year")).SendKeys("2016");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[8]/following::input[2]")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("alertDisplay")).Displayed);
        }

        [Test]
        public void JDpower_InputBMW1Series2012ExpectedJdLinkBMW1Series2012()
        {
            driver.Navigate().GoToUrl("http://localhost/php/crud_app1/");
            driver.FindElement(By.Id("seller_name")).Click();
            driver.FindElement(By.Id("seller_name")).Clear();
            driver.FindElement(By.Id("seller_name")).SendKeys("parita");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("258 Sunview Street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("123-123-1234");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");
            driver.FindElement(By.Id("vehicle_make")).Click();
            driver.FindElement(By.Id("vehicle_make")).Clear();
            driver.FindElement(By.Id("vehicle_make")).SendKeys("BMW");
            driver.FindElement(By.Id("vehicle_model")).Click();
            driver.FindElement(By.Id("vehicle_model")).Clear();
            driver.FindElement(By.Id("vehicle_model")).SendKeys("1-Series");
            driver.FindElement(By.Id("vehicle_year")).Click();
            driver.FindElement(By.Id("vehicle_year")).Clear();
            driver.FindElement(By.Id("vehicle_year")).SendKeys("2012");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[8]/following::input[2]")).Click();
            driver.FindElement(By.Id("jd_link")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Displayed);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}

