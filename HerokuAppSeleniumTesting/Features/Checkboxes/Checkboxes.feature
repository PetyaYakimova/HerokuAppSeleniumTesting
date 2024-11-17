Feature: Checkboxes
Verifying functionalities on the checkboxes page - checking and unchecking checkboxes.

@positive
Scenario: Check and unckeck checkboxes
	When I open the checkboxes page
	Then assert that the second checkbox is checked
	And assert that the first checkbox is not checked
	When I click the first checkbox
	Then assert that the first checkbox is checked
	And assert that the second checkbox is checked
	When I click the second checkbox
	Then assert that the second checkbox is not checked
	And assert that the first checkbox is checked
	When I click the first checkbox
	Then assert that the first checkbox is not checked
	And assert that the second checkbox is not checked
