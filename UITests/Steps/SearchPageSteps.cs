using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TfL.Automation.UITests.Pages;

namespace SCI.Automation.UITests.Steps
{
    [Binding]
    public class SearchPageSteps : BasePage
    {
        public SearchPageSteps(IWebDriver driver) : base(driver)
        {

        }

        [Then(@"the user should see valid journey results")]
        public void ThenTheUserShouldSeeValidJourneyResults()
        {
            SearchPage.VerifySearchResults();
        }

        [Then(@"the user shouldnot see matching journey results")]
        public void ThenTheUserShouldnotSeeMatchingJourneyResults()
        {
            SearchPage.VerifyInvalidSearchResultsText();
        }

        [Then(@"the user is unable to plan journey")]
        public void ThenTheUserIsUnableToPlanJourney()
        {
            SearchPage.VerifyNoLocationFormFieldErrorMessage();
        }

        [Then(@"the user can see edit journey")]
        public void ThenTheUserCanSeeEditJourney()
        {
            SearchPage.VerifyEditJourneyDisplayed();
        }

        [When(@"the user clicks on edit journey")]
        public void WhenTheUserClicksOnEditJourney()
        {
            SearchPage.ClickOnEditJourney();
            SearchPage.SelectTomorrow();
        }
    }
}
