using HerokuAppSeleniumTesting.Pages.Checkboxes;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.Checkboxes
{
	[Binding]
	public class CheckboxesStepDefinitions
	{
		private readonly CheckboxesPage checkboxesPage;

		public CheckboxesStepDefinitions(CheckboxesPage checkboxesPage)
		{
			this.checkboxesPage = checkboxesPage;
		}
	}
}
