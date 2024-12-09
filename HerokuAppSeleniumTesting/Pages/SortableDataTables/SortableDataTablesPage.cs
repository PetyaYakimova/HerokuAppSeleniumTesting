using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.SortableDataTables;

public class SortableDataTablesPage : BasePage
{
	public SortableDataTablesPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
	: base(settings, driver, wait)
	{
	}

	public IWebElement FirstTable_ValueInLastNameColumn => driver.FindElement(FirstTable_ValueInLastNameColumnBy);
	public By FirstTable_ValueInLastNameColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[1]");

	public IWebElement FirstTable_ValueInFirstNameColumn => driver.FindElement(FirstTable_ValueInFirstNameColumnBy);
	public By FirstTable_ValueInFirstNameColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[2]");

	public IWebElement FirstTable_ValueInEmailColumn => driver.FindElement(FirstTable_ValueInEmailColumnBy);
	public By FirstTable_ValueInEmailColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[3]");

	public IWebElement FirstTable_ValueInDueColumn => driver.FindElement(FirstTable_ValueInDueColumnBy);
	public By FirstTable_ValueInDueColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[4]");

	public IWebElement FirstTable_ValueInWebSiteColumn => driver.FindElement(FirstTable_ValueInWebSiteColumnBy);
	public By FirstTable_ValueInWebSiteColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[5]");

	public void ClickTableColumnHeaderInTable(string columnName, string table)
	{
		int tableNumber = 1;
		if (table.ToLower() == "second")
		{
			tableNumber = 2;
		}

		driver.FindElement(By.XPath($"//table[@id='table{tableNumber}']//th//span[text()='{columnName}']")).Click();
	}

	public List<string> GetAllValuesFromFirstTableInColumn(string columnName)
	{
		By? locator = null;
		switch (columnName)
		{
			case "Last Name":
				locator = FirstTable_ValueInLastNameColumnBy;
				break;
			case "First Name":
				locator = FirstTable_ValueInFirstNameColumnBy;
				break;
			case "Email":
				locator = FirstTable_ValueInEmailColumnBy;
				break;
			case "Web Site":
				locator = FirstTable_ValueInWebSiteColumnBy;
				break;
		}
		return driver.FindElements(locator).Select(e => e.Text).ToList();
	}

	public List<double> GetAmountValuesFromDueColumnInFirstTable()
	{
		return driver.FindElements(FirstTable_ValueInDueColumnBy).Select(e => double.Parse(e.Text.Replace("$", string.Empty))).ToList();
	}
}
