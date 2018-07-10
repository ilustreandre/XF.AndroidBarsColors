using Xamarin.Forms;

namespace XF.AndroidBarsColors
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnRedBars.Clicked += (s, ea) 
                => App.Current.MainPage.Navigation.PushAsync(new RedBars());

            btnGreenBars.Clicked += (s, ea) 
                => App.Current.MainPage.Navigation.PushAsync(new GreenBars());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Helpers.BarsColorsHelper.SetStatusBarColor("#AD5FD4");
            Helpers.BarsColorsHelper.BarBackgroundColor("#8F19D2");
            Helpers.BarsColorsHelper.BarTextColor("#FFFFFF");
        }
    }
}