using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoClone.Models
{
    public class StoriesGroupModel : List<StoriesModel>
    {
        public string Name { get; private set; }

        public StoriesGroupModel(string name, List<StoriesModel> stories) : base(stories)
        {
            Name = name;
        }
    }
}
