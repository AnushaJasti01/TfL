Feature: TfL_RecentJourney

Background: 
	Given the user is on TfL home page
	When the user enters valid from location
	And the user enters valid to location
	And the user clicks on plan my journey
	Then the user should see valid journey results	

Scenario: Verify recent journey
	When the user is on plan a journey page
	And the user plans for multiple journeys	
	Then the recent journeys can be found in the recent tab	
