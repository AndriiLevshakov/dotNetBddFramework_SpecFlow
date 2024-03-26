using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using static Core.WebDriver.CustomWaiter;
using static Core.WebDriver.WebDriverManager;

namespace PageObjects
{
    public class HomePage
    {
        private readonly By _docsMenuItem = By.XPath("//a[contains(text(), 'Docs')]");
        private readonly By _specFlowLink = By.XPath("//li[@id='menu-item-1067']");

        public void HoverToDocsMenuItem()
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(_docsMenuItem));

            IWebElement docsElement = CurrentDriver.FindElement(_docsMenuItem);

            Actions action = new Actions(CurrentDriver);

            action.MoveToElement(docsElement).Perform();
        }

        public void ClickSpecFlowLink()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_specFlowLink)).Click();
        }
    }
}
