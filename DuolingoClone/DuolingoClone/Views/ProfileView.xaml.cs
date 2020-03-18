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
        private View _title;
        public ProfileView()
        {
            InitializeComponent();
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
    }
}