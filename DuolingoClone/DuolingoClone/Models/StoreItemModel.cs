using DuolingoClone.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuolingoClone.Models
{
    public class StoreItemModel
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public StoreItemTypeEnum Type { get; set; }
        public string GroupName { get; set; }
    }
}
