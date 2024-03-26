using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static Core.WebDriver.CustomWaiter;

namespace PageObjects
{
    public class InstallationPage
    {
        private readonly By _header = By.XPath("//h1");

        public bool IsCorresponding()
        {
            var actualHeader = _wait.Until(ExpectedConditions.ElementIsVisible(_header)).Text;

            return actualHeader.Trim() == "Installation";
        }
    }
}
