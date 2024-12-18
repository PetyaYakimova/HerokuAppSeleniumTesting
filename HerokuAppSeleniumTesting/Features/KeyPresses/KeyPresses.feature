Feature: KeyPresses
Verifying key presses page functionalities.

@positive
Scenario: Sent keys to the page are displayed correctly
	Given I open the key presses page
	When I send L key to the page
	Then assert that the result says that I have entered L
	When I send SHIFT key to the page
	Then assert that the result says that I have entered SHIFT
