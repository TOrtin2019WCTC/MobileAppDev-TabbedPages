using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPages
{
    public partial class TermsOfUse : ContentPage
    {
        public TermsOfUse()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(false);
        }
    }
}
