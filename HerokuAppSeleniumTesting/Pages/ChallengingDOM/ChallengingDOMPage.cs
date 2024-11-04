using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.ChallengingDOM
{
	public class ChallengingDOMPage : BasePage
	{
		public ChallengingDOMPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
			: base(settings, driver, wait)
		{
		}
	}
}
