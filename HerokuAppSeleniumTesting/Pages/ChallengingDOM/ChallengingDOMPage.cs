using HerokuAppSeleniumTesting.Setup;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Drawing;

namespace HerokuAppSeleniumTesting.Pages.ChallengingDOM
{
	public class ChallengingDOMPage : BasePage
	{
		public ChallengingDOMPage(AppSettings settings, IWebDriver driver, WebDriverWait wait)
			: base(settings, driver, wait)
		{
		}

		public IWebElement FirstButton => driver.FindElement(FirstButtonBy);
		public By FirstButtonBy = By.XPath("//a[@class='button']");

		public IWebElement SecondButton => driver.FindElement(SecondButtonBy);
		public By SecondButtonBy = By.XPath("//a[@class='button alert']");

		public IWebElement ThirdButton => driver.FindElement(ThirdButtonBy);
		public By ThirdButtonBy = By.XPath("//a[@class='button success']");

		public IWebElement CanvasResultText => driver.FindElement(CanvasResultTextBy);
		public By CanvasResultTextBy = By.Id("canvas");

		public void ClickFirstButton()
		{
			FirstButton.Click();
		}

		public void ClickSecondButton()
		{
			SecondButton.Click();
		}

		public void ClickThirdButton()
		{
			ThirdButton.Click();
		}

		public void GetCanvasImage(string filePath)
		{
			var canvas = CanvasResultText;
			string canvasBase64 = (string)((IJavaScriptExecutor)driver).ExecuteScript(@"
				var canvas = arguments[0];
				return canvas.toDataURL('image/png');", canvas);

			string base64String = canvasBase64.Split(',')[1]; 
			byte[] imageBytes = Convert.FromBase64String(base64String);
			File.WriteAllBytes(filePath, imageBytes);
		}

		public bool AreTwoImagesTheSame(string filePath1, string filePath2)
		{
			Bitmap image1 = new Bitmap(filePath1);
			Bitmap image2 = new Bitmap(filePath2);

			// Compare the images using pixel comparison
			double similarity = CompareImages(image1, image2);

			image1.Dispose();
			image2.Dispose();

			double threshold = 98.0; 
			if (similarity >= threshold)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static double CompareImages(Bitmap image1, Bitmap image2)
		{
			// Ensure both images have the same size for comparison
			if (image1.Width != image2.Width || image1.Height != image2.Height)
			{
				Console.WriteLine("Images have different sizes, resizing second image.");
				image2 = new Bitmap(image2, image1.Size); // Resize image2 to match image1
			}

			// Variables to count differences
			int totalPixels = image1.Width * image1.Height;
			int pixelDifferences = 0;

			// Loop through each pixel in both images and compare them
			for (int y = 0; y < image1.Height; y++)
			{
				for (int x = 0; x < image1.Width; x++)
				{
					// Get pixel color from both images
					Color color1 = image1.GetPixel(x, y);
					Color color2 = image2.GetPixel(x, y);

					// Compare the pixel colors
					if (color1 != color2)
					{
						pixelDifferences++;
					}
				}
			}

			// Calculate the percentage of similarity
			double similarity = 100.0 - ((double)pixelDifferences / totalPixels * 100);
			return similarity;
		}

	}
}
