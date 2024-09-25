using dotNetBddFramework_SpecFlow.Support;
using NUnit.Framework;
using PageObjects;


namespace dotNetBddFramework_SpecFlow.StepDefinitions
{
    [Binding]
    public class SpecFlowMenuTestStepDefinitions : BaseTestFixtures
    {
        private readonly HomePage _homePage;
        private readonly Navigation _navigation;
        private readonly SpecFlowPage _speckFlowPage;
        private readonly InstallationPage _installationPage;

        public SpecFlowMenuTestStepDefinitions()
        {
            _homePage = new HomePage();

            _navigation = new Navigation();

            // typo
            _speckFlowPage = new SpecFlowPage();

            _installationPage = new InstallationPage();
        }

        [Given(@"SpecFlow website is loaded")]
        public void GivenSpecFlowWebsiteIsLoaded()
        {
            _navigation.NavigateToStartPage();
        }

        // no need to provide an argument if it is not handled in any way
        // just rewrite step definition to [When(@"I hover over the Docs menu item")]
        [When(@"I hover over the ""([^""]*)"" menu item")]
        public void WhenIHoverOverTheMenuItem(string docs)
        {
            _homePage.HoverToDocsMenuItem();
        }

        // same here
        [When(@"I select ""([^""]*)""")]
        public void WhenISelect(string specFlow)
        {
            _homePage.ClickSpecFlowLink();
        }

        // same here
        [When(@"I click on the '([^']*)' field")]
        public void WhenIClickOnTheField(string p0)
        {
            _speckFlowPage.ClickSearchDocsField();
        }

        // same here, or make the InsertText method accept a string argument with text to be inserted
        [When(@"I enter ""([^""]*)"" in the popup window")]
        public void WhenIEnterInThePopupWindow(string installation)
        {
            _speckFlowPage.InsertText();
        }

        // same here
        [When(@"I select the result titled ""([^""]*)""")]
        public void WhenISelectTheResultTitled(string installation)
        {
            _speckFlowPage.SelectResult();
        }

        // same here
        [Then(@"the page titled ""([^""]*)"" opens")]
        public void ThenThePageTitledOpens(string installation)
        {
            // codestyle
            var IsHeaderCorresponding = _installationPage.IsCorresponding();

            Assert.That(IsHeaderCorresponding);
        }
    }
}
