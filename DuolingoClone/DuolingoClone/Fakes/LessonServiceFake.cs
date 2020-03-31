using DuolingoClone.Enums;
using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DuolingoClone.Fakes
{
    public class LessonServiceFake : ILessonService
    {
        private readonly string _colorLevel0 = "#C287F8";
        private readonly string _colorLevel1 = "#4FAEF0";
        private readonly string _colorLevel2 = "#8BC63B";
        private readonly string _colorLevel3 = "#EC5954";
        private readonly string _colorLevel4 = "#F19A37";
        private readonly string _colorLevel5 = "#F7C745";
        private readonly string _colorBonus = "#FFFFFF";

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
                            GetNewLesson("Introdução", "5", "lesson_egg", _colorLevel5, 1.0)
                        }
                     },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Saudações", "4", "lesson_dialog", _colorLevel4, 0.8),
                            GetNewLesson("Viagem", "3", "lesson_airplane", _colorLevel3, 0.0)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Cafeteria", "2", "lesson_hamburger", _colorLevel2, 0.4),
                            GetNewLesson("Famílias", "1", "lesson_baby", _colorLevel1, 0.7)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0),
                            GetNewLesson("Bônus", string.Empty, "lesson_plus", _colorBonus, 0.0)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Loja", string.Empty, "lesson_sock", _colorLevel0, 0.5),
                            GetNewLesson("Estudos", "1", "lesson_pencil", _colorLevel1, 1.0),
                            GetNewLesson("Ocupações", "3", "lesson_hat", _colorLevel3, 0.3)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Single,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Encontros", string.Empty, "lesson_bag", _colorLevel0, 0.0)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson(string.Empty, "1", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Rotinas", "1", "lesson_bike", _colorLevel1, 0.1),
                            GetNewLesson("Emoções", string.Empty, "lesson_heart", _colorLevel0, 0.9)
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Divisor,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson(string.Empty, "2", "lesson_divisor_castle", string.Empty, 0.0)
                        }
                    }
                };
            });
        }

        private LessonModel GetNewLesson(string name, string level, string icon, string color, double progress)
        {
            return new LessonModel
            {
                Name = name,
                Level = level,
                Icon = icon,
                Color = color,
                Progress = progress

            };
        }
    }
}
