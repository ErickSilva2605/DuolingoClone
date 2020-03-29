using DuolingoClone.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoClone.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        private IAchievementsService _achievementsService;
        public ProfileViewModel(IAchievementsService achievementsService)
        {
            _achievementsService = achievementsService;
        }
    }
}
