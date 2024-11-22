Feature: ContextMenu
Verifying context menu page functionalities.

@positive
Scenario: Check context menu appears on right mouse click
	Given I open the context menu page
	When I right click the hot spot box
	Then assert that I do see the alert
