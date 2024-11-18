using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppSeleniumTesting.Pages.ContextMenu
{
	public class ContextMenuPage : BasePage
	{
		public ContextMenuPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
			: base(settings, driver, wait)
		{
		}
	}
}
