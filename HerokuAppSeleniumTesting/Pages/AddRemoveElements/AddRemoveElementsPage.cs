using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.AddRemoveElements;

public class AddRemoveElementsPage : BasePage
{
	public AddRemoveElementsPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
	{
	}

	public IWebElement AddElementButton => driver.FindElement(AddElementButtonBy);
	public By AddElementButtonBy = By.XPath("//button[@onclick='addElement()']");

	public IWebElement DeleteElementButton => driver.FindElement(DeleteElementButtonBy);
	public By DeleteElementButtonBy = By.XPath("//button[@onclick='deleteElement()']");

	public void ClickAddElementButton()
	{
		AddElementButton.Click();
	}

	public int GetNumberOfDeleteElementButtons()
	{
		return driver.FindElements(DeleteElementButtonBy).Count();
	}

	public void ClickDeleteElementButton()
	{
		DeleteElementButton.Click();
	}
}
