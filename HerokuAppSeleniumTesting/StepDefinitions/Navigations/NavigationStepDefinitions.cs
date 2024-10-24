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

		[StepDefinition(@"I open the (.*) page")]
		public void IOpenPage(string pageName)
		{
			this.basePage.OpenPage(pageName);
		}
	}
}
