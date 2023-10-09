using NUnit.Framework;
using OpenQA.Selenium;
using TfL.Automation;
using TfL.Automation.UITests.Utils;

namespace TlF.Automation.UITests.Pages
{
    public class SearchPage : BaseClass
    {
        private readonly ConfigData configData;

        public SearchPage(IWebDriver driver) : base(driver)
        {
            configData = Hooks.GetConfigurationData();
        }

        // Locators for various page elements
        private By SearchResults => By.XPath("//div[contains(@class, 'journey-result-summary')]");
        private By FieldValidationErrors => By.CssSelector(".field-validation-errors");
        private string ExpectedInvalidSearchResultsText = "Sorry, we can't find a journey matching your criteria";
        private static By InputFromError => By.CssSelector("#InputFrom-error");
        private static By InputToError => By.CssSelector("#InputTo-error");
        private string ExpectedNoLocationFromText = "The From field is required.";
        private string ExpectedNoLocationToText = "The To field is required.";
        private static By TflHomeLink => By.CssSelector(".tfl-name");
        private static By EditJourney => By.CssSelector(".edit-journey");
        private static By DateSelector => By.CssSelector("#Date");
        private static By UpdateJourney => By.CssSelector("#plan-journey-button");

        // Method to verify search results
        public void VerifySearchResults()
        {
            string? actualSearchResultsText = GetElementText(SearchResults);
            if (actualSearchResultsText != null)
            {
                Assert.IsTrue(actualSearchResultsText.Contains(configData.ValidFromLocation), "The search results do not show the expected valid 'from' location");
                Assert.IsTrue(actualSearchResultsText.Contains(configData.ValidToLocation), "The search results do not show the expected valid 'to' location");
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }

        // Method to verify invalid search results message
        public void VerifyInvalidSearchResultsText()
        {
            string? actualInvalidSearchResultsText = GetElementText(FieldValidationErrors);
            if (actualInvalidSearchResultsText != null)
            {
                Assert.IsTrue(actualInvalidSearchResultsText.Contains(ExpectedInvalidSearchResultsText), "The search results page does not show the expected invalid results message");
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }

        // Method to verify form field error messages
        public void VerifyNoLocationFormFieldErrorMessage()
        {
            string? actualFromFieldRequiredText = GetElementText(InputFromError);
            string? actualToFieldRequiredText = GetElementText(InputToError);

            if (actualFromFieldRequiredText != null && actualToFieldRequiredText != null)
            {
                Assert.IsTrue(actualFromFieldRequiredText.Contains(ExpectedNoLocationFromText), "The 'no location' search results do not match the expected 'from' location exception message");
                Assert.IsTrue(actualToFieldRequiredText.Contains(ExpectedNoLocationToText), "The 'no location' search results do not match the expected 'to' location exception message");
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }

        // Method to navigate to the TfL homepage
        public void GoToPlanAJourneyPage()
        {
            ClickEvent(TflHomeLink, skipHighlight: true);
        }

        // Method to verify the "Edit Journey" option is displayed
        public void VerifyEditJourneyDisplayed()
        {
            Assert.IsTrue(ElementIsVisible(EditJourney), "The 'Edit Journey' option is not displayed");
        }

        // Method to click on the "Edit Journey" option
        public void ClickOnEditJourney()
        {
            ClickEvent(EditJourney, skipHighlight: true);
        }

        // Method to select tomorrow's date
        public void SelectTomorrow()
        {
            ClickEvent(UpdateJourney, skipHighlight: true);
        }
    }
}
