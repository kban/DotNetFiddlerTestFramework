using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace DotNetFiddlerTestFramework.Pages
{
    public class LoginPage:Page
    {
        [FindsBy(How = How.CssSelector, Using = Selectors.LOGOTYPE_IMG)]
        public IWebElement LogoImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.LOGOTYPE_LINK)]
        public IWebElement LogoLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.DROPDOWN_MENU)]
        public IWebElement DropDownMenu;

        [FindsBy(How = How.CssSelector, Using = Selectors.BACK_TO_EDITOR_BUTTON)]
        public IWebElement BackToEditorButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_USING_HEADER)]
        public IWebElement SignUpUsingHeader;

        [FindsBy(How = How.CssSelector, Using = Selectors.TWITTER_LINK)]
        public IWebElement TwitterLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.TWITTER_IMG)]
        public IWebElement TwitterImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.GMAIL_LINK)]
        public IWebElement GmailLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.GMAIL_IMG)]
        public IWebElement GmailImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.FACEBOOK_LINK)]
        public IWebElement FacebookLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.FACEBOOK_IMG)]
        public IWebElement FacebookImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.DOTNET_FIDDLE_LINK)]
        public IWebElement DotNetFiddleLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.DOTNET_FIDDLE_IMG)]
        public IWebElement DotNetFiddleImg;

        public LoginPage() : base()
        {
            PageFactory.InitElements(driver, this);
        }

        public void Open()
        {
            base.Open("https://dotnetfiddle.net/SignUp");
        }


    }
}
