Feature: TfL_PlanAJourneyBasedOnArrivalTime

Scenario: Verify journey based on arrival time
	Given the user is on TfL home page
	When the user enters valid from location
	And the user enters valid to location
	And the user selects arriving option
	And the user clicks on plan my journey
	Then the user should see valid journey results
