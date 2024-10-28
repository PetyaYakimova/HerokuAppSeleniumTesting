Feature: Login
Verifying login page functionalities.

@positive
Scenario: Admin user should be able to log in
	Given I open the login page
	When I enter tomsmith in the username field
	And I enter SuperSecretPassword! in the password field
	And I click the Login button
	Then assert that I see the logged in message
