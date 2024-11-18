using HerokuAppSeleniumTesting.Pages.ContextMenu;

namespace HerokuAppSeleniumTesting.StepDefinitions.ContextMenu;

public class ContextMenuStepDefinitions : BaseStepDefinitions
{
	private readonly ContextMenuPage contextMenuPage;

	public ContextMenuStepDefinitions(ContextMenuPage contextMenuPage) : base()
	{
		this.contextMenuPage = contextMenuPage;
	}
}
