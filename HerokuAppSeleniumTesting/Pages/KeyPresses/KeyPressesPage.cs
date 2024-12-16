using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppSeleniumTesting.Pages.KeyPresses;

public class KeyPressesPage : BasePage
{
	public KeyPressesPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
	{
	}

	public void SendKeyToThePage(string key)
	{
		Actions actions = new Actions(driver);
		actions.SendKeys(key).Perform();
	}
}
