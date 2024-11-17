using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HerokuAppSeleniumTesting.Pages.Checkboxes
{
	public class CheckboxesPage : BasePage
	{
		public CheckboxesPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
			: base(settings, driver, wait)
		{
		}

		public IWebElement FirstCheckbox => driver.FindElement(FirstCheckboxBy);
		public By FirstCheckboxBy = By.XPath("//form[@id='checkboxes']//input[1]");

		public IWebElement SecondCheckbox => driver.FindElement(SecondCheckboxBy);
		public By SecondCheckboxBy = By.XPath("//form[@id='checkboxes']//input[2]");

		public bool IsCheckboxChecked(IWebElement checkbox)
		{
			return checkbox.GetAttribute("checked") == "true";
		}

		public void ClickFirstCheckbox()
		{
			FirstCheckbox.Click();
		}

		public void ClickSecondCheckbox()
		{
			SecondCheckbox.Click();
		}
	}
}
