using DuolingoClone.Enums;
using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        public async Task<IList<LessonGroupModel>> GetLessonsGroup()
        {
            return await Task.Run(() =>
            {
                return new List<LessonGroupModel>
                {
                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Introdução", "4", "lesson_egg", "#F19A37")
                        }
                     },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog", "#F19A37"),
                            GetNewLesson("Viagem", string.Empty, "lesson_airplane", "#C287F8")
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Cafeteria", string.Empty, "lesson_hamburger", "#C287F8"),
                            GetNewLesson("Famílias", string.Empty, "lesson_baby", "#C287F8")
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#FFFFFF"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#FFFFFF"),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", "#FFFFFF")
                        }
                    }
                };
            });
        }

        private LessonModel GetNewLesson(string name, string level, string icon, string color)
        {
            return new LessonModel
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color
            };
        }
    }
}
