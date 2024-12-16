Feature: KeyPresses
Verifying key presses page functionalities.

@positive
Scenario: Sent keys to the page are displayed correctly
	Given I open the key presses page
	When I send l key to the page
