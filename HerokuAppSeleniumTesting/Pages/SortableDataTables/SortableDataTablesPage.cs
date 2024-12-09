﻿using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace HerokuAppSeleniumTesting.Pages.SortableDataTables;

public class SortableDataTablesPage : BasePage
{
	public SortableDataTablesPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
	: base(settings, driver, wait)
	{
	}

	public IWebElement FirstTable_ValueInDueColumn => driver.FindElement(FirstTable_ValueInDueColumnBy);
	public By FirstTable_ValueInDueColumnBy = By.XPath("//table[@id='table1']//tbody//tr//td[4]");


	public void ClickTableColumnHeaderInTable(string columnName, string table)
	{
		int tableNumber = GetTableIdFromName(table);

		driver.FindElement(By.XPath($"//table[@id='table{tableNumber}']//th//span[text()='{columnName}']")).Click();
	}

	public List<string> GetAllValuesFromTableInColumn(string table, string columnName)
	{
		int tableNumber = GetTableIdFromName(table);
		int columnNumber = 0;

		switch (columnName)
		{
			case "Last Name":
				columnNumber = 1;
				break;
			case "First Name":
				columnNumber = 2;
				break;
			case "Email":
				columnNumber = 3;
				break;
			case "Web Site":
				columnNumber = 5;
				break;
		}

		return driver.FindElements(By.XPath($"//table[@id='table{tableNumber}']//tbody//tr//td[{columnNumber}]")).Select(e => e.Text).ToList();
	}

	public List<double> GetAmountValuesFromDueColumnInFirstTable()
	{
		return driver.FindElements(FirstTable_ValueInDueColumnBy).Select(e => double.Parse(e.Text.Replace("$", string.Empty))).ToList();
	}

	private int GetTableIdFromName(string name)
	{
		int tableNumber = 1;
		if (name.ToLower() == "second")
		{
			tableNumber = 2;
		}

		return tableNumber;
	}
}
