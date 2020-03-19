using CoreGraphics;
using DuolingoClone.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]
namespace DuolingoClone.iOS.Renderers
{
    public class CustomNavigationPageRenderer : NavigationRenderer
    {
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if (Toolbar != null)
            {
                Toolbar.SizeToFit();

                Toolbar.Frame = new CGRect
                {
                    X = 0,
                    Y = View.Bounds.Height - Toolbar.Frame.Height,
                    Width = View.Bounds.Width,
                    Height = Toolbar.Frame.Height
                };
            }
        }
    }
}