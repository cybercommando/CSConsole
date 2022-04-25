using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPattern.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> GetEmployee(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
