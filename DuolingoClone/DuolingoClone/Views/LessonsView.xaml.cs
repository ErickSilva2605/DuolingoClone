using DuolingoClone.Interfaces;
using DuolingoClone.Views.TitleViews;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuolingoClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LessonsView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private readonly string _iconLessons = "tab_lessons";
        private readonly string _iconLessonsSelected = "tab_lessons_selected";
        private View _title;
        public LessonsView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return _iconLessons;
        }

        public string GetSelectedIcon()
        {
            return _iconLessonsSelected;
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new LessonsTitleView();

            return _title;
        }
    }
}