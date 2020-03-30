using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class AchievementsServiceFake : IAchievementsService
    {
        private readonly string _profileImageAchievement1 = "profile_achievements_01";
        private readonly string _profileImageAchievement2 = "profile_achievements_02";
        private readonly string _profileImageAchievement3 = "profile_achievements_03";
        private readonly string _profileImageAchievement4 = "profile_achievements_04";
        private readonly string _profileImageAchievement5 = "profile_achievements_05";
        private readonly string _profileImageAchievement6 = "profile_achievements_06";
        public async Task<IList<AchievementsModel>> GetAchievements()
        {
            return await Task.Run(() =>
            {
                return new List<AchievementsModel>
                {
                    GetAchievement(_profileImageAchievement1, "NÍVEL 9", "Majestade", "Ganhe 80 coroas", 0.9875, "79/80", true),
                    GetAchievement(_profileImageAchievement2, "NÍVEL 8", "Intelectual", "Aprenda 1.000 novas palavras em um curso", 0.863, "863/1K", true),
                    GetAchievement(_profileImageAchievement3, "NÍVEL 5", "Na Mosca", "Complete 100 lições sem errar nada", 0.81, "81/100", true),
                    GetAchievement(_profileImageAchievement4, "NÍVEL 7", "Sabe-tudo", "Ganhe 7500 XP", 0.72, "5,4K/7,5K", true),
                    GetAchievement(_profileImageAchievement5, "NÍVEL 3", "Fogueira", "Alcance uma ofensiva de 14 dias", 0.5, "7/14", true),
                    GetAchievement(_profileImageAchievement6, "NÍVEL 1", "Estrategista", "Voçê leu uma dica", 0.1, string.Empty, false)
                };
            });
        }

        private AchievementsModel GetAchievement(
            string icon,
            string level,
            string name,
            string description,
            double progress,
            string status,
            bool isActive)
        {
            return new AchievementsModel
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status,
                IsActive = isActive
            };
        }
    }
}
