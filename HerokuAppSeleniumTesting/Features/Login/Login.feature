Feature: Login
Verifying login page functionalities.

@positive
Scenario: Admin user should be able to log in
	Given I open the login page
	And I enter tomsmith in the username field
