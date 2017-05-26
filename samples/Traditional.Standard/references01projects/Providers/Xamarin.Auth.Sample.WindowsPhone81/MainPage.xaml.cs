using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Xamarin.Auth._MobileServices.Sample.Resources;

using System.Text;

using Xamarin.Auth._MobileServices.SampleData;

namespace Xamarin.Auth._MobileServices.Sample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

            itemList.ItemsSource = null;
            itemList.ItemsSource = provider_list;

            return;
        }
    }
}