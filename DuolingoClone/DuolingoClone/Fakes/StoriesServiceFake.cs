using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class StoriesServiceFake : IStoriesService
    {
        private readonly string _storieCoffeImage = "stories_coffe";
        private readonly string _storieCandleImage = "stories_candle";
        private readonly string _storieBreadImage = "stories_bread";
        private readonly string _storieGiftImage = "stories_gift";

        public async Task<IList<StoriesGroupModel>> GetStories()
        {
            return await Task.Run(() => 
            {
                return new List<StoriesGroupModel>
                {
                    new StoriesGroupModel(
                        "Série 1",
                        new List<StoriesModel>()
                        {
                            GetNewStories("Bom dia!", _storieCoffeImage),
                            GetNewStories("Um encontro", _storieCandleImage),
                            GetNewStories("Uma coisa", _storieBreadImage),
                            GetNewStories("Surpresa", _storieGiftImage)
                        }
                    )
                };
            });
        }

        private StoriesModel GetNewStories(string name, string image)
        { 
            return new StoriesModel
            {
                Name = name,
                Image = image
            };
        }
    }
}
