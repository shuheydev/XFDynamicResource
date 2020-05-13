using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDynamicResource
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        static bool IsChanged = false;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                App.Current.Resources["PrimaryColor"] = Color.Red;
                App.Current.Resources["PrimaryColor2"] = "#FF0000";
            }
            else
            {
                App.Current.Resources["PrimaryColor"] = Color.Green;
                App.Current.Resources["PrimaryColor2"] = "#00FF00";
            }
            IsChanged = !IsChanged;
        }
    }
}
