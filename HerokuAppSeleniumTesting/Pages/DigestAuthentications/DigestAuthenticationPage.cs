using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.DigestAuthentications;

public class DigestAuthenticationPage : BasePage
{
	public DigestAuthenticationPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
	{
	}

	public IWebElement Heading => driver.FindElement(HeadingBy);
	public By HeadingBy = By.TagName("h3");

	public void PassUsernameAndPasswordForDigestAuth(string username, string pass)
	{
		string url = "https://" + username + ":" + pass + "@" + settings.DomainSettings.Domain.Replace("https://", string.Empty) + "digest_auth";
		driver.Navigate().GoToUrl(url);
	}
}
