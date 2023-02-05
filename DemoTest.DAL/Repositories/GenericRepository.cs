using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoTest.DAL.DataContext;
using DemoTest.DAL.Models;
using DemoTest.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DemoTest.DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly DemoTestContext _dbContext;
        public GenericRepository(DemoTestContext dbContext)
        {
            _dbContext = dbContext;
        }
        async Task<List<TModel>> IGenericRepository<TModel>.GetAllAsync()
        {
            try
            {
                return await _dbContext.Set<TModel>().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
