namespace GalantisShop.Tests.MainPage
{
    [TestClass]
    public class SearchField
    {
        Methods methods = new Methods();
        ButtonElements buttonElements = new ButtonElements();

        [TestInitialize]
        public void GoToMainPage()
        {
            methods.MaximizeBrowserWindow();
            methods.GoToMainPage();
            methods.ClickOnVisibleCssSelector(buttonElements.mainPageModalWindow);
        }

        [TestMethod]
        public void ClickOnSearchIcon()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.mainPageSearchIcon);
            methods.WaitForVisibleCssSelector(buttonElements.mainPageSearchField);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
