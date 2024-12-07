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

	[Then(@"assert that the first table is ordered by (.*) in (.*) order")]
	public void AssertThatTheFirstTableIsOrderedByColumnInOrder(string columnName, string order)
	{
		List<string> actualValues = sortableDataTablesPage.GetAllValuesFromFirstTableInColumn(columnName);

		if (order.ToLower() == "descending")
		{
			actualValues.Reverse();
		}

		for (int i = 0; i < actualValues.Count - 1; i++)
		{
			Assert.That(actualValues[i].CompareTo(actualValues[i + 1]) <= 0);
		}
	}

	[Then(@"assert that the first table is ordered numerically by Due column in (.*) order")]
	public void AssertThatTheFirstTableIsOrderedNumericallyByDueColumnInOrder(string order)
	{
		List<double> actualValues = sortableDataTablesPage.GetAmountValuesFromDueColumnInFirstTable();

		if (order.ToLower() == "descending")
		{
			actualValues.Reverse();
		}

		for (int i = 0; i < actualValues.Count - 1; i++)
		{
			Assert.That(actualValues[i] <= actualValues[i + 1]);
		}
	}
}
