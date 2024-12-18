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
		string keysToSend = key;

		switch (key.ToLower())
		{
			case "shift":
				keysToSend = Keys.Shift;
				break;
			case "enter":
				keysToSend = Keys.Enter;
				break;
			case "delete":
				keysToSend = Keys.Delete;
				break;
			case "tab":
				keysToSend = Keys.Tab;
				break;
		}

		Actions actions = new Actions(driver);
		actions.SendKeys(keysToSend).Perform();
	}

	public string GetValueFromResultText()
	{
		string resultText = ResultText.Text;

		return resultText.Replace(ResultStartText, string.Empty);
	}
}
