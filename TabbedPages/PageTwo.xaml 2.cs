using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPages
{
    public partial class PageTwo : ContentPage
    {
        public string YearBorn;
        public int YearsAbleToDrive;
        public PageTwo()
        {
            InitializeComponent();
            //YearBorn = string.Empty;
            //YearsAbleToDrive = 0;
        }

        //    void Button_Clicked(System.Object sender, System.EventArgs e)
        //    {
        //        Year.IsVisible = false;
        //        YearBorn = Year.Text;

        //        Int32.TryParse(YearBorn, out int yearBorn);


        //        try
        //        {
        //            YearsAbleToDrive = (DateTime.Now.Year - yearBorn);
        //            Result.IsVisible = true;
        //            Result.Text = $"You have been able to drive for {YearsAbleToDrive.ToString()} years";

        //        }
        //        catch(Exception)
        //        {
        //            Result.Text = "You didn't enter a valid year/number";
        //        }
        //    }

        //}
    }
}
