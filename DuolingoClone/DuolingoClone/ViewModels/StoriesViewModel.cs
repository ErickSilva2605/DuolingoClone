using DuolingoClone.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoClone.ViewModels
{
    public class StoriesViewModel : ViewModelBase
    {
        private readonly IStoriesService _storiesService;
        public StoriesViewModel(IStoriesService storiesService)
        {
            _storiesService = storiesService;
        }
    }
}
