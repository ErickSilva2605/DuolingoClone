using DuolingoClone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuolingoClone.Interfaces
{
    public interface IFriendsService
    {
        Task<IList<FriendModel>> GetFriends();
    }
}
