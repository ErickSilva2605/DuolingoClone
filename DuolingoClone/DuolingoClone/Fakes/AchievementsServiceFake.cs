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
        private readonly string _profileImageAchievement1 = "profile_Achievements_01";
        private readonly string _profileImageAchievement2 = "profile_Achievements_02";
        private readonly string _profileImageAchievement3 = "profile_Achievements_03";
        private readonly string _profileImageAchievement4 = "profile_Achievements_04";
        private readonly string _profileImageAchievement5 = "profile_Achievements_05";
        private readonly string _profileImageAchievement6 = "profile_Achievements_06";
        public async Task<IList<AchievementsModel>> GetAchievements()
        {
            return await Task.Run(() =>
            {
                return new List<AchievementsModel>
                {
                    GetAchievement(_profileImageAchievement1, "NÍVEL 9", "Majestade", "Ganhe 80 coroas", 98.75, "79/80"),
                    GetAchievement(_profileImageAchievement2, "NÍVEL 8", "Intelectual", "Aprenda 1.000 novas palavras em um curso", 86.3, "863/1K"),
                    GetAchievement(_profileImageAchievement3, "NÍVEL 5", "Na Mosca", "Complete 100 lições sem errar nada", 81, "81/100"),
                    GetAchievement(_profileImageAchievement4, "NÍVEL 7", "Sabe-tudo", "Ganhe 7500 XP", 72, "5,4K/7,5K"),
                    GetAchievement(_profileImageAchievement5, "NÍVEL 3", "Fogueira", "Alcance uma ofensiva de 14 dias", 50, "7/14"),
                    GetAchievement(_profileImageAchievement6, "NÍVEL 1", "Estrategista", "Voçê leu uma diac", 100, string.Empty)
                };
            });
        }

        private AchievementsModel GetAchievement(
            string icon,
            string level,
            string name,
            string description,
            double progress,
            string status)
        {
            return new AchievementsModel
            {
                Icon = icon,
                Level = level,
                Name = name,
                Description = description,
                Progress = progress,
                Status = status
            };
        }
    }
}
