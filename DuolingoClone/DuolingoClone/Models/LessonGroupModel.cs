using DuolingoClone.Enums;
using System.Collections.Generic;

namespace DuolingoClone.Models
{
    public class LessonGroupModel
    {
        public LessonGroupTypeEnum Type { get; set; }
        public IList<LessonModel> Lessons { get; set; }

        public LessonGroupModel()
        {
            Lessons = new List<LessonModel>();
        }
    }
}
