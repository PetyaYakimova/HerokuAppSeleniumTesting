using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppSeleniumTesting.Pages.ContextMenu;

public class ContextMenuPage : BasePage
{
	public ContextMenuPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
	{
	}

	public IWebElement HotSpotBox => driver.FindElement(HotSpotBoxBy);
	public By HotSpotBoxBy = By.Id("hot-spot");

	public void RightClickHotSpotBox()
	{
		Actions actions = new Actions(driver);
		actions.ContextClick(HotSpotBox).Perform();
	}
}
