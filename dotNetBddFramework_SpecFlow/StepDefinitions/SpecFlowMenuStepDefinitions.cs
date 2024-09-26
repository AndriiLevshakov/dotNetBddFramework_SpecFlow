using dotNetBddFramework_SpecFlow.Support;
using NUnit.Framework;
using PageObjects;


namespace dotNetBddFramework_SpecFlow.StepDefinitions
{
    [Binding]
    public class SpecFlowMenuStepDefinitions : BaseTestFixtures
    {
        private readonly HomePage _homePage;
        private readonly Navigation _navigation;
        private readonly SpecFlowPage _specFlowPage;
        private readonly InstallationPage _installationPage;

        public SpecFlowMenuStepDefinitions()
        {
            _homePage = new HomePage();

            _navigation = new Navigation();

            _specFlowPage = new SpecFlowPage();

            _installationPage = new InstallationPage();
        }

        [Given(@"SpecFlow website is loaded")]
        public void GivenSpecFlowWebsiteIsLoaded()
        {
            _navigation.NavigateToStartPage();
        }

        [When(@"I hover over the Docs menu item")]
        public void WhenIHoverOverTheMenuItem()
        {
            _homePage.HoverToDocsMenuItem();
        }

        [When(@"I select SpecFlow")]
        public void WhenISelect()
        {
            _homePage.ClickSpecFlowLink();
        }

        [When(@"I click on the search docs field")]
        public void WhenIClickOnTheField()
        {
            _specFlowPage.ClickSearchDocsField();
        }

        [When(@"I enter Installation in the popup window")]
        public void WhenIEnterInThePopupWindow()
        {
            _specFlowPage.InsertText("Installation");
        }

        [When(@"I select the result titled Installation")]
        public void WhenISelectTheResultTitled()
        {
            _specFlowPage.SelectResult();
        }

        [Then(@"the page titled Installation opens")]
        public void ThenThePageTitledOpens()
        {
            var actualHeader = _installationPage.GetPageHeader();

            Assert.That(actualHeader == "Installation");
        }
    }
}
