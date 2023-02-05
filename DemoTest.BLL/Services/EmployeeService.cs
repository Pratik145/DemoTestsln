using DemoTest.BLL.Services.Contracts;
using DemoTest.DAL.Models;
using DemoTest.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IGenericRepository<Employee> _repository;
        public EmployeeService(IGenericRepository<Employee> repository) {
            _repository = repository;
        }

       public async Task<List<Employee>> GetEmployees()
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
