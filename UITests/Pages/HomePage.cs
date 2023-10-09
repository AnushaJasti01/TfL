using NUnit.Framework;
using OpenQA.Selenium;
using TfL.Automation.UITests.Utils;

namespace TfL.Automation.UITests.Pages
{
    public class HomePage : BaseClass
    {
        private readonly ConfigData configData;

        public HomePage(IWebDriver driver) : base(driver)
        {
            // Initialize configuration data using Hooks (assuming this is set up elsewhere).
            configData = Hooks.GetConfigurationData();
        }

        // Locators for various page elements
        private By GoToTheUkSiteButton => By.Id("stc-popup-continue");
        private By SearchIcon => By.XPath("//div[contains(@class,'header-search-img')]");
        private By SearchInput => By.XPath("//div[@class='search-wrap animate-desktop']//input[@class='search-box']");
        private By InputSearchIcon => By.XPath("//div[@class='search-wrap animate-desktop']//span[@class = 'search-icon']");
        private By AcceptCookiesButton => By.XPath("//button[text() = 'Accept All Cookies']");
        private By FromLocation => By.Id("InputFrom");
        private By ToLocation => By.Id("InputTo");
        private By PlanMyJourney => By.Id("plan-journey-button");
        private By ChangeTime => By.CssSelector(".change-departure-time");
        private By Arriving => By.CssSelector("label[for='arriving']");
        private By AcceptCookies => By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll");
        private static By RecentTab => By.CssSelector("#jp-recent-tab-home");
        private static By RecentJourneyItems => By.Id("jp-recent-content-home-");

        public void NavigateToUrl()
        {
            NavigateToPage(configData.Url);
        }

        public void EnterValidFromLocation()
        {
            EnterText(FromLocation, configData.ValidFromLocation);
        }

        public void EnterMultipleValidFromLocation()
        {
            EnterText(FromLocation, configData.MultipleValidFromLocation);
        }

        public void EnterInvalidFromLocation()
        {
            EnterText(FromLocation, configData.InValidFromLocation);
        }

        public void EnterInvalidToLocation()
        {
            EnterText(ToLocation, configData.InValidToLocation);
        }

        public void AcceptCookiesAndGoToPlanAJourneyPage()
        {
            ClickEvent(AcceptCookies);
        }

        public void EnterValidToLocation()
        {
            EnterText(ToLocation, configData.ValidToLocation);
        }

        public void EnterMultipleValidToLocation()
        {
            EnterText(ToLocation, configData.MultipleValidToLocation);
        }

        public void ClickOnChangeTime()
        {
            ClickEvent(ChangeTime, skipHighlight: true);
            ClickEvent(Arriving, skipHighlight: true);
        }

        public void ClickOnPlanMyJourney()
        {
            ClickEvent(PlanMyJourney, skipHighlight: true);
        }

        public void VerifyRecentJourneyItemDisplayed()
        {
            ClickEvent(RecentTab, skipHighlight: true);
            Assert.IsTrue(ElementIsVisible(RecentJourneyItems), "The Recent tab is not showing recent journey details");
        }
    }
}
