namespace GalantisShop.Settings
{
    public class Methods
    {
        IWebDriver webDriver = new SelectWebDriver("Chrome").GetWebDriver();        
        private string galantisMainPage = "https://galantis.merchtable.com/";

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

        //Waits for elements
        public void WaitForVisibleCssSelector(string cssElement)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssElement)));
            }

            catch
            {
                throw new Exception("Element does't visible");
            }
        }

        public void WaitForClickableCssSelector(string cssElement)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(cssElement)));
            }

            catch
            {
                throw new Exception("Element does't visible");
            }
        }

        public void WaitForVisibleLinkTextSelector(string linkTextElement)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(linkTextElement)));
            }

            catch
            {
                throw new Exception("Element does't visible");
            }
        }
        //Assert name of button


        //Click on elements        
        public void ClickOnVisibleCssSelector(string cssSelector)
        {
            try
            {
                WaitForVisibleCssSelector(cssSelector);
                webDriver.FindElement(By.CssSelector(cssSelector)).Click();
            }
            catch
            {
                throw new ElementNotVisibleException("Element doesn't visible");
            }            
        }

        public void ClickOnVisibleLinkTextSelector(string linkTextElement)
        {
            try
            {
                WaitForVisibleLinkTextSelector(linkTextElement);
                webDriver.FindElement(By.LinkText(linkTextElement)).Click();
            }
            catch
            {
                throw new ElementNotVisibleException("Element doesn't visible");
            }
        }

        //Check button text names
        public void CheckButtonName(string buttonName)
        {
            string expectedButtonName = buttonName;
            string actualButtonName = buttonName;

            try
            {
                Assert.AreEqual(expectedButtonName, actualButtonName);
            }
            catch
            {
                throw new Exception("Button name doesn't match");
            }
        }

        //Kill webDriver process
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
         
        //Close webDriver
        public void CloseWebDriver()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
            }         
        }
    }
}
