Feature: DigestAuthentication
Verifying digest authentication page functionalities.

@positive
Scenario: Admin with valid password should be able to log in
	Given I open the digest auth page
	When I pass username admin and password admin for the digest authentication
