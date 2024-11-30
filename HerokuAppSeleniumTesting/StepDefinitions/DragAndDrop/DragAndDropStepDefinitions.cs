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

		[Then(@"assert that in the first column there is element (.*)")]
		public void AssertThatInTheFirstColumnThereIsElement(string expectedElement)
		{
			string actualElement = dragAndDropPage.GetTextInFirstColumn();

			Assert.That(actualElement, Is.EqualTo(expectedElement));
		}

		[Then(@"assert that in the second column there is element (.*)")]
		public void AssertThatInTheSecondColumnThereIsElement(string expectedElement)
		{
			string actualElement = dragAndDropPage.GetTextInSecondColumn();

			Assert.That(actualElement, Is.EqualTo(expectedElement));
		}
	}
}
