Feature: SortableDataTables
Verifying sortable data tables page functionalities.

@positive
Scenario: Table can be ordered by each column
	Given I open the tables page
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in ascending order
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in descending order
	Given I open the tables page
	When I click the First Name column header in the first table
	Then assert that the first table is ordered by First Name in ascending order
	When I click the First Name column header in the first table
	Then assert that the first table is ordered by First Name in descending order
	When I click the Email column header in the first table
	Then assert that the first table is ordered by Email in ascending order
	When I click the Email column header in the first table
	Then assert that the first table is ordered by Email in descending order
	When I click the Due column header in the first table
	Then assert that the first table is ordered numerically by Due column in ascending order
	When I click the Due column header in the first table
	Then assert that the first table is ordered numerically by Due column in descending order
