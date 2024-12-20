using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.MultipleWindows;

public class MultipleWindowsPage : BasePage
{
	public MultipleWindowsPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
	: base(settings, driver, wait)
	{
	}
}
