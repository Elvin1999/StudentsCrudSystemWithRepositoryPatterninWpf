using StudentSystemWithRepositoryPatterninWpf.Domain.Commands;
using StudentSystemWithRepositoryPatterninWpf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels
{
   public class StudentViewModel:BaseViewModel
    {
        public AddCommand AddCommand => new AddCommand(this);
        public UpdateCommand UpdateCommand => new UpdateCommand(this);
        public DeleteCommand DeleteCommand => new DeleteCommand(this);
        private ObservableCollection<Student> allStudents;
        public ObservableCollection<Student> AllStudents
        {
            get
            {
                return allStudents;
            }
            set
            {
                allStudents = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllStudents)));
            }
        }

        public StudentViewModel()
        {
            CurrentStudent = new Student();
        }
        private Student currentStudent;
        public Student CurrentStudent
        {
            get
            {
                return currentStudent;
            }
            set
            {
                currentStudent = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentStudent)));
            }
        }

        private Student selectedStudent;
        public Student SelectedStudent
        {
            get
            {

                return selectedStudent;
            }
            set
            {
                selectedStudent = value;


                if (value != null)
                {

                    CurrentStudent = SelectedStudent.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedStudent)));
            }
        }
    }
}






