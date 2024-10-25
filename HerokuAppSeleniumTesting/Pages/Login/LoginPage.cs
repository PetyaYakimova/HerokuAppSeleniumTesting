﻿using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace HerokuAppSeleniumTesting.Pages.Login
{
	public class LoginPage : BasePage
	{
		public LoginPage(AppSettings settings, IWebDriver driver, WebDriverWait wait) : base(settings, driver, wait)
		{
		}

		public IWebElement UsernameInputField => driver.FindElement(UsernameInputFieldBy);
		public By UsernameInputFieldBy = By.Id("username");

		public IWebElement PasswordInputField => driver.FindElement(PasswordInputFieldBy);
		public By PasswordInputFieldBy = By.Id("password");

		public IWebElement LoginButton => driver.FindElement(LoginButtonBy);
		public By LoginButtonBy = By.XPath("//form[@id='login']//button[@type='submit']");

		public IWebElement ErrorMessage => driver.FindElement(ErrorMessageBy);
		public By ErrorMessageBy = By.Id("flash");
	}
}
