using Xamarin.Forms;

namespace XF.AndroidBarsColors.Helpers
{
    public static class BarsColorsHelper
    {
        public static void SetStatusBarColor(string hexColor)
        {
            Helpers.INavigationBarColorHelper nav = DependencyService.Get<Helpers.INavigationBarColorHelper>();
            nav?.SetStatusBarColor(Color.FromHex(hexColor));
        }

        public static void BarBackgroundColor(string hexColor)
            => App.Current.Resources["barBackgroundColor"] = hexColor;

        public static void BarTextColor(string hexColor)
            => App.Current.Resources["barTextColor"] = hexColor;
    }
}