using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using Prism;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DuolingoClone.ViewModels
{
    public class StoreViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoreService _storeService;
        public ObservableCollection<StoreItemGroupModel> Groups { get; private set; }
        public StoreViewModel(IStoreService storeService)
        {
            _storeService = storeService;
            Groups = new ObservableCollection<StoreItemGroupModel>();
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged);
        }

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                var storeGroups = await _storeService.GetStoreItemGroup();

                if (Groups.Any())
                    Groups.Clear();

                foreach (var group in storeGroups)
                    Groups.Add(group);
            }
        }
    }
}
