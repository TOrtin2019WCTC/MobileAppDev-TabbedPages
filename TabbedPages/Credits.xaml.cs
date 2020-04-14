using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPages
{
    public partial class Credits : ContentPage
    {
        public Credits()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new TermsOfUse());
        }


    }
}
