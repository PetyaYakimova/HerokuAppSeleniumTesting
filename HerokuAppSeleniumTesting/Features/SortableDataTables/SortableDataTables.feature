Feature: SortableDataTables
Verifying sortable data tables page functionalities.

@positive
Scenario: Table can be ordered by each column
	Given I open the tables page
	When I click the Last Name column header in the first table
