using System;
using DuolingoClone.ContentViews;
using DuolingoClone.Models;
using Xamarin.Forms;

namespace DuolingoClone.Templates
{
    public class LessonGroupDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Single { get; private set; }
        public DataTemplate Multi { get; private set; }
        public DataTemplate Bonus { get; private set; }

        public LessonGroupDataTemplateSelector()
        {
            Single = new DataTemplate(typeof(LessonGroupSingleContentView));
            Multi = new DataTemplate(typeof(LessonGroupMultiContentView));
            Bonus = new DataTemplate(typeof(LessonGroupBonusContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is LessonGroupModel group)
            {
                if (group.Type == Enums.LessonGroupTypeEnum.Multi)
                    return Multi;

                if (group.Type == Enums.LessonGroupTypeEnum.Bonus)
                    return Bonus;
            }

            return Single;
        }
    }
}
