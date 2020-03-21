using DuolingoClone.Interfaces;
using DuolingoClone.Models;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase, IInitialize
    {
        private readonly ILessonService _lessonService;
        public ICommand NavigateToTrainingCommand { get; private set; }
        public ObservableCollection<LessonGroupModel> LessonGroups { get; private set; }

        public LessonsViewModel(ILessonService lessonService)
        {
            _lessonService = lessonService;
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
            LessonGroups = new ObservableCollection<LessonGroupModel>();
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("FAB foi selecionado");
        }

        public async void Initialize(INavigationParameters parameters)
        {
            var groups = await GetLessonsGroup();

            foreach (var group in groups)
                LessonGroups.Add(group);
        }

        private async Task<IList<LessonGroupModel>> GetLessonsGroup()
        {
            return await _lessonService.GetLessonsGroup();
        }
    }
}
