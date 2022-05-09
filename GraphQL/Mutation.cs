using GraphQl_HotChochlete.Models;
using GraphQl_HotChochlete.Services;

namespace GraphQl_HotChochlete.GraphQL
{
    public class Mutation
    {
        private readonly IEmployeeService _employeeService;

        public Mutation(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee> Create(Employee employee) => await _employeeService.Create(employee);
        public async Task<bool> Delete(EmployeeService.DeleteVM deleteVm) => await _employeeService.Delete(deleteVm);
    }
}
