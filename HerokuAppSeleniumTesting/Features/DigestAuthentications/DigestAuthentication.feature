Feature: DigestAuthentication
Verifying digest authentication page functionalities.

@positive
Scenario: Admin with valid password should be able to log in
	Given I open the digest auth page
	When I pass username admin and password admin for the digest authentication
	Then assert that I see the digest authentication page heading

@negative
Scenario Outline: User with invalid invalid credentials shouldn't be able to log in
	Given I open the digest auth page
	When I pass username <username> and password <password> for the digest authentication
	Then assert that I do not see the digest authentication page heading

Examples:
	| username | password    |
	| admin    | invalidPass |
	| user     | admin       |
	|          | pass        |
	| user     |             |
	|          |             |
