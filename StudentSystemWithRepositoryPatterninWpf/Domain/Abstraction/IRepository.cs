using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemWithRepositoryPatterninWpf.Domain.Abstraction
{
   public interface IRepository<T>
    {
        T GetData(int id);
        List<T> GetAllData();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
