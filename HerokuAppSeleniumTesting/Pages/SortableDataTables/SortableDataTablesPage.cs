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

	public void ClickTableColumnHeaderInFirstTable(string columnName)
	{
		driver.FindElement(By.XPath($"//table[@id='table1']//th//span[text()='{columnName}']")).Click();
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
		}
		return driver.FindElements(locator).Select(e => e.Text).ToList();
	}
}
