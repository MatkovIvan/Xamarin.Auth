﻿using System;
using Xamarin.Auth._MobileServices.Helpers;

namespace Xamarin.Auth._MobileServices.SampleData
{
	public partial class GithubOAuth2HttpsXamarinCom : Xamarin.Auth._MobileServices.Helpers.OAuth2
	{
		partial void SetPublicNonSensitiveData();
		partial void SetPrivateSensitiveData();

		public GithubOAuth2HttpsXamarinCom()
		{
			SetPublicNonSensitiveData();
			SetPrivateSensitiveData();

			return;
		}

		partial void SetPublicNonSensitiveData()
		{
			HowToMarkDown = 
@"
https://github.com/settings/applications
https://developer.github.com/v3/oauth/#scopes
https://github.com/settings/developers
";
			Description = "Github OAuth2 https://xamarin.com";
			OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer = "";
			OAuth2_Scope = ""; // "", "user",
			OAuth_UriAuthorization = new Uri("https://github.com/login/oauth/authorize");
            OAuth_UriAccessToken_UriRequestToken = new Uri("https://github.com/login/oauth/access_token");
			OAuth_UriCallbackAKARedirect = new Uri("https://xamarin.com");
			AllowCancel = true;

			return;
		}
	}
}

