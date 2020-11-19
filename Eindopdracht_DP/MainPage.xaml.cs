using Eindopdracht_DP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Eindopdracht_DP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (VersionTracking.IsFirstLaunchEver)
            {
                Navigation.PushModalAsync(new OnboardingPage());
            }
        }
    }
}
