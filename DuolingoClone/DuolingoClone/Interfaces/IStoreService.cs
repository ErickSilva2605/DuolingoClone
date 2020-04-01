using DuolingoClone.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.Interfaces
{
    public interface IStoreService
    {
        Task<IList<StoreItemGroupModel>> GetStoreItemGroup();
    }
}
