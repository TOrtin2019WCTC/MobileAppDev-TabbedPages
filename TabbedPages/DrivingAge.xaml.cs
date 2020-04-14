using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPages
{
    public partial class DrivingAge : ContentPage
    {
        public DrivingAge()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Result.IsVisible = true;
            
            Enter_Age.IsVisible = false;
            Submit.IsVisible = false;

            int age = Int32.Parse(Enter_Age.Text);

            if (age >= 16)
            {
                Result.Text = $"You Have been able to drive for {(age - 16).ToString()} years";
            }
            else
            {
                Result.Text = "You should not be driving";
            }

        }
    }
}
