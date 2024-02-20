using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using EmployeeManagement.ViewModel;

namespace EmployeeManagement.BL
{
    public class EmployeesBL : IEmployeesBL
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesBL(IEmployeeService service)
        {
            _employeeService = service;
        }
        public List<Employees> GetEmployeesListBL()
        {
            var employees = _employeeService.GetEmployeesList();
            if(employees != null)
            {
                return employees;
            }
            else
            {
               return new List<Employees>();
            }
          
        }

        public Employees GetEmployeeDetailsByIdBL(int empId)
        {
            var employees = _employeeService.GetEmployeeDetailsById(empId);
            if (employees != null)
            {
                return employees;
            }
            else
            {
                return new Employees();
            }
        }

        public ResponseModel SaveEmployeeBL(Employees employeeModel)
        {
            var model = _employeeService.SaveEmployee(employeeModel);
            return model;
        }

        public ResponseModel DeleteEmployeeBL(int employeeId)
        {
            var model = _employeeService.DeleteEmployee(employeeId);
            return model;
        }
    }
}
