using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class FriendsServiceFake : IFriendsService
    {
        private readonly string _profileFriendLisa = "profile_friends_lisa";
        private readonly string _profileFriendBart = "profile_friends_bart";
        private readonly string _profileFriendHomer = "profile_friends_homer";
        private readonly string _profileFriendMarge = "profile_friends_marge";
        public async Task<IList<FriendModel>> GetFriends()
        {
            return await Task.Run(() => 
            {
                return new List<FriendModel>()
                {
                    GetNewFriend("Lisa Simpsons", _profileFriendLisa, "123456789 XP"),
                    GetNewFriend("Bart Simpsons", _profileFriendBart, "10000 XP"),
                    GetNewFriend("Homer Simpsons", _profileFriendHomer, "1 XP"),
                    GetNewFriend("Marge Simpsons", _profileFriendMarge, "100000 XP")
                };
            });
        }

        private FriendModel GetNewFriend(string name, string photo, string experience)
        {
            return new FriendModel
            {
                Name = name,
                Photo = photo,
                Experience = experience
            };
        }
    }
}
