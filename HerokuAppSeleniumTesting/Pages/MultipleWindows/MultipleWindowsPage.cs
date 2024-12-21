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

	public IWebElement ClickHereButton => driver.FindElement(ClickHereButtonBy);
	public By ClickHereButtonBy = By.XPath("//a[@target='_blank']");

	public void PressClickHereButton()
	{
		ClickHereButton.Click();
	}
}
