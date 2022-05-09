using GraphQl_HotChochlete.Models;

namespace GraphQl_HotChochlete.Services
{
    public interface IEmployeeService
    {
        Task<Employee> Create(Employee emp);
        Task<bool> Delete(EmployeeService.DeleteVM deleteVM);
        IQueryable<Employee> GetAll();
    }
}
