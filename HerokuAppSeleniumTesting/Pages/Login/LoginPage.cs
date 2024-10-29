using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.Login
{
	public class LoginPage : BasePage
	{
		public string LooggedInSuccessfullMessage = "You logged into a secure area!";

		public LoginPage(AppSettings settings, IWebDriver driver, WebDriverWait wait) 
			: base(settings, driver, wait)
		{
		}

		public IWebElement UsernameInputField => driver.FindElement(UsernameInputFieldBy);
		public By UsernameInputFieldBy = By.Id("username");

		public IWebElement PasswordInputField => driver.FindElement(PasswordInputFieldBy);
		public By PasswordInputFieldBy = By.Id("password");

		public IWebElement LoginButton => driver.FindElement(LoginButtonBy);
		public By LoginButtonBy = By.XPath("//form[@id='login']//button[@type='submit']");

		public IWebElement FlashMessage => driver.FindElement(FlashMessageBy);
		public By FlashMessageBy = By.Id("flash");

		public IWebElement LogoutButton => driver.FindElement(LogoutButtonBy);
		public By LogoutButtonBy = By.XPath("//a[contains(@href, 'logout')]");

		public void EnterUsername(string username)
		{
			UsernameInputField.SendKeys(username);
		}

		public void EnterPassword(string password)
		{
			PasswordInputField.SendKeys(password);
		}

		public void ClickLoginButton()
		{
			LoginButton.Click();
		}
	}
}
