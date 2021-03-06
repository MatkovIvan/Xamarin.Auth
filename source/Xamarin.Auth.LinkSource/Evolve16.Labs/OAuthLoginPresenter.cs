﻿using System;

namespace Xamarin.Auth._MobileServices.Presenters
{
#if XAMARIN_AUTH_INTERNAL
    internal class OAuthLoginPresenter
#else
    public class OAuthLoginPresenter
#endif
    {
        public event EventHandler<AuthenticatorCompletedEventArgs> Completed;

        public static Action<Authenticator> PlatformLogin;

        public void Login(Authenticator authenticator)
        {
            authenticator.Completed += OnAuthCompleted;

            PlatformLogin(authenticator);
        }

        void OnAuthCompleted(object sender, global::Xamarin.Auth._MobileServices.AuthenticatorCompletedEventArgs e)
        {
            if (Completed != null)
            {
                Completed(sender, e);
            }

            ((Authenticator)sender).Completed -= OnAuthCompleted;
        }
    }
}