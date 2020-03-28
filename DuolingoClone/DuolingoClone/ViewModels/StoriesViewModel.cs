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
    public class StoriesViewModel : ViewModelBase, IActiveAware
    {
        private readonly IStoriesService _storiesService;
        public ObservableCollection<StoriesGroupModel> Stories { get; private set; }

        private bool _isActive;
        public bool IsActive 
        { 
            get => _isActive; 
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged); 
        }

        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
            Stories = new ObservableCollection<StoriesGroupModel>();
        }

        public event EventHandler IsActiveChanged;

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                var groupsStories = await GetStories();

                if (Stories.Any())
                    Stories.Clear();

                foreach (var storieGroup in groupsStories)
                    Stories.Add(storieGroup);
            }
        }

        private async Task<IList<StoriesGroupModel>> GetStories()
        {
            return await _storiesService.GetStories();
        }
    }
}
