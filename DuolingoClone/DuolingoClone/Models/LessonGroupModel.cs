using DuolingoClone.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
