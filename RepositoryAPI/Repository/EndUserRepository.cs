using Microsoft.EntityFrameworkCore;
using RepositoryAPI.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryAPI.Repository
{
    public class EndUserRepository : IEndUserRepository
    {
        private readonly MyDBContext _myDbContext;
        public EndUserRepository(MyDBContext myDBContext)
        {
            _myDbContext = myDBContext;
        }
        public async Task<EndUser> AddEmployee(EndUser employee)
        {
            _myDbContext.Add(employee);
            await _myDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var user = await _myDbContext.EndUsers.FindAsync(employeeId);
            if (user != null)
            {
                _myDbContext.EndUsers.Remove(user);
                await _myDbContext.SaveChangesAsync();
            }
        }

        public async Task<EndUser> GetEmployee(int employeeId)
        {

            return await _myDbContext.EndUsers.FirstOrDefaultAsync(c => c.Id == employeeId);
        }

        public async Task<IEnumerable<EndUser>> GetEmployees()
        {
            return await _myDbContext.EndUsers.ToListAsync();
        }

        public async Task<EndUser> UpdateEmployee(EndUser employee)
        {
            if (employee != null)
            {
                _myDbContext.Update(employee);
                await _myDbContext.SaveChangesAsync();
            }
            return employee;
        }
    }
}
