using Android.App;

using XF.AndroidBarsColors.Helpers;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(XF.AndroidBarsColors.Droid.Helpers.NavigationBarColorHelper))]
namespace XF.AndroidBarsColors.Droid.Helpers
{
    public class NavigationBarColorHelper : INavigationBarColorHelper
    {
        public void SetStatusBarColor(Color color)
         => ((Activity)Forms.Context).Window.SetStatusBarColor(color.ToAndroid());
    }
}