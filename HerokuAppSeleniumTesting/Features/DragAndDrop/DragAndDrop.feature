Feature: DragAndDrop
Verifying drag and drop page functionalities.

@positive
Scenario: Elements can be reordered with drag and drop
	Given I open the drag and drop page
	When I drag and drop element B to element A
