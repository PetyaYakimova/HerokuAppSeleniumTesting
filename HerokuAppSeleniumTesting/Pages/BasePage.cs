using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using HerokuAppSeleniumTesting.Setup;

namespace HerokuAppSeleniumTesting.Pages
{
	public class BasePage
	{
		protected readonly AppSettings settings;
		protected readonly IWebDriver driver;
		protected readonly WebDriverWait wait;

		protected BasePage(
			AppSettings settings,
			IWebDriver driver,
			WebDriverWait wait)
		{
			this.settings = settings;
			this.driver = driver;
			this.wait = wait;
		}

		public void OpenHomePage()
		{
			driver.Navigate().GoToUrl(settings.DomainSettings.Domain);
		}

		public void OpenPage(string pageName)
		{
			driver.Navigate().GoToUrl(settings.DomainSettings.Domain + pageName);
		}

		public string GetCurrentURL()
		{
			return driver.Url;
		}
	}
}
