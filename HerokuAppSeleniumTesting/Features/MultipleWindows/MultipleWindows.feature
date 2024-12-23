Feature: MultipleWindows
Verifying multiple windows page functionalities.

@positive
Scenario: Click here button opens a new window
	Given I open the windows page
	When I press the click here button for opening a new window
	And I switch to the last tab
	Then assert that I am on windows/new page

