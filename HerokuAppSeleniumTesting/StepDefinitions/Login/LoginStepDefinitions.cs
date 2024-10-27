using HerokuAppSeleniumTesting.Pages.Login;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.Login
{
	[Binding]
	public class LoginStepDefinitions
	{
		private readonly LoginPage loginPage;

		public LoginStepDefinitions(LoginPage loginPage)
		{
			this.loginPage = loginPage;
		}

		[StepDefinition(@"I enter (.*) in the username field")]
		public void IEnterValueInTheUsernameField(string value)
		{
			loginPage.EnterUsername(value);
		}

		[StepDefinition(@"I enter (.*) in the password field")]
		public void IEnterValueInThePasswordField(string value)
		{
			loginPage.EnterPassword(value);
		}
	}
}
