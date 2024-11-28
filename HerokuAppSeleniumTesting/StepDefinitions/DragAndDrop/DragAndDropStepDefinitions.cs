using HerokuAppSeleniumTesting.Pages.DragAndDrop;

namespace HerokuAppSeleniumTesting.StepDefinitions.DragAndDrop
{
	public class DragAndDropStepDefinitions : BaseStepDefinitions
	{
		private readonly DragAndDropPage dragAndDropPage;

		public DragAndDropStepDefinitions(DragAndDropPage dragAndDropPage) : base()
		{
			this.dragAndDropPage = dragAndDropPage;
		}
	}
}
