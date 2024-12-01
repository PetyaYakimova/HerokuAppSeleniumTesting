Feature: DragAndDrop
Verifying drag and drop page functionalities.

@positive
Scenario: Elements can be reordered with drag and drop
	Given I open the drag and drop page
	When I drag and drop element B to element A
	Then assert that in the first column there is element B
	And assert that in the second column there is element A
	When I drag and drop element A to element B
	Then assert that in the first column there is element A
	And assert that in the second column there is element B
	When I drag and drop element A to element B
	Then assert that in the first column there is element B
	And assert that in the second column there is element A
