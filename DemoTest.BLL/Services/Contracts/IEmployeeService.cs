using DemoTest.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.BLL.Services.Contracts
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();

    }
}
