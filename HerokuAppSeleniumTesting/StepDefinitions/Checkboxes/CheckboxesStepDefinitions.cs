using HerokuAppSeleniumTesting.Pages.Checkboxes;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.StepDefinitions.Checkboxes
{
	public class CheckboxesStepDefinitions : BaseStepDefinitions
	{
		private readonly CheckboxesPage checkboxesPage;

		public CheckboxesStepDefinitions(CheckboxesPage checkboxesPage) : base()
		{
			this.checkboxesPage = checkboxesPage;
		}

		[Then(@"assert that the first checkbox (.*) checked")]
		public void AssertThatTheFirstCheckboxChecked(string expectedCheckedString)
		{
			bool expectedChecked = GetBooleanFromString(expectedCheckedString);
			Assert.That(checkboxesPage.IsCheckboxChecked(checkboxesPage.FirstCheckbox), Is.EqualTo(expectedChecked));
		}

		[Then(@"assert that the second checkbox (.*) checked")]
		public void AssertThatTheSecondCheckboxChecked(string expectedCheckedString)
		{
			bool expectedChecked = GetBooleanFromString(expectedCheckedString);
			Assert.That(checkboxesPage.IsCheckboxChecked(checkboxesPage.SecondCheckbox), Is.EqualTo(expectedChecked));
		}
	}
}
