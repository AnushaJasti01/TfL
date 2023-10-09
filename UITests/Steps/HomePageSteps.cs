using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TfL.Automation.UITests.Pages;

namespace SCI.Automation.UITests.Steps
{
    [Binding]
    public class HomePageSteps : BasePage
    {
        public HomePageSteps(IWebDriver driver) : base(driver)
        {

        }

        [Given(@"the user is on TfL home page")]
        public void GivenTheUserIsOnTfLHomePage()
        {
            HomePage.NavigateToUrl();
        }

        [When(@"the user enters valid from location")]
        public void WhenTheUserEntersValidFromLocation()
        {
            HomePage.EnterValidFromLocation();
            HomePage.AcceptCookiesAndGoToPlanAJourneyPage();
        }

        [When(@"the user enters valid to location")]
        public void WhenTheUserEntersValidToLocation()
        {
            HomePage.EnterValidToLocation();
        }

        [When(@"the user clicks on plan my journey")]
        public void WhenTheUserClicksOnPlanMyJourney()
        {
            HomePage.ClickOnPlanMyJourney();
        }

        [When(@"the user enters invalid from location")]
        public void WhenTheUserEntersInvalidFromLocation()
        {
            HomePage.EnterInvalidFromLocation();
            HomePage.AcceptCookiesAndGoToPlanAJourneyPage();
        }

        [When(@"the user enters invalid to location")]
        public void WhenTheUserEntersInvalidToLocation()
        {
            HomePage.EnterInvalidToLocation();
        }

        [When(@"the user accepts all cookies policy")]
        public void WhenTheUserAcceptsAllCookiesPolicy()
        {
            HomePage.AcceptCookiesAndGoToPlanAJourneyPage();
        }

        [When(@"the user is on plan a journey page")]
        public void WhenTheUserIsOnPlanAJourneyPage()
        {
            SearchPage.GoToPlanAJourneyPage();
        }

        [When(@"the user plans for multiple journeys")]
        public void WhenTheUserPlansForMultipleJourneys()
        {
            HomePage.EnterMultipleValidFromLocation();
            HomePage.EnterMultipleValidToLocation();
            HomePage.ClickOnPlanMyJourney();
            SearchPage.GoToPlanAJourneyPage();
        }

        [Then(@"the recent journeys can be found in the recent tab")]
        public void ThenTheRecentJourneysCanBeFoundInTheRecentTab()
        {
            HomePage.VerifyRecentJourneyItemDisplayed();
        }

        [When(@"the user selects arriving option")]
        public void WhenTheUserSelectsArrivingOption()
        {
            HomePage.ClickOnChangeTime();
        }
    }
}
