using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryAPI.Repository
{
    public interface IEndUserRepository
    {
        Task<IEnumerable<EndUser>> GetEmployees();
        Task<EndUser> GetEmployee(int employeeId);
        Task<EndUser> AddEmployee(EndUser employee);
        Task<EndUser> UpdateEmployee(EndUser employee);
        Task DeleteEmployee(int employeeId);
    }
}
