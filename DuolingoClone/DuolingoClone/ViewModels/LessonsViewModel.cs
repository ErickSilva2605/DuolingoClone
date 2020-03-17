using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DuolingoClone.ViewModels
{
    public class LessonsViewModel : ViewModelBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }
        public LessonsViewModel()
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("FAB foi selecionado");
        }
    }
}
