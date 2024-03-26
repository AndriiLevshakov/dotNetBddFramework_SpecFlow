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

            _speckFlowPage = new SpecFlowPage();

            _installationPage = new InstallationPage();
        }

        [Given(@"SpecFlow website is loaded")]
        public void GivenSpecFlowWebsiteIsLoaded()
        {
            _navigation.NavigateToStartPage();
        }

        [When(@"I hover over the ""([^""]*)"" menu item")]
        public void WhenIHoverOverTheMenuItem(string docs)
        {
            _homePage.HoverToDocsMenuItem();
        }

        [When(@"I select ""([^""]*)""")]
        public void WhenISelect(string specFlow)
        {
            _homePage.ClickSpecFlowLink();
        }

        [When(@"I click on the '([^']*)' field")]
        public void WhenIClickOnTheField(string p0)
        {
            _speckFlowPage.ClickSearchDocsField();
        }

        [When(@"I enter ""([^""]*)"" in the popup window")]
        public void WhenIEnterInThePopupWindow(string installation)
        {
            _speckFlowPage.InsertText();
        }

        [When(@"I select the result titled ""([^""]*)""")]
        public void WhenISelectTheResultTitled(string installation)
        {
            _speckFlowPage.SelectResult();
        }

        [Then(@"the page titled ""([^""]*)"" opens")]
        public void ThenThePageTitledOpens(string installation)
        {
            var IsHeaderCorresponding = _installationPage.IsCorresponding();

            Assert.That(IsHeaderCorresponding);
        }
    }
}
