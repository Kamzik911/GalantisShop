namespace GalantisShop.Tests.MainPage
{
    [TestClass]
    public class SignIn
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
        public void ClickOnSignIn()
        {
            methods.ClickOnVisibleLinkTextSelector(buttonElements.mainPageSignInButton);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
