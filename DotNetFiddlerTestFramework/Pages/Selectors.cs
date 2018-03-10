using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFiddlerTestFramework.Pages
{
    public class Selectors
    {
        /// 
        /// EditorPage
        /// 
        public const string LOGOTYPE_LINK = @"a.logo.navbar-brand";//ссылка
        public const string LOGOTYPE_IMG = @"a.logo.navbar-brand>img";//картинка
        public const string NEW_BUTTON = @"button#new-button.btn.btn-default";
        //save и fork одновременно когда пользователь зарегестрирован, исчезает, когда нажимаем тайдиап
        public const string SAVE_BUTTON = @"button#save-button.btn.btn-default";
        //пользователь зарегестрирован
        public const string FORK_BUTTON = @"button#fork-button.btn.btn-default";

        public const string RUN_BUTTON = @"button#run-button.btn.btn-default";

        public const string SHARE_BUTTON = @"button#Share.btn.btn-default";
        public const string COLLABORATE_BUTTON = @"button#togetherjs.btn.btn-default";
        public const string TIDY_UP_BUTTON = @".btn-group.navbar-btn.btn-tidyup";
        public const string TIDY_UP_DROPDOWN = @"button#tidyup-extra.btn.btn-default.dropdown-toggle";

        public const string USERNAME_DROPDOWN = @".user-name.dropdown-toggle";
        public const string USER_EMAIL =@"navbar-email";
        public const string LOGIN_LINK = @"a.user-name#login-button";
        public const string SIGNUP_LINK = @"a.user-name#signup-button";

        public const string COUNTER_FAVORITE = @".counter.favorite";
        public const string COUNTER_FORK = @".counter.fork";
        public const string COUNTER_VIEW = @".counter.view";

        public const string DROPDOWN_MENU = @"div.navbar-right-container.navbar-right>
                                               div.btn-group.navbar-btn:last-child>
                                               button.btn.btn-default.dropdown-toggle"; //находится список элементов,необходим с индексом 1
        public const string ACCESS_DROPDOWN = @"button.btn.btn-default.dropdown-toggle.form-control";
        //только когда пользователь зарегистрирован
        public const string INPUT_FIELD = @"div.name-container>input";
        public const string USER_NAME_TEXT_LABLE = @"div.name-container>span";

        public const string INPUT_PANE = @".pane:first-child:not(.output-pane.pane)";
        public const string OUTPUT_PANE = @"#output.output";//@".output-pane.pane";
        public const string STAT_PANE = @".stats-pane.pane";

        public const string HIDE_BUTTON = @"button.btn.btn-default.btn-xs.btn-sidebar-toggle";
        public const string EXPANDER_BUTTON = @".expander";
        public const string PIN_BUTTON = @".btn.btn-default.btn-xs.btn-sidebar-pin";

        public const string DOT_NET_FRAMEWORK_VERSION = @".sidebar - block:nth-child(2)";
        public const string LANGUAGE_SELECT = @".sidebar - select.form - control.input - sm.togetherjs#Language";
        public const string PROJECT_TYPE_SELECT = @".sidebar-select.form-control.input-sm.togetherjs#ProjectType";
        public const string COMPILER_SELECT = @".sidebar-select.form-control.input-sm.togetherjs#Compiler";
        public const string NUGET_PACKAGES_INPUT_FIELD = @".new-package.form-control.input-sm";

        public const string AUTORUN_YES_RADIO_BUTTON = @"#IsAutoRun_Yes";
        public const string AUTORUN_NO_RADIO_BUTTON = @"#IsAutoRun_No";
        public const string COPY_LINK = @".copy > a";

        //LoginPage
        public const string BACK_TO_EDITOR_BUTTON = @"a.btn.btn-default";
        public const string SIGNUP_USING_HEADER = @"div#signup-options.row.buttons.text-center>h1";
        public const string TWITTER_LINK = @"a[href='/SignUp/Start?loginType=3']"; 
        public const string TWITTER_IMG = @"a[href='/SignUp/Start?loginType=3']>i";
        public const string GMAIL_LINK = @"a[href='/SignUp/Start?loginType=2']";
        public const string GMAIL_IMG = @"a[href = '/SignUp/Start?loginType=2']>i";
        public const string FACEBOOK_LINK = @"a[href='/SignUp/Start?loginType=1']";
        public const string FACEBOOK_IMG = @"a[href='/SignUp/Start?loginType=1']>i";
        public const string DOTNET_FIDDLE_LINK = @"a[href='/SignUp/Start?loginType=0']";
        public const string DOTNET_FIDDLE_IMG = @"a[href='/SignUp/Start?loginType=0']>img";

        ///SignupPage
        public const string SIGNUP_PAGE_HEADER = @"h4#login-modal-label.modal-title";
        public const string CLOSE_BUTTON = @"button.close:not(button#viewil-dialog-hide.close)";
        public const string SIGNUP_TWITTER_LINK= @"a[href='/Account/LogIn?loginType=3']";
        public const string SIGNUP_TWITTER_IMG = @"a[href='/Account/LogIn?loginType=3']>i";
        public const string SIGNUP_GMAIL_LINK = @"a[href='/Account/LogIn?loginType=2']";
        public const string SIGNUP_GMAIL_IMG = @"a[href='/Account/LogIn?loginType=2']>i";
        public const string SIGNUP_FACEBOOK_LINK = @"a[href='/Account/LogIn?loginType=1']";
        public const string SIGNUP_FACEBOOK_IMG = @"a[href='/Account/LogIn?loginType=1']>i";
        public const string SIGNUP_DOTNET_FIDDLE_LINK = @"a[href='https://dotnetfiddle.net/']";
        public const string SIGNUP_DOTNET_FIDDLE_IMG = @"i.dnf-icon";
        public const string SIGNUP_DOTNET_ACADEMY_LINK = @"a[href='https://dotnetcademy.net/']:not(a#academy-btn)";
        public const string SIGNUP_DOTNET_ACADEMY_IMG = @"i.dna-icon";
        public const string SIGNUP_EMAIL_INPUT_FIELD = @"input#Email.form-control";
        public const string SIGNUP_PASSWORD_INPUT_FIELD = @"input#Password.form-control";
        public const string REMEMBER_ME_CHECKBOX = @"input#RememberMe";
        public const string LOGIN_BUTTON = @"div.col-lg-5.col-md-5.col-sm-5.col-xs-5.text-right>button.btn.btn-default";
        public const string SIGN_UP_LINK = @"a[href='/SignUp']:not(a#signup-button.user-name)";
        public const string RESET_PASSWORD_LINK = @"a[href='/PasswordReset']";
    }
}
