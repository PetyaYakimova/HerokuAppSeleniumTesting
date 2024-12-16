using HerokuAppSeleniumTesting.Pages.KeyPresses;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.KeyPresses;

public class KeyPressesStepDefinitions : BaseStepDefinitions
{
	private readonly KeyPressesPage keyPressesPage;

	public KeyPressesStepDefinitions(KeyPressesPage keyPressesPage) : base()
	{
		this.keyPressesPage = keyPressesPage;
	}

	[StepDefinition(@"I send (.*) key to the page")]
	public void ISendKeyToThePage(string key)
	{
		keyPressesPage.SendKeyToThePage(key);
	}
}
