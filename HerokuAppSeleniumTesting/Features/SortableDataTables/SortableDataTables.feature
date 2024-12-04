Feature: SortableDataTables
Verifying sortable data tables page functionalities.

@positive
Scenario: Table can be ordered by each column
	Given I open the tables page
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in ascending order
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in descending order
