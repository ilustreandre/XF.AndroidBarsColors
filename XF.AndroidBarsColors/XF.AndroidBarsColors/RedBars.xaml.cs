using Xamarin.Forms;

namespace XF.AndroidBarsColors
{
	public partial class RedBars : ContentPage
	{
		public RedBars ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Helpers.BarsColorsHelper.SetStatusBarColor("#F54444");
            Helpers.BarsColorsHelper.BarBackgroundColor("#FE0505");
            Helpers.BarsColorsHelper.BarTextColor("#FFFFFF");
        }
    }
}