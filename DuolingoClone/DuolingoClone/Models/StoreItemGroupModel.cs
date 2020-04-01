using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoClone.Models
{
    public class StoreItemGroupModel : List<StoreItemModel>
    {
        public string Name { get; private set; }

        public StoreItemGroupModel(string name, List<StoreItemModel> storeItems)
        {
            Name = name;
            AddRange(storeItems);
        }
    }
}
