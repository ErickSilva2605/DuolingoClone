using DuolingoClone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuolingoClone.Interfaces
{
    public interface IStoriesService
    {
        Task<IList<StoriesGroupModel>> GetStories();
    }
}
