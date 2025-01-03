using System.Diagnostics;

namespace GalantisShop.Settings
{
    public class Methods
    {
        IWebDriver webDriver = new SelectWebDriver("Chrome").getWebDriver();

        string galantisMainPage = "https://galantis.merchtable.com";

        //Setup browser
        public void MaximizeBrowserWindow()
        {
            webDriver.Manage().Window.Maximize();
        }

        //Test pages
        public void GoToMainPage()
        {
            webDriver.Navigate().GoToUrl(galantisMainPage);
        }

        public void WaitForVisibleCssSelector(int defineSeconds, string cssElement)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(defineSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssElement)));
            }

            catch
            {
                throw new Exception("Element does't visible");
            }
        }

        public void ClickOnCssSelector(string cssSelector)
        {
            WaitForVisibleCssSelector(10, cssSelector);
            webDriver.FindElement(By.CssSelector(cssSelector)).Click();
        }

        public void KillWebDriverWindowsProcess()
        {
            var chromeDriverProcess = Process.GetProcessesByName("chromedriver");

            foreach (var process in chromeDriverProcess)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch (Exception e)
                {
                    throw new Exception($"Error while killing process: {e.Message}");
                }
            }
        }
        
        public void CloseWebDriver()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
            }         
        }
    }
}
