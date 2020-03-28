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
        public ObservableCollection<StoriesModel> Stories { get; private set; }

        private bool _isActive;
        public bool IsActive 
        { 
            get => _isActive; 
            set => SetProperty(ref _isActive, value, RaiseIsActivatedChanged); 
        }

        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
            Stories = new ObservableCollection<StoriesModel>();
        }

        public event EventHandler IsActiveChanged;

        private async void RaiseIsActivatedChanged()
        {
            if (IsActive)
            {
                var stories = await GetStories();

                if (Stories.Any())
                    Stories.Clear();

                foreach (var storie in stories)
                    Stories.Add(storie);
            }
        }

        private async Task<IList<StoriesModel>> GetStories()
        {
            return await _storiesService.GetStories();
        }
    }
}
