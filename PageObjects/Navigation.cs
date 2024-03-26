using static Core.WebDriver.WebDriverManager;

namespace PageObjects
{
    public class Navigation
    {
        public void NavigateToStartPage()
        {
            CurrentDriver.Navigate().GoToUrl(BaseUrl);
        }
    }
}
