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
                            GetNewLesson("Introdução")
                        }
                     },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Multi,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Saudações"),
                            GetNewLesson("Viagem")
                        }
                    },

                    new LessonGroupModel
                    {
                        Type = LessonGroupTypeEnum.Bonus,
                        Lessons = new List<LessonModel>()
                        {
                            GetNewLesson("Bônus"),
                            GetNewLesson("Bônus"),
                            GetNewLesson("Bônus")
                        }
                    }
                };
            });
        }

        private LessonModel GetNewLesson(string name)
        {
            return new LessonModel
            {
                Name = name
            };
        }
    }
}
