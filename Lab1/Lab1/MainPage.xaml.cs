using Lab1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();
            InitializeComponent();
        }

        private void SwitchTheme_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                App.Current.Resources["PrimaryColor"] = "#550088";
                App.Current.Resources["SecondaryColor"] = "#660022";
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = "#ffffff";
                App.Current.Resources["SecondaryColor"] = "#0366d6";
            }
        }
    }
}
