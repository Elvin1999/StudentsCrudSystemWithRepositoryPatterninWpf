using StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction;
using StudentSystemWithRepositoryPatterninWpf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.DataAccess.SqlServer
{
    class SqlStudentRepository : IStudentRepository
    {
        SqlContext db;
        public SqlStudentRepository(SqlContext db)
        {
            this.db = db;
        }

        public void AddData(Student data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Student data)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Student GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Student data)
        {
            throw new NotImplementedException();
        }
    }
}
