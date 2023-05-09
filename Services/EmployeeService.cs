using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;
using System.Collections.Generic;

namespace DishDiscovery.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public EmployeeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _repositoryWrapper.EmployeeRepository.FindAll();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _repositoryWrapper.EmployeeRepository.GetById(employeeId);
        }

        public void CreateEmployee(Employee employee)
        {
            _repositoryWrapper.EmployeeRepository.Create(employee);
            _repositoryWrapper.Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            _repositoryWrapper.EmployeeRepository.Update(employee);
            _repositoryWrapper.Save();
        }

        public void DeleteEmployee(Employee employee)
        {
            _repositoryWrapper.EmployeeRepository.Delete(employee);
            _repositoryWrapper.Save();
        }
    }
}