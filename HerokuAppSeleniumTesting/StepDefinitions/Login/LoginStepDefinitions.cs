using HerokuAppSeleniumTesting.Pages.Login;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.Login
{
	public class LoginStepDefinitions : BaseStepDefinitions
	{
		private readonly LoginPage loginPage;

		public LoginStepDefinitions(LoginPage loginPage) : base()
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

		[Then(@"assert that I see the logged in message")]
		public void AssertThatISeeTheLoggedInMessage()
		{
			Assert.IsTrue(loginPage.FlashMessage.Displayed);
			Assert.That(loginPage.FlashMessage.Text.Contains(loginPage.LooggedInSuccessfullMessage));
		}

		[Then(@"assert that I see the logout button")]
		public void AsserrtThatISeeTheLogoutButton()
		{
			Assert.IsTrue(loginPage.LogoutButton.Displayed);
		}

		[Then(@"assert that I see the invalid (.*) message")]
		public void AssertThatISeeTheUnsuccessfulLoginMessage(string invalidCredential)
		{
			Assert.IsTrue(loginPage.FlashMessage.Displayed);
			Assert.That(loginPage.FlashMessage.Text.Contains(invalidCredential));
			Assert.That(loginPage.FlashMessage.Text.Contains("invalid"));
		}
	}
}
