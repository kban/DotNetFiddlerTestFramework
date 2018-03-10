using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace DotNetFiddlerTestFramework.Pages
{
    public class SignupPage:Page
    {
        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_PAGE_HEADER)]
        public IWebElement SignUpPageHeader;

        [FindsBy(How = How.CssSelector, Using = Selectors.CLOSE_BUTTON)]
        public IWebElement CloseButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_TWITTER_LINK)]
        public IWebElement SignUpTwitterLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_TWITTER_IMG)]
        public IWebElement SignUpTwitterImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_GMAIL_LINK)]
        public IWebElement SignUpGmailLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_GMAIL_IMG)]
        public IWebElement SignUpGmailImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_FACEBOOK_LINK)]
        public IWebElement SignUpFacebookLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_FACEBOOK_IMG)]
        public IWebElement SignUpFacebookImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_DOTNET_FIDDLE_LINK)]
        public IWebElement SignUpDotNetFiddleLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_DOTNET_FIDDLE_IMG)]
        public IWebElement SignUpDotNetFiddleImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_DOTNET_ACADEMY_LINK)]
        public IWebElement SignUpDotNetAcademyLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_DOTNET_ACADEMY_IMG)]
        public IWebElement SignUpDotNetAcademyImg;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_EMAIL_INPUT_FIELD)]
        public IWebElement SignUpEmailInputField;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGNUP_PASSWORD_INPUT_FIELD)]
        public IWebElement SignUpPasswordInputField;

        [FindsBy(How = How.CssSelector, Using = Selectors.REMEMBER_ME_CHECKBOX)]
        public IWebElement RememberMeCheckbox;

        [FindsBy(How = How.CssSelector, Using = Selectors.LOGIN_BUTTON)]
        public IWebElement LoginButton;

        [FindsBy(How = How.CssSelector, Using = Selectors.SIGN_UP_LINK)]
        public IWebElement SignUpLink;

        [FindsBy(How = How.CssSelector, Using = Selectors.RESET_PASSWORD_LINK)]
        public IWebElement ResetPasswordLink;

        public SignupPage():base()
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
