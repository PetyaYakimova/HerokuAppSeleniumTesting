using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HerokuAppSeleniumTesting.Pages.DragAndDrop
{
	public class DragAndDropPage : BasePage
	{
		public DragAndDropPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
		: base(settings, driver, wait)
		{
		}

		public IWebElement ColumnA => driver.FindElement(ColumnABy);
		public By ColumnABy = By.Id("column-a");

		public IWebElement ColumnB => driver.FindElement(ColumnBBy);
		public By ColumnBBy = By.Id("column-b");

		public void DragAndDropElementToELement(string firstElementHeading, string secondElementHeading)
		{
			IWebElement firstElement = driver.FindElement(By.XPath($"//header[text()='{firstElementHeading}']"));
			IWebElement secondElement = driver.FindElement(By.XPath($"//header[text()='{secondElementHeading}']"));

			Actions actions = new Actions(driver);
			actions.DragAndDrop(firstElement, secondElement).Build().Perform();
		}
	}
}
