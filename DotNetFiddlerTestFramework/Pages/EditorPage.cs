using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;



namespace DotNetFiddlerTestFramework.Pages
{
    public class EditorPage:Page
    {

        [FindsBy(How = How.CssSelector, Using = Selectors.LOGOTYPE_IMG)]
        public IWebElement LogoImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.LOGOTYPE_LINK)]
        public IWebElement LogoLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.NEW_BUTTON)] 
        public IWebElement NewButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.SAVE_BUTTON)]
        public IWebElement SaveButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.FORK_BUTTON)]
        public IWebElement ForkButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.RUN_BUTTON)]
        public IWebElement RunButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.SHARE_BUTTON)]
        public IWebElement ShareButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.COLLABORATE_BUTTON)]
        public IWebElement CollaborateButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.TIDY_UP_BUTTON)]
        public IWebElement TidyUpButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.TIDY_UP_DROPDOWN)]
        public IWebElement TidyUpDropdown;

        [FindsBy(How = How.CssSelector, Using = Selectors.USERNAME_DROPDOWN)]
        public IWebElement UserNameDropdown;

        [FindsBy(How = How.CssSelector, Using = Selectors.USER_EMAIL)]
        public IWebElement UserEmail;

        [FindsBy(How = How.CssSelector, Using = Selectors.LOGIN_LINK)]
        public IWebElement LoginLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_LINK)]
        public IWebElement SignUpLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.COUNTER_FAVORITE)]
        public IWebElement CounterFavorite;

        [FindsBy(How = How.CssSelector, Using = Selectors.COUNTER_FORK)]
        public IWebElement CounterFork;

        [FindsBy(How = How.CssSelector, Using = Selectors.COUNTER_VIEW)]
        public IWebElement CounterView;

        [FindsBy(How = How.CssSelector, Using = Selectors.DROPDOWN_MENU)]
        public IWebElement DropDownMenu;

        [FindsBy(How = How.CssSelector, Using = Selectors.ACCESS_DROPDOWN)]
        public IWebElement AccessDropDown;

        [FindsBy(How = How.CssSelector, Using = Selectors.INPUT_FIELD)]
        public IWebElement InputField;

        [FindsBy(How = How.CssSelector, Using = Selectors.USER_NAME_TEXT_LABLE)]
        public IWebElement UserNameTextLable;

        [FindsBy(How = How.CssSelector, Using = Selectors.INPUT_PANE)]
        public IWebElement InputPane;

        [FindsBy(How = How.CssSelector, Using = Selectors.OUTPUT_PANE)]
        public IWebElement OutputPane;

        [FindsBy(How = How.CssSelector, Using = Selectors.STAT_PANE)]
        public IWebElement StatPane;

        [FindsBy(How = How.CssSelector, Using = Selectors.HIDE_BUTTON)]
        public IWebElement HideButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.EXPANDER_BUTTON)]
        public IWebElement ExpanderButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.PIN_BUTTON)]
        public IWebElement PinButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.DOT_NET_FRAMEWORK_VERSION)]
        public IWebElement DotNetFrameworkVersion;

        [FindsBy(How = How.CssSelector, Using = Selectors.LANGUAGE_SELECT)]
        public IWebElement LangugeSelect;

        [FindsBy(How = How.CssSelector, Using = Selectors.PROJECT_TYPE_SELECT)]
        public IWebElement ProjectTypeSelect;

        [FindsBy(How = How.CssSelector, Using = Selectors.COMPILER_SELECT)]
        public IWebElement CompilerSelect;

        [FindsBy(How = How.CssSelector, Using = Selectors.NUGET_PACKAGES_INPUT_FIELD)]
        public IWebElement NugetPackageInputField;

        [FindsBy(How = How.CssSelector, Using = Selectors.AUTORUN_YES_RADIO_BUTTON)]
        public IWebElement AutoRunYesRadioButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.AUTORUN_NO_RADIO_BUTTON)]
        public IWebElement AutoRunNoRadioButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.COPY_LINK)] //вынести селекторы в отдельное место  // public IWebElement Logo { get; set; }
        public IWebElement Copy;

        public EditorPage() : base()
        {
            PageFactory.InitElements(driver,this);
        }

        public void Open()
        {
            base.Open("https://dotnetfiddle.net/");
        }



    }
}
