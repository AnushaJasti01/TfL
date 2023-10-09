# TfL-UIAutomationTestsForPlanJourney

This is a UI testing framework developed for functional testing using Selenium WebDriver with NUnit and C# in a .NET Core environment. It follows the SpecFlow BDD (Behavior-Driven Development) methodology and implements the Page Object Pattern for improved test maintainability and readability.

# Prerequisites to run the application:

1.  Visual Studio (2022)
2.  Browsers (Chrome or Firefox)

# Framework

# Utils.cs
1.  Initializing webdriver before each scenario
2.  defaulting to chrome
3.  capturing screenshots on test failure
4.  Cleanup and quit the webdriver instance
# DriverManager.cs 
  Initialize the webdriver based on the provided browser type (used chrome as default)
# Constants.cs
  Default timeout for various webdriver operations
#  BaseClass.cs
  Reusable methods

# Specflow tests

Acceptance tests are authored in feature files located within the /UITests/Features/ directory using the standard Gherkin language. These feature files follow the Given, When, Then, And format, where each step describes the desired business conditions or behavior. To automate these scenarios, each step has an associated step definition, which specifies how the actions in the scenarios are implemented and executed.
  

  
