using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using DishDiscovery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace DishDiscovery.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CustomerService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void AddCustomer(Customer customer)
        {
            _repositoryWrapper.CustomerRepository.Create(customer);
            _repositoryWrapper.Save();
        }
        public Customer GetCustomerById(int customerId)
        {
            return _repositoryWrapper.CustomerRepository.GetById(customerId);
        }
        public void UpdateCustomer(Customer customer)
        {
            _repositoryWrapper.CustomerRepository.Update(customer);
            _repositoryWrapper.Save();
        }

        public void DeleteCustomer(Customer customer)
        {
            _repositoryWrapper.CustomerRepository.Delete(customer);
            _repositoryWrapper.Save();
        }

    }
}

