using HerokuAppSeleniumTesting.Pages.AddRemoveElements;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.AddRemoveElements
{
	[Binding]
	public class AddRemoveElementsStepDefinitions
	{
		private readonly AddRemoveElementsPage addRemoveElementsPage;

		public AddRemoveElementsStepDefinitions(AddRemoveElementsPage addRemoveElementsPage)
		{
			this.addRemoveElementsPage = addRemoveElementsPage;
		}

		[StepDefinition(@"I click the Add element button (.*) times")]
		public void ClickTheAddElementButtonMultipleTimes(int numberOfTimes)
		{
			for (int i = 0; i < numberOfTimes; i++)
			{
				addRemoveElementsPage.ClickAddElementButton();
			}
		}

		[Then(@"assert that I see (.*) Delete element buttons")]
		public void AssertThatISeeNumberOfDeleteElementButtons(int expectedNumberOfButtons)
		{
			int actualNumberOfButtons = addRemoveElementsPage.GetNumberOfDeleteElementButtons();

			Assert.AreEqual(expectedNumberOfButtons, actualNumberOfButtons);
		}
	}
}
