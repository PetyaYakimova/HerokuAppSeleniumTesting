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
		public void EnterValueInTheUsernameField(string value)
		{
			loginPage.EnterUsername(value);
		}

		[StepDefinition(@"I enter (.*) in the password field")]
		public void EnterValueInThePasswordField(string value)
		{
			loginPage.EnterPassword(value);
		}

		[StepDefinition(@"I click the Login button")]
		public void ClickTheLoginButton()
		{
			loginPage.ClickLoginButton();
		}
	}
}
