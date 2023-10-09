Feature: TfL_NoLocation

Scenario: Verify that the widget is unable to plan a journey if no locations are entered 
	Given the user is on TfL home page
	When the user accepts all cookies policy
	And the user clicks on plan my journey
	Then the user is unable to plan journey