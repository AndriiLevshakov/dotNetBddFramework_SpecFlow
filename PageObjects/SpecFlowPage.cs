using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static Core.WebDriver.CustomWaiter;

namespace PageObjects
{
    public class SpecFlowPage
    {
        private readonly By _searchDocsField = By.XPath("//input[@type='text']");
        private readonly By _popUpWindowInput = By.XPath("//input[@class='search__outer__input']");
        private readonly By _searchResult = By.XPath("//span[contains(text(), 'installation')]");

        public void ClickSearchDocsField()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_searchDocsField)).Click();
        }

        public void InsertText(string text)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(_popUpWindowInput)).SendKeys(text);
        }

        public void SelectResult()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(_searchResult)).Click();
        }
    }
}
