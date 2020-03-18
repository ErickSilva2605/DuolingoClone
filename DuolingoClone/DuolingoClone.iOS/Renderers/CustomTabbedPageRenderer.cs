using CoreGraphics;
using DuolingoClone.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace DuolingoClone.iOS.Renderers
{
    public class CustomTabbedPageRenderer : TabbedRenderer
    {
        private readonly float _tabBarHeight = 150f;
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            TabBar.Frame = new CGRect(
                TabBar.Frame.X,
                TabBar.Frame.Y + (TabBar.Frame.Height - _tabBarHeight),
                TabBar.Frame.Width,
                _tabBarHeight
            );
        }
    }
}