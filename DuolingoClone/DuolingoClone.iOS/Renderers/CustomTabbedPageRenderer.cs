using CoreGraphics;
using DuolingoClone.iOS.Renderers;
using DuolingoClone.Views;
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
        private readonly string _imageTabLessons = "tab_lessons.png";
        private readonly string _imageTabTraining = "tab_training.png";
        private readonly string _imageTabProfile = "tab_profile.png";
        private readonly string _imageTabRanking = "tab_ranking.png";
        private readonly string _imageTabStore = "tab_store.png";
        private readonly string _imageTabLessonsSelected = "tab_lessons_selected.png";
        private readonly string _imageTabTrainingSelected = "tab_training_selected.png";
        private readonly string _imageTabProfileSelected = "tab_profile_selected.png";
        private readonly string _imageTabRankingSelected = "tab_ranking_selected.png";
        private readonly string _imageTabStoreSelected = "tab_store_selected.png";
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
            if (page is LessonsView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(_imageTabLessons),
                        GetImageFromFile(_imageTabLessonsSelected)
                    )
                );
            }

            if (page is TrainingView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(_imageTabTraining),
                        GetImageFromFile(_imageTabTrainingSelected)
                    )
                );
            }

            if (page is ProfileView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(_imageTabProfile),
                        GetImageFromFile(_imageTabProfileSelected)
                    )
                );
            }

            if (page is RankingView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(_imageTabRanking),
                        GetImageFromFile(_imageTabRankingSelected)
                    )
                );
            }

            if (page is StoreView)
            {
                return await Task.FromResult(
                    new Tuple<UIImage, UIImage>(
                        GetImageFromFile(_imageTabStore),
                        GetImageFromFile(_imageTabStoreSelected)
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