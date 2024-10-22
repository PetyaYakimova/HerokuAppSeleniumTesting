namespace HerokuAppSeleniumTesting.Setup
{
	public class AppSettings
	{
		public DomainSettings DomainSettings { get; set; } = null!;
	}

	public class DomainSettings
	{
		public string Domain { get; set; } = null!;
	}
}
