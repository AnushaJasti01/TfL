Feature: TfL_ValidJourney

Scenario: Verify that a valid journey can be planned using the widget 
	Given the user is on TfL home page
	When the user enters valid from location
	And the user enters valid to location
	And the user clicks on plan my journey
	Then the user should see valid journey results