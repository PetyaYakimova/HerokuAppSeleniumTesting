using HerokuAppSeleniumTesting.Pages.DigestAuthentications;

namespace HerokuAppSeleniumTesting.StepDefinitions.DigestAuthentication
{
	public class DigestAuthenticationStepDefinitions : BaseStepDefinitions
	{
		private readonly DigestAuthenticationPage digestAuthenticationPage;

		public DigestAuthenticationStepDefinitions(DigestAuthenticationPage digestAuthenticationPage) : base()
		{
			this.digestAuthenticationPage = digestAuthenticationPage;
		}
	}
}
