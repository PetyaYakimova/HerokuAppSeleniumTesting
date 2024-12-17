using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppSeleniumTesting.Pages.KeyPresses;

public class KeyPressesPage : BasePage
{
	private const string ResultStartText = "You entered: ";

	public KeyPressesPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
	{
	}

	public IWebElement ResultText => driver.FindElement(ResultTextBy);
	public By ResultTextBy = By.Id("result");

	public void SendKeyToThePage(string key)
	{
		Actions actions = new Actions(driver);
		actions.SendKeys(key).Perform();
	}

	public string GetValueFromResultText()
	{
		string resultText = ResultText.Text;

		return resultText.Replace(ResultStartText, string.Empty);
	}
}
