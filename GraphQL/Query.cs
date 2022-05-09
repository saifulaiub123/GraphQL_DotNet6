using GraphQl_HotChochlete.Models;
using GraphQl_HotChochlete.Services;

namespace GraphQl_HotChochlete.GraphQL
{
    public class Query
    {
        private readonly IEmployeeService _employeeService;

        public Query(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IQueryable<Employee> Employees => _employeeService.GetAll();
        
    }
}
