using HerokuAppSeleniumTesting.Pages.MultipleWindows;

namespace HerokuAppSeleniumTesting.StepDefinitions.MultipleWindows;

public class MultipleWindowsStepDefinitions : BaseStepDefinitions
{
	private readonly MultipleWindowsPage multipleWindowsPage;

	public MultipleWindowsStepDefinitions(MultipleWindowsPage multipleWindowsPage) : base()
	{
		this.multipleWindowsPage = multipleWindowsPage;
	}
}
