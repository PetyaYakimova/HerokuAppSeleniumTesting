using HerokuAppSeleniumTesting.Pages.SortableDataTables;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.SortableDataTables;

public class SortableDataTablesStepDefinitions : BaseStepDefinitions
{
	private readonly SortableDataTablesPage sortableDataTablesPage;

	public SortableDataTablesStepDefinitions(SortableDataTablesPage sortableDataTablesPage) : base()
	{
		this.sortableDataTablesPage = sortableDataTablesPage;
	}

	[StepDefinition(@"I click the (.*) column header in the first table")]
	public void ClickTableColumnHeaderInFirstTable(string columnName)
	{
		sortableDataTablesPage.ClickTableColumnHeaderInFirstTable(columnName);
	}
}
