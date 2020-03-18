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
    public partial class StoreView : ContentPage, IDynamicTitle, ITabPageIcons
    {
        private readonly string _iconStore = "tab_store";
        private readonly string _iconStoreSelected = "tab_store_selected";
        private View _title;
        public StoreView()
        {
            InitializeComponent();
        }

        public string GetIcon()
        {
            return _iconStore;
        }

        public string GetSelectedIcon()
        {
            return _iconStoreSelected;
        }

        public View GetTitle()
        {
            if (_title == null)
                _title = new StoreTitleView();

            return _title;
        }
    }
}