using GraphQl_HotChochlete.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl_HotChochlete.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;

        public EmployeeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Employee> Create(Employee emp)
        {
            try
            {
                await _dbContext.Employees.AddAsync(emp);
                await _dbContext.SaveChangesAsync();
                return emp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> Delete(DeleteVM deleteVm)
        {
            var emp = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == deleteVm.Id);
            if (emp is not null)
            {
                _dbContext.Employees.Remove(emp);
                await _dbContext.SaveChangesAsync();
            }
            return true;
        }

        public IQueryable<Employee> GetAll()
        {
            return _dbContext.Employees.AsQueryable();
        }
        public class DeleteVM
        {
            public int Id { get; set; }
        }
    }
}
