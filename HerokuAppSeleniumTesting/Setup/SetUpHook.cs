using BoDi;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;

namespace HerokuAppSeleniumTesting.Setup;

[Binding]
public class SetUpHook
{
	private readonly IConfigurationRoot configuration;
	private WebDriverWait wait;
	private readonly AppSettings settings;

	public SetUpHook(IObjectContainer objectContainer)
	{
		configuration = BuildConfiguration();
		settings = configuration.Get<AppSettings>();
		objectContainer.RegisterInstanceAs(this.settings);
	}

	[BeforeScenario]
	public void Setup(IObjectContainer objectContainer, ScenarioContext scenarioContext)
	{
		//IWebDriver driver = this.GetDriver("chrome");
		IWebDriver driver = this.GetDriver("firefox");

		driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

		this.wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
		objectContainer.RegisterInstanceAs(driver);
		objectContainer.RegisterInstanceAs(wait);
	}

	[AfterScenario]
	public void TearDown(IObjectContainer objectContainer)
	{
		IWebDriver driver = objectContainer.Resolve<IWebDriver>();
		driver.Quit();
	}

	private static IConfigurationRoot BuildConfiguration()
	{
		ConfigurationBuilder builder = new();

#if DEBUG
		builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.Debug.json"), optional: false, reloadOnChange: false);
#endif

		return builder.Build();
	}

	private IWebDriver GetDriver(string browserName)
	{
		switch (browserName.ToLower())
		{
			case "chrome":
				ChromeOptions options = new ChromeOptions();
				//options.AddArgument("--headless");
				options.AddArgument("--enable-automation");
				options.AddArgument("--start-maximized");
				options.PageLoadStrategy = PageLoadStrategy.Normal;
				IWebDriver driver = new ChromeDriver(".", options);

				return driver;

			case "firefox":
				FirefoxOptions firefoxOptions = new FirefoxOptions();
				//firefoxOptions.AddArgument("--headless");
				firefoxOptions.AddArgument("--enable-automation");
				firefoxOptions.AddArgument("--start-maximized");
				firefoxOptions.PageLoadStrategy = PageLoadStrategy.Normal;
				IWebDriver firefoxDriver = new FirefoxDriver(".", firefoxOptions);

				return firefoxDriver;

			default:
				throw new ArgumentException($"Browser {browserName} is not supported.");
		}
	}

	private string GetBrowserFromTags(ScenarioContext scenarioContext)
	{
		// Look for browser tags in the scenario's tags
		var browserTag = scenarioContext.ScenarioInfo.Tags
							.FirstOrDefault(tag => tag.Equals("chrome", StringComparison.OrdinalIgnoreCase) ||
												   tag.Equals("firefox", StringComparison.OrdinalIgnoreCase));

		// Default to Chrome if no browser tag is found
		return browserTag ?? "chrome";
	}
}
