using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase, IInitialize
    {
        private readonly ILessonService _lessonService;
        public ICommand NavigateToTrainingCommand { get; private set; }
        public IList<LessonGroupModel> LessonGroups { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroups = new List<LessonGroupModel>();
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("FAB foi selecionado");
        }

        public async void Initialize(INavigationParameters parameters)
        {
            LessonGroups = await GetLessonsGroup();
        }

        private async Task<IList<LessonGroupModel>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
