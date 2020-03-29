using DuolingoClone.ContentViews;
using DuolingoClone.Interfaces;
using DuolingoClone.Views.TitleViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuolingoClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private readonly string _iconProfile = "tab_profile";
        private readonly string _iconProfileSelected = "tab_profile_selected";
        private readonly string _gridFriends = "gridFriends";
        private readonly string _gridAchievements = "gridAchievements";

        private Lazy<ProfileAchievementsContentView> _sectionAchievements = new Lazy<ProfileAchievementsContentView>();
        private Lazy<ProfileFriendsContentView> _sectionFriends = new Lazy<ProfileFriendsContentView>();

        private Grid _lastSelected;
        private View _title;

        public ProfileView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            int index = 0;
            foreach (var view in flexLayoutSection.Children)
            {
                if (view is Grid grid)
                {
                    if (index++ == 0)
                    {
                        GoToStateSelected(grid);
                        sectionContentView.Content = _sectionAchievements.Value;
                        continue;
                    }

                    GoToStateUnSelected(grid);
                }
            }
        }

        public string GetIcon()
        {
            return _iconProfile;
        }

        public string GetSelectedIcon()
        {
            return _iconProfileSelected;
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new ProfileTitleView();

            return _title;
        }

        private void OnTappedSection(object sender, EventArgs eventArgs)
        {
            if (sender is Grid grid)
            {
                GoToStateUnSelected(_lastSelected);
                GoToStateSelected(grid);

                if (grid.AutomationId == _gridAchievements)
                {
                    sectionContentView.Content = _sectionAchievements.Value;
                }

                if (grid.AutomationId == _gridFriends)
                {
                    sectionContentView.Content = _sectionFriends.Value;
                }
            }
        }

        private void GoToStateSelected(Grid grid)
        {
            _lastSelected = grid;

            if (grid.Children[0] is Label label && grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "Selected");
                VisualStateManager.GoToState(boxView, "Selected");

            }
        }

        private void GoToStateUnSelected(Grid grid)
        {
            if (grid.Children[0] is Label label && grid.Children[1] is BoxView boxView)
            {
                VisualStateManager.GoToState(label, "UnSelected");
                VisualStateManager.GoToState(boxView, "UnSelected");

            }
        }
    }
}