namespace GalantisShop.Tests.MainPage
{
    [TestClass]
    public class CurrencyList
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
        public void SelectCurrencies() 
        {                     
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.audDropDownButton);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
