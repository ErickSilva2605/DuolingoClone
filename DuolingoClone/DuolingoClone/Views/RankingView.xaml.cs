using DuolingoClone.Interfaces;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuolingoClone.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingView : ContentPage, ITabPageIcons
    {
        private readonly string _iconTabRanking = "tab_ranking";
        private readonly string _iconRankingSelected = "tab_ranking_selected";
        public RankingView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return _iconTabRanking;
        }

        public string GetSelectedIcon()
        {
            return _iconRankingSelected;
        }
    }
}