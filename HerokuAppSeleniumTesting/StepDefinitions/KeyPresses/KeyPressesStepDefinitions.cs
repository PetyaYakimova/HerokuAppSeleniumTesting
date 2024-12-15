using HerokuAppSeleniumTesting.Pages.KeyPresses;

namespace HerokuAppSeleniumTesting.StepDefinitions.KeyPresses;

public class KeyPressesStepDefinitions : BaseStepDefinitions
{
	private readonly KeyPressesPage keyPressesPage;

	public KeyPressesStepDefinitions(KeyPressesPage keyPressesPage) : base()
	{
		this.keyPressesPage = keyPressesPage;
	}
}
