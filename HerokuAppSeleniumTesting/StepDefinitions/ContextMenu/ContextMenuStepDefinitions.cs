using HerokuAppSeleniumTesting.Pages.ContextMenu;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.ContextMenu;

public class ContextMenuStepDefinitions : BaseStepDefinitions
{
	private readonly ContextMenuPage contextMenuPage;

	public ContextMenuStepDefinitions(ContextMenuPage contextMenuPage) : base()
	{
		this.contextMenuPage = contextMenuPage;
	}

	[StepDefinition(@"I right click the hot spot box")]
	public void RightClickHotSpotBox()
	{
		contextMenuPage.RightClickHotSpotBox();
	}

	[Then(@"assert that I (.*) see the alert")]
	public void AssertThatISeeTheAlert(string expectedSee)
	{
		bool expectedSeeAsBool = GetBooleanFromString(expectedSee);
		Assert.That(contextMenuPage.IsAlertDisplayed(), Is.EqualTo(expectedSeeAsBool));
	}
}
