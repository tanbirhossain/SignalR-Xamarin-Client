using MobileClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Bind the View Model
            BindingContext = new MainPageViewModel();
        }
    }
}
//https://www.rizamarhaban.com/2017/09/30/real-time-android-ios-apps-using-signalr-core/