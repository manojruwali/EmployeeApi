using EmployeeApi.Models;
using EmployeeApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("Employee")]
  
    public class EmployeeController : Controller
    {
        public EmployeeController( IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        private readonly IEmployeeRepository EmployeeRepository;

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
          var emp=  EmployeeRepository.GetAllEmployees();


            return Ok(emp);

        }
    }
}
