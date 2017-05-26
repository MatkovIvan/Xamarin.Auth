using Xamarin.Auth;
using Xamarin.Auth._MobileServices.Presenters;

namespace Xamarin.Auth._MobileServices.Presenters.WinRT
{
    public static class AuthenticationConfiguration
    {
        public static void Init()
        {
            OAuthLoginPresenter.PlatformLogin = (authenticator) =>
            {
                var oauthLogin = new PlatformOAuthLoginPresenter();
                oauthLogin.Login(authenticator);
            };
        }
    }
}