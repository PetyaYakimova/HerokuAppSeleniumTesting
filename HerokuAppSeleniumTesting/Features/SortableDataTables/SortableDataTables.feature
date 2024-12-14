Feature: SortableDataTables
Verifying sortable data tables page functionalities.

@positive
Scenario: First table can be ordered by each column
	Given I open the tables page
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in ascending order
	When I click the Last Name column header in the first table
	Then assert that the first table is ordered by Last Name in descending order
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
	When I click the Web Site column header in the first table
	Then assert that the first table is ordered by Web Site in ascending order
	When I click the Web Site column header in the first table
	Then assert that the first table is ordered by Web Site in descending order

@positive
Scenario: Second table can be ordered by each column
	Given I open the tables page
	When I click the Last Name column header in the second table
	Then assert that the second table is ordered by Last Name in ascending order
	And assert that the Last Name column header in the second table has headerSortDown class
	When I click the Last Name column header in the second table
	Then assert that the second table is ordered by Last Name in descending order
	And assert that the Last Name column header in the second table has headerSortUp class
	When I click the First Name column header in the second table
	Then assert that the second table is ordered by First Name in ascending order
	And assert that the First Name column header in the second table has headerSortDown class
	When I click the First Name column header in the second table
	Then assert that the second table is ordered by First Name in descending order
	And assert that the First Name column header in the second table has headerSortUp class
	When I click the Email column header in the second table
	Then assert that the second table is ordered by Email in ascending order
	And assert that the Email column header in the second table has headerSortDown class
	When I click the Email column header in the second table
	Then assert that the second table is ordered by Email in descending order
	And assert that the Email column header in the second table has headerSortUp class
	When I click the Due column header in the second table
	Then assert that the second table is ordered numerically by Due column in ascending order
	And assert that the Due column header in the second table has headerSortDown class
	When I click the Due column header in the second table
	Then assert that the second table is ordered numerically by Due column in descending order
	And assert that the Due column header in the second table has headerSortUp class
	#When I click the Web Site column header in the first table
	#Then assert that the first table is ordered by Web Site in ascending order
	#When I click the Web Site column header in the first table
	#Then assert that the first table is ordered by Web Site in descending order