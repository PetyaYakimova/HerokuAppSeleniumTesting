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

	public void ClickTableColumnHeaderInFirstTable(string columnName)
	{
		driver.FindElement(By.XPath($"//table[@id='table1']//th//span[text()='{columnName}']")).Click();
	}

	public List<string> GetAllValuesFromTableInLastNameColumn()
	{
		return driver.FindElements(FirstTable_ValueInLastNameColumnBy).Select(e => e.Text).ToList();
	}
}
