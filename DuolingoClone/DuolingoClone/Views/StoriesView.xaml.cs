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
    public partial class StoriesView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private readonly string _iconStories = "tab_stories";
        private readonly string _iconStoriesSelected = "tab_stories_selected";
        private View _title;

        public StoriesView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return _iconStories;
        }

        public string GetSelectedIcon()
        {
            return _iconStoriesSelected;
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new StoriesTitleView();

            return _title;
        }
    }
}