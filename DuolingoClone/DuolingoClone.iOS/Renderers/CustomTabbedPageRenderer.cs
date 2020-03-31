using CoreGraphics;
using DuolingoClone.Interfaces;
using DuolingoClone.iOS.Renderers;
using System;
using System.Threading.Tasks;
using UIKit;
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

        protected override async Task<Tuple<UIImage, UIImage>> GetIcon(Page page)
        {
            if (page is ITabPageIcons tabPage)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(tabPage.GetIcon()),
                        GetImageFromFile(tabPage.GetSelectedIcon())
                    )
                );
            }

            return await base.GetIcon(page);
        }

        private UIImage GetImageFromFile(string imageName)
        {
            return UIImage.
                FromFile(imageName).
                ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
        }
    }
}