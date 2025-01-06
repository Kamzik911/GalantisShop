using GalantisShop.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalantisShop.Tests.MainPage
{
    [TestClass]
    public class CheckButtonNames
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
        public void CheckAudCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.audDropDownButton);            
        }

        [TestMethod]
        public void CheckCadCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.cadDropDownButton);
        }

        [TestMethod]
        public void CheckEurCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.eurDropDownButton);
        }

        [TestMethod]
        public void CheckDbpCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.gbpDropDownButton);
        }

        [TestMethod]
        public void CheckJpyCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.jpyDropDownButton);
        }

        [TestMethod]
        public void ChecknzdCurrencyName()
        {
            methods.ClickOnVisibleCssSelector(buttonElements.currencyDropDownButton);
            methods.WaitForVisibleCssSelector(buttonElements.currencyDropDownList);
            methods.CheckButtonName(buttonElements.nzdDropDownButton);
        }

        [TestCleanup]
        public void cleanAfterTest()
        {
            methods.CloseWebDriver();
            methods.KillWebDriverWindowsProcess();
        }
    }
}
