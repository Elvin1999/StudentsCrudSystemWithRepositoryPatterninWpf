using StudentSystemWithRepositoryPatterninWpf.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ShowCommand ShowCommand => new ShowCommand(this);

    }
}

