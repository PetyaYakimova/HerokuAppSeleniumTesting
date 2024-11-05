using HerokuAppSeleniumTesting.Pages.ChallengingDOM;
using HerokuAppSeleniumTesting.Setup;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.ChallengingDOM
{
	[Binding]
	public class ChallengingDOMStepDefinitions
	{
		private readonly ChallengingDOMPage challengindDOMPage;

		public ChallengingDOMStepDefinitions(ChallengingDOMPage challengindDOMPage)
		{
			this.challengindDOMPage = challengindDOMPage;
		}

		[StepDefinition(@"I get the canvas answer text")]
		public void IGetTheCanvasAnswerText()
		{
			Variables.canvasAnswerText = challengindDOMPage.GetCanvasAnswerText();
		}
	}
}
