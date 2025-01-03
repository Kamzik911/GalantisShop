namespace GalantisShop.Settings
{
    public class SelectWebDriver
    {
        private IWebDriver? webDriver;

        public SelectWebDriver(string selectWebDriver)
        {
            if (selectWebDriver == "Chrome")
            {
                webDriver = new ChromeDriver();
            }
            else if (selectWebDriver == "Firefox")
            {
                webDriver = new FirefoxDriver();
            }
            else if (selectWebDriver == "Edge")
            {
                webDriver = new EdgeDriver();
            }

        }

        public IWebDriver getWebDriver()
        {
            if (webDriver == null)
            {
                throw new Exception("Web driver doesn't initialize");
            }
            return webDriver;
        }
    }
}
