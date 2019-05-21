using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction
{
    interface IUnitOfWork
    {
        void SaveChanges();
        IStudentRepository StudentRepository { get; }
    }
}
