using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using Prism;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DuolingoClone.ViewModels
{
    public class ProfileViewModel : ViewModelBase, IActiveAware
    {
        private readonly IAchievementsService _achievementsService;
        private readonly IFriendsService _friendsService;

        public ObservableCollection<AchievementsModel> Achievements { get; private set; }
        public ObservableCollection<FriendModel> Friends { get; private set; }
        public ProfileViewModel(IAchievementsService achievementsService, IFriendsService friendsService)
        {
            _achievementsService = achievementsService;
            _friendsService = friendsService;

            Achievements = new ObservableCollection<AchievementsModel>();
            Friends = new ObservableCollection<FriendModel>();
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

                var friends = await _friendsService.GetFriends();

                if (Friends.Any())
                    Friends.Clear();

                foreach (var friend in friends)
                    Friends.Add(friend);
            }
        }
    }
}
