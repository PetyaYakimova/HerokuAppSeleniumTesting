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

	public void ClickTableColumnHeaderInFirstTable(string columnName)
	{
		driver.FindElement(By.XPath($"//table[@id='table1']//th//span[text()='{columnName}']")).Click();
	}
}
