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
}
