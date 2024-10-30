Feature: Login
Verifying login page functionalities.

@positive
Scenario: Valid user should be able to log in
	Given I open the login page
	When I enter tomsmith in the username field
	And I enter SuperSecretPassword! in the password field
	And I click the Login button
	Then assert that I see the logged in message
	And assert that I see the logout button

@negative
Scenario Outline: User with invalid credentials shouldn't be able to log in
	Given I open the login page
	When I enter <username> in the username field
	And I enter <password> in the password field
	And I click the Login button
	Then assert that I see the invalid <invalidCredential> message

Examples:
	| username  | password             | invalidCredential |
	| tomsmith  | InvalidPass          | password          |
	| otheruser | SuperSecretPassword! | username          |
	|           | onlyPass             | username          |
	| tomsmith  |                      | password          |
	|           |                      | username          |