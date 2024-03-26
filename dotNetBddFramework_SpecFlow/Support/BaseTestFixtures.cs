using Core.Logger;
using Core.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using static Core.WebDriver.WebDriverManager;
using static Core.WebDriver.CustomWaiter;

namespace dotNetBddFramework_SpecFlow.Support
{
    public abstract class BaseTestFixtures
    {
        protected WebDriverManager _webDriverManager;

        protected BaseTestFixtures()
        {
            _webDriverManager = new WebDriverManager();
        }

        [BeforeScenario]
        public void SetUp()
        {
            LoggerManager.Logger.Info($"Starting {TestContext.CurrentContext.Test.MethodName}");

            _wait = new WebDriverWait(CurrentDriver, TimeSpan.FromSeconds(5));

        }

        [AfterScenario]
        public void TearDown()
        {
            string? testName = TestContext.CurrentContext.Test.MethodName;

            ScreenShot.CaptureScreenshot(WebDriverManager.CurrentDriver, testName + ".png");

            LoggerManager.Logger.Info("Test successfully finished");

            QuitDriver();
        }
    }
}
