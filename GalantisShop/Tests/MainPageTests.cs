using GalantisShop.Settings;

namespace GalantisShop.Tests
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

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();            
        }
    }
}
