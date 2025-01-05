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
            methods.ClickOnCssSelector(buttonElements.mainPageModalWindow);
        }

        [TestMethod]
        public void ClickOnGalantisLogo()
        {
            methods.ClickOnCssSelector(buttonElements.mainPageMainLogo);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
