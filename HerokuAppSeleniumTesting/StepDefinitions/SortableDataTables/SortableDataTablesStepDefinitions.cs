using HerokuAppSeleniumTesting.Pages.SortableDataTables;

namespace HerokuAppSeleniumTesting.StepDefinitions.SortableDataTables;

public class SortableDataTablesStepDefinitions : BaseStepDefinitions
{
	private readonly SortableDataTablesPage sortableDataTablesPage;

	public SortableDataTablesStepDefinitions(SortableDataTablesPage sortableDataTablesPage) : base()
	{
		this.sortableDataTablesPage = sortableDataTablesPage;
	}
}
