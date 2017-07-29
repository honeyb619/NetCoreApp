using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.BusinessLogic;
using TestWebApi.Model;

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            EmployeeDAL dal = new EmployeeDAL();
            return dal.getEmployeeDetails();

        }
        [HttpPost]
        public IEnumerable<Employee> Post(Employee employee)
        {
            EmployeeDAL dal = new EmployeeDAL();
            var employeeList= dal.AddEmployee(employee);
            return employeeList;
        }

    }
}
