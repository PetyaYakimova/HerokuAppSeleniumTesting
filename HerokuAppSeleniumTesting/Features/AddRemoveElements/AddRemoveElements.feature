Feature: AddRemoveElements
Verifying add-remove elements page functionalities.

@positive
Scenario: Elements can be added and removed
	Given I open the add_remove_elements/ page
	When I click the Add element button 1 times
	Then assert that I see 1 Delete element buttons
