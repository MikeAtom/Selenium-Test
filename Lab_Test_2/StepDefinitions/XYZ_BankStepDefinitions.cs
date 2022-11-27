using Lab_2_web_testing.Steps;
using NUnit.Framework;
using Page_Object;

namespace Lab_Test_2.StepDefinitions
{
    [Binding]
    public class XYZ_BankStepDefinitions : BaseStep
    {
        private FirstPage firstPage;
        private SelectPage selectPage;
        private CustomersPage customersPage;
        List<string> actualLastNames = new List<string>();
        List<string> expectedLastNames = new List<string>();

        [Given(@"open XYZ_Bank site")]
        public void GivenOpenXYZ_BankSite()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/";
            firstPage = new FirstPage(driver);
        }

        [Given(@"click on the Bank Manager  button")]
        public void GivenClickOnTheBankManagerButton()
        {
            firstPage.ClickFirst();
        }

        [Given(@"click on the Customers button")]
        public void GivenClickOnTheCustomersButton()
        {
            selectPage = new SelectPage(driver);
            selectPage.ClickCustomers();
        }

        [When(@"click on the Last Name")]
        public void WhenClickOnTheLastName()
        {
            customersPage = new CustomersPage(driver);
            Thread.Sleep(1000);
            expectedLastNames = customersPage.GetLastNames();
            expectedLastNames.Sort((a, b) => b.CompareTo(a));
            customersPage.ClickLastName();
            actualLastNames = customersPage.GetLastNames();
        }

        [Then(@"customers should be sorted in descending order")]
        public void ThenCustomersShouldBeSortedInDescendingOrder()
        {
            Assert.AreEqual(actualLastNames, expectedLastNames);
        }
    }
}
