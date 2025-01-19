namespace GalantisShop.Settings
{
    public class ButtonElements
    {
        //Main page buttons
        public string mainPageModalWindow = "button[class='mc-closeModal']";
        public string mainPageMainLogo = ".header-logo-container";
        public string mainPageSearchIcon = "i[class='fas fa-search']:nth-of-type(1)";
        public string mainPageSearchField = "input[class='search form-control']";
        public string mainPageCartIcon = "div[class='cart-wrapper header-item']";
        public string mainPageSignInButton = "//a[text()='Sign in']"; //"Sign in";

        //Main page currenty buttons
        public string currencyDropDownButton = "button[class='btn dropdown-toggle dropdown-toggle-split']";
        public string currencyDropDownList = "div[class='dropdown-menu show']";
        public string audDropDownButton = "aud";
        public string cadDropDownButton = "cad";
        public string eurDropDownButton = "eur";
        public string gbpDropDownButton = "gbp";
        public string jpyDropDownButton = "jpy";
        public string nzdDropDownButton = "nzd";
    }
}
