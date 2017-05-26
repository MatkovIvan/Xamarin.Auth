using Xamarin.Auth;
using Xamarin.Auth._MobileServices.Presenters;

namespace Xamarin.Auth._MobileServices
{
	public static class Auth
	{
        internal static System.Windows.Controls.Page Page { get; set; }

        public static void Init(System.Windows.Controls.Page page)
        {
            Auth.Page = page;

            OAuthLoginPresenter.PlatformLogin = (authenticator) => {
				var oauthLogin = new PlatformOAuthLoginPresenter ();
				oauthLogin.Login (authenticator);
			};
		}
	}
}