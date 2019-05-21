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
        public BooksWindow BooksWindow { get; set; }
        public StudentViewModel()
        {
            CurrentBook = new Book();
        }
        private Book currentBook;
        public Book CurrentStudent
        {
            get
            {
                return currentBook;
            }
            set
            {
                currentBook = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook)));
            }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {

                return selectedBook;
            }
            set
            {
                selectedBook = value;


                if (value != null)
                {
                    State = 1;
                    CurrentBook = SelectedBook.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedBook)));
            }
        }
    }
}






