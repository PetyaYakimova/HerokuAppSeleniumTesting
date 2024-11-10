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

		[StepDefinition(@"I get the canvas image")]
		public void IGetTheCanvasImage()
		{
			challengindDOMPage.GetCanvasImage(GlobalConstants.ImageBeforeFilePath);
		}

		[StepDefinition(@"I click the first button on the challending DOM page")]
		public void IClickTheFirstButtonOnTheChallengingDOMpage()
		{
			challengindDOMPage.ClickFirstButton();
		}

		[StepDefinition(@"I click the second button on the challending DOM page")]
		public void IClickTheSecondButtonOnTheChallengingDOMpage()
		{
			challengindDOMPage.ClickSecondButton();
		}

		[StepDefinition(@"I click the third button on the challending DOM page")]
		public void IClickTheThirdButtonOnTheChallengingDOMpage()
		{
			challengindDOMPage.ClickThirdButton();
		}

		[Then(@"assert that the canvas image has changed")]
		public void AssertThatTheCanvasImageHasChanged()
		{
			challengindDOMPage.GetCanvasImage(GlobalConstants.ImageAfterFilePath);
			Assert.IsFalse(challengindDOMPage.AreTwoImagesTheSame(GlobalConstants.ImageBeforeFilePath, GlobalConstants.ImageAfterFilePath));

			//Save the new image as the before image
			challengindDOMPage.GetCanvasImage(GlobalConstants.ImageBeforeFilePath);
		}
	}
}
