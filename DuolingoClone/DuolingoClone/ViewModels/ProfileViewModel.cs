using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using Prism;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.ViewModels
{
    public class ProfileViewModel : ViewModelBase, IActiveAware
    {
        private readonly IAchievementsService _achievementsService;

        public ObservableCollection<AchievementsModel> Achievements { get; private set; }
        public ProfileViewModel(IAchievementsService achievementsService)
        {
            _achievementsService = achievementsService;
            Achievements = new ObservableCollection<AchievementsModel>();
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
            await RaiseIsActivatedChangedAsync();
        }

        private async Task RaiseIsActivatedChangedAsync()
        {
            if (IsActive)
            {
                var achievements = await _achievementsService.GetAchievements();

                if (Achievements.Any())
                    Achievements.Clear();

                foreach (var achievement in achievements)
                    Achievements.Add(achievement);
            }
        }
    }
}
