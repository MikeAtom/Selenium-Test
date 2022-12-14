using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Page_Object
{
    public class FirstPage : BasePage
    {
        private static WebDriverWait wait;
        public FirstPage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
        }

        private IWebElement BtnBankManagerLogin => wait.Until(e => e.FindElement(By.XPath("//button[@ng-click='manager()']")));
        public void ClickFirst() => BtnBankManagerLogin.Click();
    }


}
