using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static Core.WebDriver.CustomWaiter;

namespace PageObjects
{
    public class InstallationPage
    {
        private readonly By _header = By.XPath("//h1");

        // this method doesn't have a name that explains well what it does
        public bool IsCorresponding()
        {
            var actualHeader = _wait.Until(ExpectedConditions.ElementIsVisible(_header)).Text;

            return actualHeader.Trim() == "Installation";
        }
    }
}
