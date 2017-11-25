using Android.App;
using Xamarin.Forms;
using Android.Content.PM;
using XFOrientation.Interfaces;

[assembly: Dependency(typeof(AndroidOrientation))]
namespace XFOrientation.Interfaces
{
    public class AndroidOrientation : IAndroidOrientation
    {
        public void RotateToLandscape()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Landscape;
        }

        public void RotateToPortrait()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Portrait;
        }
    }
}