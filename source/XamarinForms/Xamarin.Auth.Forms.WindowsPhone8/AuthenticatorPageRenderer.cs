using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly:
    ExportRenderer
        (
            typeof(Xamarin.Auth._MobileServices.XamarinForms.AuthenticatorPage),
            typeof(Xamarin.Auth._MobileServices.XamarinForms.WindowsPhone8.AuthenticatorPageRenderer)
        )
]
namespace Xamarin.Auth._MobileServices.XamarinForms.WindowsPhone8
{
    public class AuthenticatorPageRenderer : Xamarin.Forms.Platform.WinPhone.PageRenderer
    {
        protected Xamarin.Auth._MobileServices.Authenticator Authenticator = null;
        protected Xamarin.Auth._MobileServices.XamarinForms.AuthenticatorPage authenticator_page = null;

        protected override async void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            try
            {
                base.OnElementChanged(e);

                System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer.OnElementChanged");

                if (e == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e = {null}");
                else
                {
                    if (e.NewElement == null)
                        System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e.NewElement = {null}");
                    if (e.OldElement == null)
                        System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e.OldElement = {null}");
                }

                if (Element == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Element is {null}");
                else
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Element is " + Element);

                if (Control == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Control is {null}");
                else
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Control is " + Control);

                if (Control == null)
                {
                    authenticator_page = (AuthenticatorPage)base.Element;
   
                    Authenticator.Completed -= Authenticator_Completed;
                    Authenticator.Completed += Authenticator_Completed;
                    Authenticator.Error -= Authenticator_Error;
                    Authenticator.Error += Authenticator_Error;

                    Uri page_uri = Authenticator.GetUI();
                    Microsoft.Phone.Controls.PhoneApplicationPage this_page = null;
                    this_page.NavigationService.Navigate(page_uri);
                }
            }
            catch (Exception ex)
            {
                throw new Xamarin.Auth._MobileServices.AuthException("WindowsPhone OnElementChanged");
            }

            return;
        }


        private async void Authenticator_Error(object sender, AuthenticatorErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WindowsPhone Authenticator_Error");

            return;
        }

        private async void Authenticator_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WindowsPhone Authenticator_Completed");
        }

    }
}

