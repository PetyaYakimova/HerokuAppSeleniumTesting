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

	[Then(@"assert that the result says that I have entered (.*)")]
	public void AssertThatTheResultSaysThatIHaveEnteredKey(string expectedKey)
	{
		string actualResult = keyPressesPage.GetValueFromResultText();

		Assert.That(actualResult, Is.EqualTo(expectedKey));
	}
}
