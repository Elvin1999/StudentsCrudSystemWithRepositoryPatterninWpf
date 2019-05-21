using StudentSystemWithRepositoryPatterninWpf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction
{

   public interface IStudentRepository:IRepository<Student>
    {

    }
}
