using HerokuAppSeleniumTesting.Pages.DigestAuthentications;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.DigestAuthentication;

public class DigestAuthenticationStepDefinitions : BaseStepDefinitions
{
	private readonly DigestAuthenticationPage digestAuthenticationPage;

	public DigestAuthenticationStepDefinitions(DigestAuthenticationPage digestAuthenticationPage) : base()
	{
		this.digestAuthenticationPage = digestAuthenticationPage;
	}

	[StepDefinition(@"I pass username (.*) and password (.*) for the digest authentication")]
	public void PassUsernameAndPasswordForTheDigestAuthentication(string username, string password)
	{
		digestAuthenticationPage.PassUsernameAndPasswordForDigestAuth(username, password);
	}

	[Then(@"assert that I see the digest authentication page heading")]
	public void AssertThatISeeTheDigestAuthenticationPageHeading()
	{
		Assert.IsTrue(digestAuthenticationPage.Heading.Displayed);
	}
}
