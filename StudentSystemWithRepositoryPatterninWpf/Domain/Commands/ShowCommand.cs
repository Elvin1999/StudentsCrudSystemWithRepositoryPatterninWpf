using StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels;
using StudentSystemWithRepositoryPatterninWpf.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Commands
{
    public class ShowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel MainViewModel { get; set; }
        public ShowCommand(MainViewModel MainViewModel)
        {
            this.MainViewModel = MainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.AllStudents = App.DB.StudentRepository.GetAllData();
            StudentView studentView = new StudentView(studentViewModel);
            studentView.ShowDialog();
        }
    }
}
