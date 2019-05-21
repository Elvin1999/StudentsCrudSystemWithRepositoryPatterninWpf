using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Entities
{
   public class Student
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsMonitor { get; set; }
        public string Monitor { get; set; }
    }
}

