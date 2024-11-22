Feature: AddRemoveElements
Verifying add-remove elements page functionalities.

@positive
Scenario: Elements can be added and removed
	Given I open the add remove elements/ page
	When I click the Add element button 1 times
	Then assert that I see 1 Delete element buttons
	When I click the Delete element button 1 times
	Then assert that I see 0 Delete element buttons
	When I click the Add element button 12 times
	Then assert that I see 12 Delete element buttons
	When I click the Delete element button 5 times
	Then assert that I see 7 Delete element buttons
	When I click the Add element button 2 times
	Then assert that I see 9 Delete element buttons