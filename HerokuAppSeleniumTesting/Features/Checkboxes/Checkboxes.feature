﻿Feature: Checkboxes
Verifying functionalities on the checkboxes page - checking and unchecking checkboxes.

@positive
Scenario: Check and unckeck checkboxes
	When I open the checkboxes page
	Then assert that the second checkbox is checked
	And assert that the first checkbox is not checked