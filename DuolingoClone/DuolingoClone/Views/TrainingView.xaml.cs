using DuolingoClone.Interfaces;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuolingoClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingView : ContentPage, ITabPageIcons
    {
        private readonly string _iconTraining = "tab_training";
        private readonly string _iconTrainingSelected = "tab_training_selected";
        public TrainingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return _iconTraining;
        }

        public string GetSelectedIcon()
        {
            return _iconTrainingSelected;
        }
    }
}