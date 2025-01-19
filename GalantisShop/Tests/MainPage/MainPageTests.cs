namespace GalantisShop.Tests.MainPage
{
    [TestClass]
    public class MainPageTests
    {
        Methods methods = new Methods();
        ButtonElements buttonElements = new ButtonElements();

        [TestInitialize]
        public void GoToMainPage()
        {
            methods.MaximizeBrowserWindow();
            methods.GoToMainPage();
        }

        [TestMethod]
        public void CloseMainPageModalWindow()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.mainPageModalWindow);
        }

        [TestMethod]
        public void ClickOnGalantisLogo()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.mainPageMainLogo);
        }

        [TestMethod]
        public void ClickOnCartShopIcon()
        {            
            methods.ClickOnVisibleCssSelector(buttonElements.mainPageCartIcon);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
