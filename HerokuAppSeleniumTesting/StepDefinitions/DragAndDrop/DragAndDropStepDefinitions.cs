using HerokuAppSeleniumTesting.Pages.DragAndDrop;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.DragAndDrop
{
	public class DragAndDropStepDefinitions : BaseStepDefinitions
	{
		private readonly DragAndDropPage dragAndDropPage;

		public DragAndDropStepDefinitions(DragAndDropPage dragAndDropPage) : base()
		{
			this.dragAndDropPage = dragAndDropPage;
		}

		[StepDefinition(@"I drag and drop element (.*) to element (.*)")]
		public void DragAndDropElementToElement(string firstElementHeading, string secondElementHeading)
		{
			dragAndDropPage.DragAndDropElementToELement(firstElementHeading, secondElementHeading);
		}
	}
}
