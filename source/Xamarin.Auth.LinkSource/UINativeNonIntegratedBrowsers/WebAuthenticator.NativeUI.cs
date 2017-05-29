using System;

using AuthenticateUIType = System.Object;

namespace Xamarin.Auth
{
    /// <summary>
    /// Web authenticator.
    /// Native login implementation[s].
    /// </summary>
    /// <see cref="https://github.com/GoogleChrome/custom-tabs-client/tree/master/demos/src/main/java/org/chromium/customtabsdemos"/>
    /// <see cref="https://developer.chrome.com/multidevice/android/customtabs"/>
#if XAMARIN_AUTH_INTERNAL
    internal partial class WebAuthenticator
#else
    public partial class WebAuthenticator
#endif
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Xamarin.Auth.WebAuthenticator"/> 
        /// is using native user interface.
        /// </summary>
        /// <value><c>true</c> if is using native user interface; otherwise, <c>false</c>.</value>
        public bool IsUsingNativeUI
        {
            get;
            set;
        }

        protected void ShowErrorForNativeUI(string v)
        {
            ShowErrorForNativeUIDebug(v);
            ShowErrorForNativeUIAlert(v);

            return;
        }

        protected void ShowErrorForNativeUIDebug(string v)
        {
            System.Diagnostics.Debug.WriteLine(v);

            return;
        }

    }
}
