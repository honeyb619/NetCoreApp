using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApi.Model;

namespace TestWebApi.BusinessLogic
{
    public class EmployeeDAL
    {

        public List<Employee> employeeList;
        public List<Employee> getEmployeeDetails()
        {
            employeeList=new List<Employee>();
            employeeList.AddRange
            (new List<Employee>(){
                new Employee(){
                    EmployeeId="1",
                    EmployeeName="Honey",
                    Salary=1200
                },new Employee(){
                     EmployeeId="1",
                     EmployeeName="Honey Bansal",
                     Salary=1250
                },new Employee(){
                     EmployeeId="1",
                     EmployeeName="Honey Bansal",
                     Salary=1350
                },
                new Employee(){
                     EmployeeId="1",
                     EmployeeName="Honey Bansal",
                     Salary=1450
                }});
            return employeeList;

        }

        public List<Employee> AddEmployee(Employee emp){
                        employeeList=new List<Employee>(){
                            new Employee(){
            EmployeeId=emp.EmployeeId,
            EmployeeName=emp.EmployeeName,
            Salary=emp.Salary
                            }
                        };
            return employeeList;

        }

    }
}
