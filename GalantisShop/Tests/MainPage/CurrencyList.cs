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
            methods.ClickOnCssSelector(buttonElements.mainPageModalWindow);
        }

        [TestMethod]
        public void CheckCurrencyNames()
        {
            methods.ClickOnCssSelector(buttonElements.currencyDropDownButton);
            methods.CheckVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.audDropDownButton);
            methods.CheckButtonName(buttonElements.cadDropDownButton);
            methods.CheckButtonName(buttonElements.eurDropDownButton);
            methods.CheckButtonName(buttonElements.gbpDropDownButton);
            methods.CheckButtonName(buttonElements.jpyDropDownButton);
            methods.CheckButtonName(buttonElements.nzdDropDownButton);
        }

        [TestMethod]
        public void SelectCurrencies() 
        {                     
            methods.ClickOnCssSelector(buttonElements.currencyDropDownButton);
            methods.CheckVisibleCssSelector(buttonElements.currencyDropDownList);
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
