Feature: KeyPresses
Verifying key presses page functionalities.

@positive
Scenario: Sent keys to the page are displayed correctly
	Given I open the key presses page
	When I send L key to the page
	Then assert that the result says that I have entered L
	When I send SHIFT key to the page
	Then assert that the result says that I have entered SHIFT
	When I send ENTER key to the page
	Then assert that the result says that I have entered ENTER
	When I send DELETE key to the page
	Then assert that the result says that I have entered DELETE
	When I send TAB key to the page
	Then assert that the result says that I have entered TAB
	When I send 8 key to the page
	Then assert that the result says that I have entered 8
	When I send 2 key to the page
	Then assert that the result says that I have entered 2
