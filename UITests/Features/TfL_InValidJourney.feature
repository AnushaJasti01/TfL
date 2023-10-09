Feature: TfL_InValidJourney

Background: 
	Given the user is on TfL home page

Scenario: Verify that the widget is unable to provide results when an invalid from location journey is planned 
	When the user enters invalid from location
	And the user enters valid to location
	And the user clicks on plan my journey
	Then the user shouldnot see matching journey results

Scenario: Verify that the widget is unable to provide results when an invalid to location journey is planned
	When the user enters valid from location
	And the user enters invalid to location
	And the user clicks on plan my journey
	Then the user shouldnot see matching journey results

Scenario: Verify that the widget is unable to provide results when an invalid journey is planned
	When the user enters invalid from location
	And the user enters invalid to location
	And the user clicks on plan my journey
	Then the user shouldnot see matching journey results
