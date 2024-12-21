using HerokuAppSeleniumTesting.Pages.MultipleWindows;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.MultipleWindows;

public class MultipleWindowsStepDefinitions : BaseStepDefinitions
{
	private readonly MultipleWindowsPage multipleWindowsPage;

	public MultipleWindowsStepDefinitions(MultipleWindowsPage multipleWindowsPage) : base()
	{
		this.multipleWindowsPage = multipleWindowsPage;
	}

	[StepDefinition(@"I press the click here button for opening a new window")]
	public void IPressTheClickHereButtonForOpeningANewWindow()
	{
		multipleWindowsPage.PressClickHereButton();
	}
}
