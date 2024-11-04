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

		public IWebElement FirstButton => driver.FindElement(FirstButtonBy);
		public By FirstButtonBy = By.XPath("//a[@class='button']");

		public IWebElement SecondButton => driver.FindElement(SecondButtonBy);
		public By SecondButtonBy = By.XPath("//a[@class='button alert']");

		public IWebElement ThirdButton => driver.FindElement(ThirdButtonBy);
		public By ThirdButtonBy = By.XPath("//a[@class='button success']");

		public IWebElement CanvasResultText => driver.FindElement(CanvasResultTextBy);
		public By CanvasResultTextBy = By.Id("canvas");
	}
}
