using HerokuAppSeleniumTesting.Pages;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.Navigations
{
	[Binding]
	public class NavigationStepDefinitions
	{
		private readonly BasePage basePage;

		public NavigationStepDefinitions(BasePage basePage)
		{
			this.basePage = basePage;
		}
	}
}
