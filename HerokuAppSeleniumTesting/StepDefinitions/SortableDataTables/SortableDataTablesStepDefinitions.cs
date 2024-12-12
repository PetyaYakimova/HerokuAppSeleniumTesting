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

	[StepDefinition(@"I click the (.*) column header in the (.*) table")]
	public void ClickTableColumnHeaderInTable(string columnName, string table)
	{
		sortableDataTablesPage.ClickTableColumnHeaderInTable(columnName, table);
	}

	[Then(@"assert that the (.*) table is ordered by (.*) in (.*) order")]
	public void AssertThatTheTableIsOrderedByColumnInOrder(string table, string columnName, string order)
	{
		List<string> actualValues = sortableDataTablesPage.GetAllValuesFromTableInColumn(table, columnName);

		if (order.ToLower() == "descending")
		{
			actualValues.Reverse();
		}

		for (int i = 0; i < actualValues.Count - 1; i++)
		{
			Assert.That(actualValues[i].CompareTo(actualValues[i + 1]) <= 0);
		}
	}

	[Then(@"assert that the (.*) table is ordered numerically by Due column in (.*) order")]
	public void AssertThatTheTableIsOrderedNumericallyByDueColumnInOrder(string table, string order)
	{
		List<double> actualValues = sortableDataTablesPage.GetAmountValuesFromDueColumnInTable(table);

		if (order.ToLower() == "descending")
		{
			actualValues.Reverse();
		}

		for (int i = 0; i < actualValues.Count - 1; i++)
		{
			Assert.That(actualValues[i] <= actualValues[i + 1]);
		}
	}

	[Then(@"assert that the (.*) column header in the (.*) table has (.*) class")]
	public void AssertThatColumnHeaderInTableHasClass(string columnName, string table, string expectedClass)
	{
		string actualClass = sortableDataTablesPage.GetClassesFromTableHeader(columnName, table);

		Assert.That(actualClass.Contains(expectedClass));
	}
}
