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
			basePage.OpenPage(pageName);
		}

		[Then(@"assert that I am on a page with (.*) action")]
		public void AssertThatIAmOnAPageWithAction(string action)
		{
			Assert.IsTrue(basePage.GetCurrentURL().EndsWith(action));
		}
	}
}
