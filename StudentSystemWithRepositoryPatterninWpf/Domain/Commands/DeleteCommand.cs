using StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Commands
{

    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public StudentViewModel StudentViewModel { get; set; }
        public DeleteCommand(StudentViewModel StudentViewModel)
        {
            this.StudentViewModel = StudentViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
