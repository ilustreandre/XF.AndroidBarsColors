using Xamarin.Forms;

namespace XF.AndroidBarsColors
{
	public partial class GreenBars : ContentPage
	{
		public GreenBars ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Helpers.BarsColorsHelper.SetStatusBarColor("#16EB31");
            Helpers.BarsColorsHelper.BarBackgroundColor("#7AF389");
            Helpers.BarsColorsHelper.BarTextColor("#000000");
        }
    }
}