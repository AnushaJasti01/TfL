Feature: TfL_EditJourney

Scenario: Verify edit journey
	Given the user is on TfL home page
	When the user enters valid from location
	And the user enters valid to location
	And the user clicks on plan my journey
	Then the user should see valid journey results
	And the user can see edit journey 
	When the user clicks on edit journey
	Then the user should see valid journey results