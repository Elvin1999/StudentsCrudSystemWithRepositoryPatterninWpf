using StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction;
using StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Commands
{
   public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public StudentViewModel StudentViewModel { get; set; }
        protected IUnitOfWork Db;
        public AddCommand(StudentViewModel StudentViewModel)
        {
            Db = App.DB;
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
