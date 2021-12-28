using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Repo.Contracts
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll(Func<T, bool> where = null);
    }
}
