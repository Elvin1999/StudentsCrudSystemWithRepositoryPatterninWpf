using StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace StudentSystemWithRepositoryPatterninWpf.Domain.Views
{
    /// <summary>
    /// Interaction logic for StudentView.xaml
    /// </summary>
    public partial class StudentView : Window
    {
        public StudentViewModel StudentViewModel { get; set; }
        public StudentView(StudentViewModel StudentViewModel)
        {
            InitializeComponent();
            this.StudentViewModel = StudentViewModel;

            
            DataContext = StudentViewModel;
        }
    }
}



