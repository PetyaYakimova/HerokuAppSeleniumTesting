Feature: ChallengingDOM
Verifying funcionalities on the Challenging DOM page.

@positive
Scenario: Check that the action buttons change the answer
	Given I open the challenging_dom page
	And I get the canvas image
	When I click the first button on the challending DOM page
	Then assert that the canvas image has changed
	When I click the second button on the challending DOM page
	Then assert that the canvas image has changed
	When I click the third button on the challending DOM page
	Then assert that the canvas image has changed
